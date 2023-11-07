Imports System.Data.OleDb
Public Class mainForm
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTime.Enabled = True
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Hide()
            loginForm.tbPassword.isPassword = False
            loginForm.Show()
        Else
            Me.Focus()
        End If

    End Sub
    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        userForm.Show()
    End Sub
    Private Sub BtnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Me.Hide()
        cashierForm.Show()
    End Sub

    Private Sub BtnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Me.Hide()
        addStockForm.Show()
    End Sub
    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        reportForm.Show()
        reportForm.reportRecords()
    End Sub
    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Me.Hide()
        stockForm.Show()
    End Sub
End Class