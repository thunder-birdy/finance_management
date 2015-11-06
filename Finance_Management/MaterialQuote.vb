
Public Class material_quote
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MaterialQuoteEdit.ShowDialog()
    End Sub

    Private Sub btnCompanyManage_Click(sender As Object, e As EventArgs) Handles btnCompanyManage.Click
        CompanyManage.ShowDialog()
    End Sub
End Class
