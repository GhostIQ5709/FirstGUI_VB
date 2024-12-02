Public Class frmFitness
    Dim intMemberNumber As Integer = 1
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstWeight.Items.Clear()
        lblAverageWeight.Text = ""
        intMemberNumber = 1
        btnEnterWeight.Focus()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuClear.PerformClick()
    End Sub

    Private Sub btnEnterWeight_Click(sender As Object, e As EventArgs) Handles btnEnterWeight.Click
        Dim strInputMessage As String = "Enter weight loss for #"
        Dim strInputHeading As String = "Enter Weight Loss"
        Dim strWeightLoss As String = InputBox(strInputMessage & intMemberNumber, strInputHeading, "")
        If (strWeightLoss.Equals("") Or Not IsNumeric(strWeightLoss)) Then
            MsgBox("Enter a numeric value or ensure input is not empty", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Illegal Operation")
        Else
            Dim decWeightLoss As Decimal = Convert.ToDecimal(strWeightLoss)
            lstWeight.Items.Add(decWeightLoss)
            Dim decSum As Decimal = 0
            Dim intCount As Integer = 0
            ' Calculating Average Weight Loss
            For Each item As Object In lstWeight.Items
                decSum += Convert.ToDecimal(item)
                intCount += 1
            Next
            intMemberNumber += 1

            Dim decAverage As Decimal = decSum / intCount

            lblAverageWeight.Text = "Average weight loss is " & decAverage.ToString("F2") & "lbs"
        End If
        btnEnterWeight.Focus()
    End Sub
End Class