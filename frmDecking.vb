Public Class frmDecking
    Const decCompositeRate As Decimal = 8.5
    Const decRedwoodRate As Decimal = 7.75
    Const decPTLumberRate As Decimal = 2.35

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click

        If (IsNumeric(txtFootage.Text) And txtFootage.Text.Length > 0) Then
            Dim dblFootage As Double = Convert.ToDouble(txtFootage.Text)
            If (dblFootage > 0) Then
                Dim dblCost As Double
                If (rbPTLumber.Checked) Then
                    dblCost = decPTLumberRate * dblFootage
                ElseIf (rbRedwood.Checked) Then
                    dblCost = decRedwoodRate * dblFootage
                Else
                    dblCost = decCompositeRate * dblFootage
                End If
                lblCost.Text = dblCost.ToString("C2")
            Else
                MsgBox("Enter a positive number.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Illegal Operation")
            End If

        Else
            MsgBox("Enter numeric data.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Illegal Operation")
        End If

        txtFootage.Clear()
        txtFootage.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCost.Text = ""
        txtFootage.Clear()
        rbComposite.Checked = False
        rbRedwood.Checked = False
        rbPTLumber.Checked = True
        txtFootage.Focus()
    End Sub

    Private Sub frmDecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
        txtFootage.Clear()
        rbComposite.Checked = False
        rbRedwood.Checked = False
        rbPTLumber.Checked = True
        txtFootage.Focus()
    End Sub
End Class