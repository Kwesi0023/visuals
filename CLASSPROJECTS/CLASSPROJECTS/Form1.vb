Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtPrice.Clear()
        txtTradeIn.Clear()
        RadTouchUp.Checked = False
        radUndercoat.Checked = False
        radboth.Checked = False
        chkWholesale.Checked = False
        accessory1.Checked = False
        accessory2.Checked = False
        accessory3.Checked = False
        accessory4.Checked = False
        lblSubtotal.Text = String.Empty
        lbltax.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblextras.Text = String.Empty
        lbltotalDue.Text = String.Empty
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

        If RadTouchUp.Checked Then
            extras += 50D
        ElseIf radUndercoat.Checked Then
            extras += 100D
        ElseIf radboth.Checked Then
            extras += 150D
        End If

        If chkWholesale.Checked Then
            DiscountAmount = price * DISCOUNT_RATE
        Else
            DiscountAmount = 0
        End If

        If accessory1.Checked Then
            extras += 25D
        ElseIf accessory2.Checked Then
            extras += 25D
        ElseIf accessory3.Checked Then
            extras += 25D
        ElseIf accessory4.Checked Then
            extras += 25D

        End If

        subtotal = price - tradeIn - DiscountAmount + extras
        tax = subtotal * TAX_RATE
        totalDue = subtotal + tax

        lblSubT.Text = subtotal.ToString("C")
        lbltax.Text = tax.ToString("C")
        lblDiscount.Text = DiscountAmount.ToString("C")
        lblextras.Text = extras.ToString("C")
        lbltotalDue.Text = totalDue.ToString("C")
    End Sub


End Class
