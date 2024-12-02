Public Class frmBikeRentals
    Private Sub btnFindCost_Click(sender As Object, e As EventArgs) Handles btnFindCost.Click

        Dim days As Integer = Convert.ToInt32(txtDays.Text)

        Dim total As Double = days * 9.95

        lblTotal.Text = total.ToString("C2")

        Dim message As String = "Bike Borrowed by: " & txtName.Text & vbCrLf & "Details:" & vbCrLf & mtxtContact.Text & vbCrLf & mtxtID.Text & vbCrLf & mtxtAddress.Text & vbCrLf & "Price: " & total.ToString("C2")

        MessageBox.Show(message, "Rental Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Clear()
        lblTotal.Text = ""
        txtDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
