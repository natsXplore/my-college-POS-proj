Imports System.Data.OleDb
Public Class reportForm
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTime.Enabled = True
        dgReport.ReadOnly = True
        dgReport.AllowUserToAddRows = False
        tbCount.Enabled = False
        countRecords()
        reportRecords()
    End Sub
    Sub reportRecords()
        Try
            dbcon = "SELECT  * FROM tblreport "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dgReport.Rows.Clear()
            Do While dr.Read = True
                dgReport.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub countRecords()
        dbConnection()
        Dim dbcon As String = "select COUNT (*) FROM tblreport "
        Dim cmd As New OleDbCommand(dbcon, conn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim rowIndex = dgReport.SelectedRows(0).Index = 0
        Try
            If rowIndex <= dgReport.Rows.Count - 1 Then
                Dim firstRow As DataGridViewRow = dgReport.Rows(rowIndex)
                dgReport.CurrentCell = firstRow.Cells(0)
                dgReport.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rowIndex = dgReport.SelectedRows(0).Index + 1
        If rowIndex <= dgReport.Rows.Count - 1 Then

            Dim nextRow As DataGridViewRow = dgReport.Rows(rowIndex)
            dgReport.CurrentCell = nextRow.Cells(0)
            dgReport.Rows(rowIndex).Selected = True
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim rowIndex = dgReport.SelectedRows(0).Index - 1
        Try
            If rowIndex <= dgReport.Rows.Count - 1 Then
                Dim prevRow As DataGridViewRow = dgReport.Rows(rowIndex)
                dgReport.CurrentCell = prevRow.Cells(0)
                dgReport.Rows(rowIndex).Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim rowIndex As Integer

        rowIndex = dgReport.Rows.Count - 1
        Dim lastRow As DataGridViewRow = dgReport.Rows(rowIndex)
        dgReport.CurrentCell = lastRow.Cells(0)
        dgReport.Rows(rowIndex).Selected = True
    End Sub

    Private Sub TbSearch_OnValueChanged(sender As Object, e As EventArgs) Handles tbSearch.OnValueChanged
        Try
            dbcon = "SELECT * FROM tblreport where TransactionID LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgReport.Rows.Clear()
            Do While dr.Read = True
                dgReport.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        dbConnection()
        Dim dbcon1 As String = "SELECT COUNT(*) FROM tblreport where TransactionID LIKE '" & Trim(tbSearch.Text) & "%'"
        Dim cmd1 As New OleDbCommand(dbcon1, conn)
        dr = cmd1.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        tbSearch.Text = ""
        mainForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        tbSearch.Text = ""
        reportDev.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        tbSearch.Text = ""
        reportRecords()
        countRecords()
    End Sub
End Class