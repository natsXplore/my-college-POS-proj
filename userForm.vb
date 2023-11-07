Imports System.Data.OleDb
Imports System.IO
Public Class userForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTime.Enabled = True
        countRecords()
        Records()
        dg.ReadOnly = True
        dg.AllowUserToAddRows = False
        tbCount.Enabled = False

        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = False
        print.Enabled = True
        cancel.Enabled = False
        about.Enabled = True
        Exitt.Enabled = True
    End Sub

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lblDate.Text = Date.Now.ToString("MMM dd,yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Sub picClear()
        Picture.Image = Nothing
        Picture.BackColor = Color.Empty
        Picture.Invalidate()
    End Sub
    Sub Clear()
        tbUsername.Text = ""
        tbPassword.Text = ""
        tbConfirmPassword.Text = ""
        tbPosition.Text = ""
        comboPrivilege.SelectedItem = Nothing
        picClear()
    End Sub
    Sub countRecords()
        dbConnection()
        Dim dbcon As String = "select COUNT (*) FROM tbluser "
        Dim cmd As New OleDbCommand(dbcon, conn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub
    Sub BindtoText()
        With dg
            tbEmployeeID.Text = .CurrentRow.Cells(0).Value
        End With
    End Sub
    Sub SetImg()
        Dim ms As New MemoryStream()
        Dim bmpImage As New Bitmap(Picture.Image)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim data As Byte() = ms.GetBuffer()
        Dim p As New OleDbParameter("@img", OleDbType.Binary)
        p.Value = data
        cmd.Parameters.Add(p)
    End Sub
    Private Sub EmployeeID()
        dbConnection()
        Dim oleDBDR As OleDbDataReader
        Dim oleDBCommand As New OleDbCommand
        Dim strEmployeeID As String
        With oleDBCommand
            .Connection = conn
            .CommandText = "SELECT * FROM tbluser ORDER BY EmployeeID DESC"
        End With
        oleDBDR = oleDBCommand.ExecuteReader

        If oleDBDR.Read Then
            strEmployeeID = Mid(oleDBDR(0), 5, Len(oleDBDR(0)))
            tbEmployeeID.Text = "JCA-" & Format(Val(strEmployeeID) + 1, "000")
        Else
            tbEmployeeID.Text = "JCA-001"
        End If
    End Sub
    Private Sub Records()
        Try
            dbcon = "SELECT  * FROM tbluser "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub EmployeeInfo()
        Try
            If tbUsername.Text = "" Or tbPassword.Text = "" Or tbConfirmPassword.Text = "" Or tbPosition.Text = "" Or comboPrivilege.Text = "" Then
                MessageBox.Show("Please complete all fields.", "Input details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbUsername.Focus()
            ElseIf tbPassword.Text = tbConfirmPassword.Text = 0 Then
                MessageBox.Show("Password didn't match", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbPassword.Text = ""
                tbConfirmPassword.Text = ""
                tbPassword.Focus()
                Exit Sub
            End If
            dbConnection()
            Dim cmd As New OleDbCommand("INSERT INTO tbluser VALUES(@EmployeeID,@Username,@Password,@Position,@Privilege,@userPhoto)", conn)
            cmd.Parameters.AddWithValue("@EmployeeID", tbEmployeeID.Text)
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text)
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
            cmd.Parameters.AddWithValue("@Position", tbPosition.Text)
            cmd.Parameters.AddWithValue("@Privilege", comboPrivilege.Text)
            Dim ms As New MemoryStream()
            Picture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@userPhoto", OleDbType.Binary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee registered successfully?", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            countRecords()
            tbPassword.isPassword = True
            tbConfirmPassword.isPassword = True
            Records()

            tbEmployeeID.Enabled = False
            tbUsername.Enabled = False
            tbPassword.Enabled = False
            tbConfirmPassword.Enabled = False
            tbPosition.Enabled = False
            comboPrivilege.Enabled = False

            addUser.Enabled = True
            edit.Enabled = True
            Update.Enabled = False
            Save.Enabled = False
            refresh.Enabled = True
            delete.Enabled = False
            print.Enabled = True
            cancel.Enabled = False
            about.Enabled = True
            Exitt.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Insert Employee picture", "Input picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub DeleteEmployeeData()
        Try
            dbcon = "DELETE * FROM tbluser WHERE EmployeeID like'" & Trim(tbEmployeeID.Text) & "'"
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
    Private Sub EmployeePhoto()
        Try
            dbConnection()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter(("select * from tbluser where EmployeeID ='" & Trim(tbEmployeeID.Text) & "'"), conn)

            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("userPhoto")) Then
                    arrImage = dt.Rows(0).Item("userPhoto")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Me.Picture.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles print.Click
        Try
            Dim fileExport As String = ("C:\Users\Jonathan\Desktop\dgView.xlsx")
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

            For i = 0 To dg.RowCount - 1
                For j = 0 To dg.ColumnCount - 1
                    For k As Integer = 1 To dg.Columns.Count
                        xlWorkSheet.Cells(1, k) = dg.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dg(j, i).Value.ToString()
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

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            If tbPassword.Text = tbConfirmPassword.Text = 0 Then
                tbPassword.Text = ""
                tbConfirmPassword.Text = ""
                MessageBox.Show("Password didn't match", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            dbcon = "UPDATE [tbluser] SET [Username] = '" & tbUsername.Text & "',[Password]='" & tbPassword.Text & "', [Position] = '" & tbPosition.Text & "',[Privilege] = '" & comboPrivilege.Text & "',[userPhoto] = @img WHERE [EmployeeID] = '" & tbEmployeeID.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            SetImg()
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                tbEmployeeID.Enabled = False
                tbUsername.Enabled = False
                tbPassword.Enabled = False
                tbConfirmPassword.Enabled = False
                tbPosition.Enabled = False
                comboPrivilege.Enabled = False

                addUser.Enabled = True
                edit.Enabled = True
                Update.Enabled = False
                Save.Enabled = False
                refresh.Enabled = True
                delete.Enabled = False
                print.Enabled = True
                cancel.Enabled = False
                about.Enabled = True
                Exitt.Enabled = True
                MessageBox.Show("Employee account successfully updated.", "Employee updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                countRecords()
                Records()
            Else
                MessageBox.Show("Failed to update employee.", "Failed to update", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub TbSearch_OnValueChanged(sender As Object, e As EventArgs) Handles tbSearch.OnValueChanged
        Try
            dbcon = "SELECT * FROM [tbluser] where [Username] LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        dbConnection()
        Dim dbcon1 As String = "SELECT COUNT(*) FROM tbluser where Username LIKE '" & Trim(tbSearch.Text) & "%'"
        Dim cmd1 As New OleDbCommand(dbcon1, conn)
        dr = cmd1.ExecuteReader()
        While (dr.Read())
            tbCount.Text = (dr(0).ToString())
        End While
    End Sub

    Private Sub BtnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Browse Employee image..."
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Picture.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub BtnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        picClear()
    End Sub

    Private Sub TbEmployeeID_OnValueChanged(sender As Object, e As EventArgs) Handles tbEmployeeID.OnValueChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tbluser where EmployeeID ='" & Trim(tbEmployeeID.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbUsername.Text = dt.Rows(0).Item(1) & ""
                tbPassword.Text = dt.Rows(0).Item(2) & ""
                tbConfirmPassword.Text = dt.Rows(0).Item(2) & ""
                tbPosition.Text = dt.Rows(0).Item(3) & ""
                comboPrivilege.Text = dt.Rows(0).Item(4) & ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        EmployeePhoto()
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim rowIndex = dg.SelectedRows(0).Index = 0
        Try
            If rowIndex <= dg.Rows.Count - 1 Then
                Dim firstRow As DataGridViewRow = dg.Rows(rowIndex)
                dg.CurrentCell = firstRow.Cells(0)
                dg.Rows(rowIndex).Selected = True
                'menuAddnew.Enabled = True
                'mEdit.Enabled = True
                'UpdateToolStripMenuItem.Enabled = False
                'mSave.Enabled = False
                'mReload.Enabled = True
                'mDelete.Enabled = False
                'mPrint.Enabled = True
                'mCancel.Enabled = False
                'mExit.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rowIndex = dg.SelectedRows(0).Index + 1
        If rowIndex <= dg.Rows.Count - 1 Then

            Dim nextRow As DataGridViewRow = dg.Rows(rowIndex)
            dg.CurrentCell = nextRow.Cells(0)
            dg.Rows(rowIndex).Selected = True
            'menuAddnew.Enabled = True
            'mEdit.Enabled = True
            'UpdateToolStripMenuItem.Enabled = False
            'mSave.Enabled = False
            'mReload.Enabled = True
            'mDelete.Enabled = False
            'mPrint.Enabled = True
            'mCancel.Enabled = False
            'mExit.Enabled = True
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim rowIndex = dg.SelectedRows(0).Index - 1
        Try
            If rowIndex <= dg.Rows.Count - 1 Then
                Dim prevRow As DataGridViewRow = dg.Rows(rowIndex)
                dg.CurrentCell = prevRow.Cells(0)
                dg.Rows(rowIndex).Selected = True
                'menuAddnew.Enabled = True
                'mEdit.Enabled = True
                'UpdateToolStripMenuItem.Enabled = False
                'mSave.Enabled = False
                'mReload.Enabled = True
                'mDelete.Enabled = False
                'mPrint.Enabled = True
                'mCancel.Enabled = False
                'mExit.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim rowIndex As Integer

        rowIndex = dg.Rows.Count - 1
        Dim lastRow As DataGridViewRow = dg.Rows(rowIndex)
        dg.CurrentCell = lastRow.Cells(0)
        dg.Rows(rowIndex).Selected = True
        'menuAddnew.Enabled = True
        'mEdit.Enabled = True
        'UpdateToolStripMenuItem.Enabled = False
        'mSave.Enabled = False
        'mReload.Enabled = True
        'mDelete.Enabled = False
        'mPrint.Enabled = True
        'mCancel.Enabled = False
        'mExit.Enabled = True
    End Sub

    Private Sub Dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        BindtoText()
        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = True
        print.Enabled = True
        cancel.Enabled = True
        about.Enabled = True
        Exitt.Enabled = True
    End Sub

    Private Sub Dg_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEnter
        BindtoText()
        tbPassword.isPassword = True
        tbConfirmPassword.isPassword = True
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        Records()
        Clear()
        tbEmployeeID.Text = ""
        EmployeeID()
        tbPassword.isPassword = False
        tbConfirmPassword.isPassword = False

        tbEmployeeID.Enabled = False
        tbUsername.Enabled = True
        tbPassword.Enabled = True
        tbConfirmPassword.Enabled = True
        tbPosition.Enabled = True
        comboPrivilege.Enabled = True

        addUser.Enabled = False
        edit.Enabled = False
        Update.Enabled = False
        Save.Enabled = True
        refresh.Enabled = False
        delete.Enabled = False
        print.Enabled = False
        cancel.Enabled = True
        about.Enabled = True
        Exitt.Enabled = True
        tbUsername.Focus()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs)
        EmployeeInfo()

    End Sub

    Private Sub TbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        tbPassword.isPassword = True
    End Sub

    Private Sub TbConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbConfirmPassword.KeyPress
        tbConfirmPassword.isPassword = True
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        tbEmployeeID.Enabled = False
        tbUsername.Enabled = True
        tbPassword.Enabled = True
        tbConfirmPassword.Enabled = True
        tbPosition.Enabled = True
        comboPrivilege.Enabled = True

        addUser.Enabled = False
        edit.Enabled = False
        Update.Enabled = True
        Save.Enabled = False
        refresh.Enabled = False
        delete.Enabled = False
        print.Enabled = False
        cancel.Enabled = True
        about.Enabled = True
        Exitt.Enabled = True
        tbPassword.isPassword = False
        tbConfirmPassword.isPassword = False
        tbUsername.Focus()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If MessageBox.Show("Are you sure want to delete this employee?", "Deleting Employee Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteEmployeeData()
            countRecords()
            Clear()
            tbEmployeeID.Text = ""

            tbEmployeeID.Enabled = False
            tbUsername.Enabled = False
            tbPassword.Enabled = False
            tbConfirmPassword.Enabled = False
            tbPosition.Enabled = False
            comboPrivilege.Enabled = False

            addUser.Enabled = True
            edit.Enabled = True
            Update.Enabled = False
            Save.Enabled = False
            refresh.Enabled = True
            delete.Enabled = False
            print.Enabled = True
            cancel.Enabled = False
            about.Enabled = True
            Exitt.Enabled = True
            Records()

        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        countRecords()
        Clear()
        tbEmployeeID.Text = ""
        tbSearch.Text = ""
        Records()

        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = False
        print.Enabled = True
        cancel.Enabled = False
        about.Enabled = True
        Exitt.Enabled = True
    End Sub

    Private Sub Save_Click_1(sender As Object, e As EventArgs) Handles Save.Click
        EmployeeInfo()
        EmployeeID()
    End Sub

    Private Sub Exitt_Click(sender As Object, e As EventArgs) Handles Exitt.Click
        Clear()
        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = False
        print.Enabled = True
        cancel.Enabled = False
        about.Enabled = True
        Exitt.Enabled = True
        Me.Hide()
        Records()
        mainForm.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Clear()
        countRecords()
        Records()

        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = False
        print.Enabled = True
        cancel.Enabled = False
        about.Enabled = True
        Exitt.Enabled = True

    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles about.Click
        countRecords()
        Records()

        tbEmployeeID.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbConfirmPassword.Enabled = False
        tbPosition.Enabled = False
        comboPrivilege.Enabled = False

        addUser.Enabled = True
        edit.Enabled = True
        Update.Enabled = False
        Save.Enabled = False
        refresh.Enabled = True
        delete.Enabled = False
        print.Enabled = True
        cancel.Enabled = False
        about.Enabled = True
        Exitt.Enabled = True
        Me.Hide()
        userDev.Show()
    End Sub
End Class