Imports System.Data.OleDb
Public Class stockForm
    Private Sub StockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dgStock.ReadOnly = True
        dgStock.AllowUserToAddRows = False
        tbCount.Enabled = False
        stockRecords()
        countRecords()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Sub stockRecords()
        Try
            dbcon = "SELECT  * FROM tblstock "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dgStock.Rows.Clear()
            Do While dr.Read = True
                dgStock.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
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

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim rowIndex = dgStock.SelectedRows(0).Index = 0
        Try
            If rowIndex <= dgStock.Rows.Count - 1 Then
                Dim firstRow As DataGridViewRow = dgStock.Rows(rowIndex)
                dgStock.CurrentCell = firstRow.Cells(0)
                dgStock.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rowIndex = dgStock.SelectedRows(0).Index + 1
        If rowIndex <= dgStock.Rows.Count - 1 Then

            Dim nextRow As DataGridViewRow = dgStock.Rows(rowIndex)
            dgStock.CurrentCell = nextRow.Cells(0)
            dgStock.Rows(rowIndex).Selected = True
        End If
    End Sub
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim rowIndex = dgStock.SelectedRows(0).Index - 1
        Try
            If rowIndex <= dgStock.Rows.Count - 1 Then
                Dim prevRow As DataGridViewRow = dgStock.Rows(rowIndex)
                dgStock.CurrentCell = prevRow.Cells(0)
                dgStock.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim rowIndex As Integer

        rowIndex = dgStock.Rows.Count - 1
        Dim lastRow As DataGridViewRow = dgStock.Rows(rowIndex)
        dgStock.CurrentCell = lastRow.Cells(0)
        dgStock.Rows(rowIndex).Selected = True
    End Sub
    Private Sub TbSearch_OnValueChanged(sender As Object, e As EventArgs) Handles tbSearch.OnValueChanged
        Try
            dbcon = "SELECT * FROM [tblstock] where [BarcodeID] LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgStock.Rows.Clear()
            Do While dr.Read = True
                dgStock.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        dbConnection()
        Dim dbcon1 As String = "SELECT COUNT(*) FROM tblstock where BarcodeID LIKE '" & Trim(tbSearch.Text) & "%'"
        Dim cmd1 As New OleDbCommand(dbcon1, conn)
        dr = cmd1.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub
    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Hide()
        tbSearch.Text = ""
        mainForm.Show()
    End Sub
    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Me.Hide()
        tbSearch.Text = ""
        stockDev.Show()
    End Sub
End Class