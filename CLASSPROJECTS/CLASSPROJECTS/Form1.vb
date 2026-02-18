Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Dim price As Decimal = 0
        Dim tradeIn As Decimal = 0
        Dim extras As Decimal = 0
        Dim subtotal As Decimal = 0
        Dim tax As Decimal = 0
        Dim totalDue As Decimal = 0
        Dim DiscountAmount As Decimal = 0
        Const DISCOUNT_RATE As Decimal = 0.01D
        Const TAX_RATE As Decimal = 0.08D

        Decimal.TryParse(txtPrice.Text, price)
        Decimal.TryParse(txtTradeIn.Text, tradeIn)

        If RadTouchUp.Cheked Then
            extras += 50D
        ElseIf radUndercoat.checked Then
            extras += 100D
        ElseIf radboth.checked Then
            extras += 150D
        End If

        If chkWholesale.Checked Then
            DiscountAmount = price * DISCOUNT_RATE
        Else
            DiscountAmount = 0
        End If

        If Accessory1.Checked Then
            extras += 25D
        End If

        subtotal = price - tradeIn - DiscountAmount + extras
        tax = subtotal * TAX_RATE
        totalDue = subtotal + tax

        lblSubtotal.Text = subtotal.ToString("C")
        lbltax.Text = tax.ToString("C")
        lblDiscount.Text = DiscountAmount.ToString("C")
        lblExtras.Text = extras.ToString("C")
        lblTotalDue.Text = totalDue.ToString("C")
    End Sub

End Class
