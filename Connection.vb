Imports System.Data.OleDb
Module Connection
    Public dt As DataTable
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dbcon As String

    Sub dbConnection()
        conn = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dbase.mdb;jet OLEDB:Database Password=Jonathanabiva26;")
        conn.Open()
    End Sub
    Function getDataTable(ByVal SQL As String) As DataTable
        dbConnection()
        Dim cmd As New OleDbCommand(SQL, conn)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Module
