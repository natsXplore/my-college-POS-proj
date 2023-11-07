Imports System.Data.OleDb
Imports System.IO
Public Class addStockForm
    Private Sub DateTime_Tick(sender As Object, e As EventArgs)
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTime.Enabled = True
        countRecords()
        stockRecords()
        tbCount.Enabled = False
        dgAddStock.ReadOnly = True
        dgAddStock.AllowUserToAddRows = False

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbBuyingPrice.Enabled = False
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False

        newProduct.Enabled = True
        addStock.Enabled = True
        Edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True
    End Sub

    Private Sub Exitts_Click(sender As Object, e As EventArgs)

    End Sub
    Sub clear()
        tbProduceName.Text = ""
        tbDescription.Text = ""
        tbQuantity.Text = ""
        tbBuyingPrice.Text = ""
        tbSellingPrice.Text = ""
        tbStock.Text = ""
        tbAddStock.Text = ""
        picClear()
    End Sub
    Sub picClear()
        Picture.Image = Nothing
        Picture.BackColor = Color.Empty
        Picture.Invalidate()
    End Sub
    Sub stockRecords()
        Try
            dbcon = "SELECT  * FROM tblstock "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dgAddStock.Rows.Clear()
            Do While dr.Read = True
                dgAddStock.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub BindtoText()
        With dgAddStock
            tbBarcodeID.Text = .CurrentRow.Cells(0).Value
        End With
    End Sub
    Sub stockIMG()
        Dim ms As New MemoryStream()
        Dim bmpImage As New Bitmap(Picture.Image)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim data As Byte() = ms.GetBuffer()
        Dim p As New OleDbParameter("@stockPhoto", OleDbType.Binary)
        p.Value = data
        cmd.Parameters.Add(p)
    End Sub
    Sub countRecords()
        dbConnection()
        Dim dbcon As String = "select COUNT (*) FROM tblstock "
        Dim cmd As New OleDbCommand(dbcon, conn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub
    Private Sub stockInfo()
        Try
            dbConnection()
            Dim cmd As New OleDbCommand("INSERT INTO tblstock VALUES(@BarcodeID,@ProductName,@Description,@BuyingPrice,@Quantity,@SellingPrice,@Stock,@stockPhoto)", conn)

            cmd.Parameters.AddWithValue("@BarcodeID", tbBarcodeID.Text)
            cmd.Parameters.AddWithValue("@ProductName", tbProduceName.Text)
            cmd.Parameters.AddWithValue("@Description", tbDescription.Text)
            cmd.Parameters.AddWithValue("@BuyingPrice", tbBuyingPrice.Text)
            cmd.Parameters.AddWithValue("@Quantity", tbQuantity.Text)
            cmd.Parameters.AddWithValue("@SellingPrice", tbSellingPrice.Text)
            cmd.Parameters.AddWithValue("@Stock", tbStock.Text)
            Dim ms As New MemoryStream()
            Picture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@stockPhoto", OleDbType.Binary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            stockRecords()
            ' count()
        Catch ex As Exception
            MessageBox.Show("Input stock picture", "Input picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub deleteStock()
        Try
            dbcon = "DELETE * FROM tblstock WHERE BarcodeID like'" & Trim(tbBarcodeID.Text) & "'"
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
    Private Sub BarcodeID()
        Try
            Dim BarcodeID As New Random
            Dim ID As Integer = BarcodeID.Next(1, 1000000)
            tbBarcodeID.Text = ID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ProductImg()
        Try
            dbConnection()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter(("select * from tblstock where BarcodeID ='" & Trim(tbBarcodeID.Text) & "'"), conn)

            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("stockPhoto")) Then
                    arrImage = dt.Rows(0).Item("stockPhoto")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Picture.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DgAddStock_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgAddStock.CellEnter
        BindtoText()
        newProduct.Enabled = True
        addStock.Enabled = True
        Save.Enabled = False
        Edit.Enabled = True
        Update.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True

        tbQuantity.Text = 1

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbQuantity.Enabled = False
        tbBuyingPrice.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False
    End Sub

    Private Sub DgAddStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAddStock.CellClick
        BindtoText()
        newProduct.Enabled = True
        addStock.Enabled = True
        Save.Enabled = False
        Edit.Enabled = True
        Update.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True

        tbQuantity.Text = 1

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbQuantity.Enabled = False
        tbBuyingPrice.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False
    End Sub
    Private Sub NewProduct_Click(sender As Object, e As EventArgs) Handles newProduct.Click

        tbBarcodeID.Text = ""
        tbSearch.Text = ""

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = True
        tbDescription.Enabled = True
        tbBuyingPrice.Enabled = True
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = True
        tbAddStock.Enabled = False

        newProduct.Enabled = False
        addStock.Enabled = False
        Edit.Enabled = False
        Update.Enabled = False
        Save.Enabled = True
        Refresh.Enabled = False
        Delete.Enabled = False
        Print.Enabled = False
        Cancel.Enabled = True
        About.Enabled = True
        Exitt.Enabled = True
        clear()
        tbQuantity.Text = 1
        BarcodeID()
        tbProduceName.Focus()
    End Sub

    Private Sub Exitt_Click(sender As Object, e As EventArgs) Handles Exitt.Click
        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbBuyingPrice.Enabled = False
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False

        newProduct.Enabled = True
        addStock.Enabled = True
        Edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True
        tbSearch.Text = ""
        Me.Hide()
        mainForm.Show()
    End Sub

    Private Sub BtnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Browse stock image..."
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Picture.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        newProduct.Enabled = False
        addStock.Enabled = False
        Save.Enabled = False
        Edit.Enabled = False
        Update.Enabled = True
        Refresh.Enabled = True
        Delete.Enabled = False
        Print.Enabled = False
        Cancel.Enabled = True
        About.Enabled = True
        Exitt.Enabled = True

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = True
        tbDescription.Enabled = True
        tbQuantity.Enabled = False
        tbBuyingPrice.Enabled = True
        tbSellingPrice.Enabled = False
        tbSearch.Enabled = True
        tbAddStock.Enabled = False
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim rowIndex = dgAddStock.SelectedRows(0).Index = 0
        Try
            If rowIndex <= dgAddStock.Rows.Count - 1 Then
                Dim firstRow As DataGridViewRow = dgAddStock.Rows(rowIndex)
                dgAddStock.CurrentCell = firstRow.Cells(0)
                dgAddStock.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim rowIndex = dgAddStock.SelectedRows(0).Index - 1
        Try
            If rowIndex <= dgAddStock.Rows.Count - 1 Then
                Dim prevRow As DataGridViewRow = dgAddStock.Rows(rowIndex)
                dgAddStock.CurrentCell = prevRow.Cells(0)
                dgAddStock.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rowIndex = dgAddStock.SelectedRows(0).Index + 1
        If rowIndex <= dgAddStock.Rows.Count - 1 Then

            Dim nextRow As DataGridViewRow = dgAddStock.Rows(rowIndex)
            dgAddStock.CurrentCell = nextRow.Cells(0)
            dgAddStock.Rows(rowIndex).Selected = True
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim rowIndex As Integer

        rowIndex = dgAddStock.Rows.Count - 1
        Dim lastRow As DataGridViewRow = dgAddStock.Rows(rowIndex)
        dgAddStock.CurrentCell = lastRow.Cells(0)
        dgAddStock.Rows(rowIndex).Selected = True
    End Sub

    Private Sub TbBarcodeID_OnValueChanged_1(sender As Object, e As EventArgs) Handles tbBarcodeID.OnValueChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tblstock where BarcodeID ='" & Trim(tbBarcodeID.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbProduceName.Text = dt.Rows(0).Item(1) & ""
                tbDescription.Text = dt.Rows(0).Item(2) & ""
                tbBuyingPrice.Text = dt.Rows(0).Item(3) & ""
                tbQuantity.Text = dt.Rows(0).Item(4) & ""

                tbSellingPrice.Text = dt.Rows(0).Item(5) & ""
                tbStock.Text = dt.Rows(0).Item(6) & ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ProductImg()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If tbProduceName.Text = "" And tbDescription.Text = "" And tbQuantity.Text = "" And tbBuyingPrice.Text = "" And tbSellingPrice.Text = "" And tbStock.Text = "" Then
            MessageBox.Show("Please fill up all fields.", "Input Details!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbProduceName.Text = "" Then
            MessageBox.Show("Input product name.", "Input product name!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbDescription.Text = "" Then
            MessageBox.Show("Input product description.", "Input description!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbBuyingPrice.Text = "" Then
            MessageBox.Show("Input product buying price.", "Input price!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbSellingPrice.Text = "" Then
            MessageBox.Show("Input product selling price.", "Input price!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbStock.Text = "" Then
            MessageBox.Show("Input amount of stock", "Input Stock!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            stockInfo()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbBuyingPrice.Enabled = False
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False

        newProduct.Enabled = True
        addStock.Enabled = True
        Edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True

        tbSearch.Text = ""
        stockRecords()
    End Sub

    Private Sub AddStock_Click(sender As Object, e As EventArgs) Handles addStock.Click
        tbAddStock.Text = ""
        tbAddStock.Focus()

        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbBuyingPrice.Enabled = False
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = True

        newProduct.Enabled = False
        addStock.Enabled = False
        Edit.Enabled = False
        Update.Enabled = True
        Save.Enabled = False
        Refresh.Enabled = False
        Delete.Enabled = False
        Print.Enabled = False
        Cancel.Enabled = True
        About.Enabled = True
        Exitt.Enabled = True
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        tbBarcodeID.Enabled = False
        tbProduceName.Enabled = False
        tbDescription.Enabled = False
        tbBuyingPrice.Enabled = False
        tbQuantity.Enabled = False
        tbSellingPrice.Enabled = False
        tbStock.Enabled = False
        tbAddStock.Enabled = False

        newProduct.Enabled = True
        addStock.Enabled = True
        Edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        Refresh.Enabled = True
        Delete.Enabled = True
        Print.Enabled = True
        Cancel.Enabled = False
        About.Enabled = True
        Exitt.Enabled = True
        Me.Hide()
        addStockDev.Show()
    End Sub

    Private Sub TbBuyingPrice_OnValueChanged(sender As Object, e As EventArgs) Handles tbBuyingPrice.OnValueChanged
        Try
            Dim interest As Double = 0.3
            Dim prod As Integer
            Dim sum As Integer
            prod = (Val(tbQuantity.Text) * Val(tbBuyingPrice.Text) * interest)
            sum = prod + Val(tbBuyingPrice.Text)
            tbSellingPrice.Text = Math.Round(sum, 2)
        Catch ex As Exception
            MessageBox.Show("Do not input some integer.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Try
            Dim fileExport As String = ("C:\Users\Jonathan\Desktop\Stocks.xlsx")
            If File.Exists(fileExport) Then
                File.Delete(fileExport)
            End If

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")

            For i = 0 To dgAddStock.RowCount - 1
                For j = 0 To dgAddStock.ColumnCount - 1
                    For k As Integer = 1 To dgAddStock.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgAddStock.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgAddStock(j, i).Value.ToString()
                    Next
                Next
            Next
            With xlWorkSheet
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
                .Columns("C").Delete()
            End With
            xlWorkBook.SaveAs(fileExport)
            xlWorkBook.Close()
            xlWorkBook = Nothing
            xlApp.Quit()

            Process.Start(fileExport)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearch.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MessageBox.Show("Are you sure want to delete this stock?", "Deleting stock", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbYes Then
            deleteStock()
            clear()
            tbBarcodeID.Text = ""

            tbBarcodeID.Enabled = False
            tbProduceName.Enabled = False
            tbDescription.Enabled = False
            tbBuyingPrice.Enabled = False
            tbQuantity.Enabled = False
            tbSellingPrice.Enabled = False
            tbStock.Enabled = False
            tbAddStock.Enabled = False

            newProduct.Enabled = True
            addStock.Enabled = True
            Edit.Enabled = True
            Update.Enabled = False
            Save.Enabled = False
            Refresh.Enabled = True
            Delete.Enabled = False
            Print.Enabled = True
            Cancel.Enabled = False
            About.Enabled = True
            Exitt.Enabled = True
            tbSearch.Text = ""
            stockRecords()

        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            dbcon = "UPDATE [tblstock] SET [Stock] = '" & Val(tbStock.Text) + Val(tbAddStock.Text) & "',[ProductName]='" & tbProduceName.Text & "',[Description]='" & tbDescription.Text & "',[Quantity]='" & tbQuantity.Text & "',[BuyingPrice]='" & tbBuyingPrice.Text & "',[SellingPrice]='" & tbSellingPrice.Text & "',[stockPhoto] = @stockPhoto WHERE [BarcodeID] = '" & tbBarcodeID.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            stockIMG()
            i = cmd.ExecuteNonQuery
            MessageBox.Show("Stock information successfuly updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAddStock.Text = ""
            stockRecords()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub TbSearch_OnValueChanged(sender As Object, e As EventArgs) Handles tbSearch.OnValueChanged
        Try
            dbcon = "SELECT * FROM [tblstock] where [BarcodeID] LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgAddStock.Rows.Clear()
            Do While dr.Read = True
                dgAddStock.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        dbConnection()
        Dim dbcon1 As String = "SELECT COUNT(*) FROM [tblstock] where [BarcodeID] LIKE '" & Trim(tbSearch.Text) & "%'"
        Dim cmd1 As New OleDbCommand(dbcon1, conn)
        dr = cmd1.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub

    Private Sub tbBuyingPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbBuyingPrice.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbAddStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAddStock.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStock.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        stockRecords()
    End Sub

    Private Sub BtnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        picClear()
    End Sub
End Class