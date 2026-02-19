Public Class Form1

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim response As DialogResult
        response = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private totalPiecesAll As Integer = 0
    Private totalPayAll As Decimal = 0
    Private personCount As Integer = 0

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If txtName.Text = "" Or Not IsNumeric(txtPieces.Text) Then
            MessageBox.Show("Please enter a valid name and number of pieces.")
            Return
        End If

        Dim pieces As Integer = CInt(txtPieces.Text)
        Dim rate As Decimal

        If pieces <= 200 Then
            rate = 0.6D
        ElseIf pieces <= 400 Then
            rate = 0.65D
        ElseIf pieces <= 600 Then
            rate = 0.7D
        Else
            rate = 0.75D
        End If

        Dim amountEarned As Decimal = pieces * rate
        lblResult.Text = amountEarned.ToString("C")

        totalPiecesAll += pieces
        totalPayAll += amountEarned
        personCount += 1

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtName.Clear()
        txtPieces.Clear()
        lblResult.Text = ""

        txtName.Focus()
    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click
        If personCount > 0 Then
            Dim averagePay As Decimal = totalPayAll / personCount
            Dim message As String = "Total Pieces: " & totalPiecesAll.ToString() & vbCrLf &
                                    "Total Pay: " & totalPayAll.ToString("C") & vbCrLf &
                                    "Average Pay per Person: " & averagePay.ToString("C")


            MessageBox.Show(message, "Summary Totals", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No data has been calculated yet.", "Summary Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    ' vbCrLf-- moves to a newline like "std::cin>>"'
End Class
