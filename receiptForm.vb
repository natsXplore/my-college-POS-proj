Public Class receiptForm
    Private Sub resize()
        dgReceipt.Height = dgReceipt.ColumnHeadersHeight + dgReceipt.Rows.Cast(Of DataGridViewRow).Sum(Function(r) (r.Height))
        Panel2.Height = dgReceipt.Height + 430

        dgReceipt.ClearSelection()
    End Sub
    Private Sub DgReceipt_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgReceipt.RowsAdded
        resize()
    End Sub
    Private Sub DgReceipt_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgReceipt.RowsRemoved
        resize()
    End Sub
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgReceipt.Columns(0).Width = 10
        dgReceipt.Columns(1).Width = 3
        dgReceipt.Columns(2).Width = 3
        dgReceipt.Columns(3).Width = 50

        dgReceipt.ReadOnly = True
        lblDate.Text = Format(Date.Now, "Short Date")
        lblTime.Text = Format(Date.Now, "Long Time")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        cashierForm.bindStock()
        cashierForm.btnPay.Enabled = False
        cashierForm.btnAddtoCart.Enabled = True
        cashierForm.btnReceipt.Enabled = False
        dgReceipt.ClearSelection()


        cashierForm.Show()
    End Sub
End Class