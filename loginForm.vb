Imports System.Data.OleDb
Public Class loginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPassword.isPassword = False
    End Sub
    Sub enterLogin()
        If tbUsername.Text = "" And tbPassword.Text = "" Then
            MessageBox.Show("Input username and password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Exit Sub
        ElseIf tbUsername.Text = "" Then
            MessageBox.Show("Input username", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Exit Sub
        ElseIf tbPassword.Text = "" Then
            MessageBox.Show("Input password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Exit Sub
        End If

        Dim Privilege As String
        Static errorCount As Integer = 1

        Using conn As New System.Data.OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dbase.mdb;jet OLEDB:Database Password=Jonathanabiva26;"),
                cmd As New OleDbCommand("SELECT [Privilege] FROM [tbluser] WHERE [Username]= @Username AND [Password] = @Password", conn)
            With cmd.Parameters
                .Add("@Username", OleDbType.VarChar, 100).Value = tbUsername.Text
                .Add("@Password", OleDbType.VarChar, 100).Value = tbPassword.Text
            End With
            conn.Open()
            Privilege = cmd.ExecuteScalar
        End Using
        If Privilege = "Admin" Then
            MessageBox.Show("Login as administrator", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbUsername.Text = ""
            tbPassword.Text = ""
            mainForm.Show()
            mainForm.btnUser.Enabled = True
            mainForm.btnAddStock.Enabled = True
            mainForm.btnStock.Enabled = True
            mainForm.btnCashier.Enabled = True
            mainForm.btnReport.Enabled = True

            Me.Hide()
            errorCount = 1
        ElseIf Privilege = "User" Then
            MessageBox.Show("Login as user account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbUsername.Text = ""
            tbPassword.Text = ""
            mainForm.Show()
            mainForm.btnUser.Enabled = False
            mainForm.btnAddStock.Enabled = False
            mainForm.btnStock.Enabled = True
            mainForm.btnCashier.Enabled = True
            mainForm.btnReport.Enabled = False
            Me.Hide()
            errorCount = 1
        ElseIf (errorCount = 3) Then
            MessageBox.Show("Too many login attempts", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            MessageBox.Show("You have 3 attempts to login, invalid Username or Password. Try again", "Login attempt (" & errorCount & ")", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            errorCount = errorCount + 1
            tbUsername.Text = ""
            tbPassword.Text = ""
            tbUsername.Focus()
        End If
        cashierForm.tbCashier.Text = Privilege
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        enterLogin()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        Else
            Me.Focus()
        End If
    End Sub
    Private Sub tbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        tbPassword.isPassword = True
    End Sub

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            enterLogin()
        End If
    End Sub
    Private Sub tbUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            enterLogin()
        End If
    End Sub
End Class