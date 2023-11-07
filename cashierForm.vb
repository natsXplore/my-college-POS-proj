Imports System.Data.OleDb
Imports ZXing
Public Class cashierForm
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        mainForm.Show()
    End Sub
    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgCashier.ReadOnly = True
        dgCashier.AllowUserToAddRows = False

        dateTime.Enabled = True
        TransactionID()
        bindStock()

        tbTransaction.Enabled = False
        tbBarcode.Enabled = False
        comboProductList.Enabled = True

        tbPrice.Enabled = False
        tbStock.Enabled = False
        tbQuantity.Enabled = True
        tbTotal.Enabled = False

        tbTotalItems.Enabled = False
        tbTotalAmount.Enabled = False

        tbAmountPaid.Enabled = False
        tbChange.Enabled = False

        btnAddtoCart.Enabled = True
        btnPay.Enabled = False
        btnReceipt.Enabled = False

        delete.Enabled = False

        tbQuantity.Select()

        grid()

        receiptForm.dgReceipt.Columns(0).Name = "Product"
        receiptForm.dgReceipt.Columns(1).Name = "Qty"
        receiptForm.dgReceipt.Columns(2).Name = "Unit price"
        receiptForm.dgReceipt.Columns(3).Name = "Amount"

        receiptForm.dgReceipt.Columns(0).Width = 10
        receiptForm.dgReceipt.Columns(1).Width = 3
        receiptForm.dgReceipt.Columns(2).Width = 3
        receiptForm.dgReceipt.Columns(3).Width = 50
    End Sub
    Private Sub grid()
        receiptForm.dgReceipt.ScrollBars = ScrollBars.None

        receiptForm.dgReceipt.RowHeadersVisible = False
        receiptForm.dgReceipt.ColumnCount = 4

        receiptForm.dgReceipt.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        receiptForm.dgReceipt.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub
    Private Sub cal()
        Dim total As Integer = 0
        Dim sum As Double
        For index As Integer = 0 To receiptForm.dgReceipt.RowCount - 1
            total += Convert.ToDouble(receiptForm.dgReceipt.Rows(index).Cells(3).Value.ToString)
        Next
        receiptForm.lblTotalAmount.Text = FormatCurrency(total.ToString)
    End Sub
    Private Sub calPayment()
        Dim cash As Integer = tbAmountPaid.Text
        Dim change As Integer = tbChange.Text
        receiptForm.lblCash.Text = FormatCurrency(tbAmountPaid.Text)
        receiptForm.lblChange.Text = FormatCurrency(tbChange.Text)
    End Sub
    Private Sub calVat()
        Dim vtbl As Double = 1.12
        Dim amount As Double
        Dim total As Integer
        amount = Val(tbTotalAmount.Text) / vtbl
        receiptForm.lblvtbl.Text = Math.Round(amount, 2)
        receiptForm.lblvat.Text = Math.Round(amount * 0.12, 2)
    End Sub
    Private Sub resize()
        receiptForm.dgReceipt.Height = receiptForm.dgReceipt.ColumnHeadersHeight + receiptForm.dgReceipt.Rows.Cast(Of DataGridViewRow).Sum(Function(r) (r.Height))
        receiptForm.Panel2.Height = receiptForm.dgReceipt.Height + 350

        receiptForm.dgReceipt.ClearSelection()
    End Sub
    Public Sub bindStock()
        Dim str As String = "Select ProductName From tblstock order by ProductName"
        Dim dt As DataTable = getDataTable(str)

        comboProductList.DataSource = dt
        comboProductList.DisplayMember = "ProductName"

        If comboProductList.Items.Count > 0 Then
            comboProductList.SelectedIndex = 0
        End If
    End Sub
    Private Sub TransactionID()
        Try
            Dim BarcodeID As New Random
            Dim ID As Integer = BarcodeID.Next(1, 1000000000)
            tbTransaction.Text = ID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub deleteProduct()
        Try
            dbcon = "DELETE * FROM tblcashier WHERE BarcodeID like'" & Trim(tbBarcode.Text) & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub addProduct()
        Try
            dbcon = "INSERT INTO tblcashier VALUES( '" & tbTransaction.Text & "', '" & tbBarcode.Text & "', '" & comboProductList.Text & "','" & tbQuantity.Text & "', '" & tbPrice.Text & "','" & tbTotal.Text & "','" & Date.Now & "')"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim num As Integer
            num = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub loadProduct()
        Try
            dbcon = "SELECT BarcodeID,ProductName,Quantity,SellingPrice,TotalAmount FROM tblcashier WHERE TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgCashier.Rows.Clear()
            Do While dr.Read = True
                dgCashier.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub totalAmount()
        Try
            dbcon = "SELECT sum(TotalAmount) FROM tblcashier where TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                tbTotalAmount.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Private Sub totalItems()
        Try

            dbcon = "SELECT sum(Quantity) FROM tblcashier where TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                tbTotalItems.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Private Sub reduceStock()
        Try
            dbcon = "UPDATE tblstock set Stock=Stock - '" & Val(tbTotalItems.Text) & "'where BarcodeID='" & tbBarcode.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub BtnAddtoCart_Click(sender As Object, e As EventArgs) Handles btnAddtoCart.Click

        Try
            Dim stock As Integer = 0
            stock = tbStock.Text
            If tbQuantity.Text = "" Then
                MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf tbQuantity.Text = 0 Then
                MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf tbQuantity.Text > stock Then
                MessageBox.Show("Sorry, Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim rnum As Integer = receiptForm.dgReceipt.Rows.Add

                Dim writer As New BarcodeWriter
                writer.Format = BarcodeFormat.CODE_128
                receiptForm.barcodePic.Image = writer.Write(tbTransaction.Text)

                receiptForm.dgReceipt.Rows.Item(rnum).Cells(0).Value = comboProductList.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(1).Value = tbQuantity.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(2).Value = tbPrice.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(3).Value = tbTotal.Text

                receiptForm.lblTransaction.Text = tbTransaction.Text
                receiptForm.lblCashier.Text = tbCashier.Text
                grid()
                cal()

                tbAmountPaid.Enabled = True

                btnAddtoCart.Enabled = True
                btnPay.Enabled = True
                btnReceipt.Enabled = False

                tbStock.Text = Val(tbStock.Text) - Val(tbQuantity.Text)
                addProduct()
                loadProduct()
                totalAmount()
                totalItems()
                tbTotal.Text = ""
                tbQuantity.Text = ""

                tbAmountPaid.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If tbAmountPaid.Text = "" Then
            MessageBox.Show("Input amount to proceed.", "Amount paid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAmountPaid.Focus()
            Exit Sub
        ElseIf tbChange.Text < 0 Then
            MessageBox.Show("You do not have sufficient amount to proceed with this purchase.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            dbcon = "INSERT INTO tblreport VALUES('" & tbTransaction.Text & "','" & comboProductList.Text & "', '" & tbTotalItems.Text & "', '" & tbTotalAmount.Text & "','" & tbAmountPaid.Text & "', '" & tbChange.Text & "', '" & Date.Now & "')"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                reduceStock()
                MessageBox.Show("Your purchase was successful.", "Purchase successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TransactionID()
                calPayment()
                calVat()
                receiptForm.lblTotal.Text = "(" + tbTotalItems.Text + ")"
                dgCashier.Rows.Clear()
                tbTotalItems.Text = ""
                tbTotalAmount.Text = ""
                tbAmountPaid.Text = ""
                tbChange.Text = ""

                btnAddtoCart.Enabled = True
                btnPay.Enabled = True
                btnReceipt.Enabled = True
            Else
                MessageBox.Show("Purchase unsuccessful", "Purchase unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub TbAmountPaid_OnValueChanged(sender As Object, e As EventArgs) Handles tbAmountPaid.OnValueChanged
        Dim change As Double
        change = Val(tbAmountPaid.Text) - Val(tbTotalAmount.Text)
        tbChange.Text = change.ToString("n2")
    End Sub
    Private Sub ComboProductList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductList.SelectedIndexChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tblstock where ProductName ='" & Trim(comboProductList.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbPrice.Text = dt.Rows(0).Item("SellingPrice") & ""
                tbStock.Text = dt.Rows(0).Item("Stock") & ""
                tbBarcode.Text = dt.Rows(0).Item("BarcodeID") & ""
            End If
            tbQuantity.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TbQuantity_OnValueChanged(sender As Object, e As EventArgs) Handles tbQuantity.OnValueChanged
        Try
            Dim amount As Double
            amount = Val(tbPrice.Text) * Val(tbQuantity.Text)
            tbTotal.Text = amount
        Catch ex As Exception
            MessageBox.Show("Do not input some integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If MessageBox.Show("Are you sure want to delete all items?", "Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            tbStock.Text = ""

            deleteProduct()
            loadProduct()
            tbQuantity.Text = ""
            tbTotal.Text = ""
            tbTotalItems.Text = ""
            tbTotalAmount.Text = ""
            tbAmountPaid.Text = ""
            tbChange.Text = ""
            receiptForm.dgReceipt.Rows.Clear()
            bindStock()
        End If
    End Sub
    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        TransactionID()
        loadProduct()
        tbQuantity.Text = ""
        tbTotal.Text = ""
        tbTotalItems.Text = ""
        tbTotalAmount.Text = ""
        tbAmountPaid.Text = ""
        tbChange.Text = ""
        receiptForm.dgReceipt.Rows.Clear()
        bindStock()
    End Sub
    Private Sub TbQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQuantity.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAmountPaid.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub
    Private Sub DgCashier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCashier.CellClick
        delete.Enabled = True
    End Sub
    Private Sub BtnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        receiptForm.Show()
    End Sub
    Private Sub dgReceipt_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        resize()
    End Sub
    Private Sub dgReceipt_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        resize()
    End Sub
    Private Sub About_Click(sender As Object, e As EventArgs) Handles about.Click
        Me.Hide()
        cashierDev.Show()
    End Sub
End Class