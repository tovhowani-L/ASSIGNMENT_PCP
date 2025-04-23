Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Text
Imports System.Security.AccessControl

Public Class Form1
    'Class-level variables
    Private LaptopDecPrice, decSubtotal, decDiscountOffer, decVAT, dectotal As Decimal
    Dim CalculateSubTotal As Decimal
    Dim StrName, StrSurname As String
    Dim IntContact As Integer
    Dim decLaptop, decWirelessMouse, decMechanicalKeyboard, decLaptopBag As Decimal

    'Event handler for "show Promotional Offer" button
    Private Sub BtnShowDiscountOffer_Click(sender As Object, e As EventArgs) Handles BtnShowDiscountOffer.Click
        StrName = CStr(TxtName.Text)
        StrSurname = CStr(TxtSurname.Text)
        IntContact = CInt(TxtContact.Text)
        LstDisplay.Items.Add("QUOTATION FOR:" & vbTab & TxtName.Text & vbTab & TxtSurname.Text)
        LstDisplay.Items.Add("CUSTOMER CONTACT:" & vbTab & TxtContact.Text)
        LstDisplay.Items.Add("........................................................")
    End Sub

    ' Event handler for "Clear All" button
    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        ' Reset All controls to default state
        RadBusinessLaptop.Checked = False
        RadGamingLaptop.Checked = False
        RadStudentLaptop.Checked = False
        ChkwirelessMouse.Checked = False
        ChkMechanicalKeyboard.Checked = False
        ChkLaptopBag.Checked = False
        TxtSubTotal.Text = "0.00"
        TxtDiscount.Text = "0.00"
        TxtVAT.Text = "0.00"
        TxtTotal.Text = "0.00"
        LstDisplay.Items.Clear()

    End Sub

    ' Close the application
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        ' Item Prices for GroupA
        If RadStudentLaptop.Checked Then
            LaptopDecPrice = 5000
            LstDisplay.Items.Add("Laptop Name: Student Laptop" & vbTab & LaptopDecPrice)
        End If
        If RadBusinessLaptop.Checked Then
            LaptopDecPrice = 7000
            LstDisplay.Items.Add("Laptop Name: Business Laptop" & vbTab & LaptopDecPrice)
        End If
        If RadGamingLaptop.Checked Then
            LaptopDecPrice = 9000
            LstDisplay.Items.Add("Laptop Name: Gaming Laptop" & vbTab & LaptopDecPrice)
        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

        ' Item Prices for GroupB
        If ChkwirelessMouse.Checked = True Then
            decWirelessMouse = 100
            LstDisplay.Items.Add("WirelessMouse:" & vbTab & decWirelessMouse)
        End If
        If ChkMechanicalKeyboard.Checked = True Then
            decMechanicalKeyboard = 150
            LstDisplay.Items.Add("MechanicalKeyboard:" & vbTab & decMechanicalKeyboard)
        End If
        If ChkLaptopBag.Checked = True Then
            decLaptopBag = 250
            LstDisplay.Items.Add("LaptopBag:" & vbTab & decLaptopBag)
        End If

        ' Validate if a Group A item is selected
        If RadGamingLaptop.Checked = False And RadBusinessLaptop.Checked = False And RadStudentLaptop.Checked = False Then
            MessageBox.Show("please select a laptop first!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ' enable GroupB checkboxes
        ChkwirelessMouse.Enabled = True
        ChkMechanicalKeyboard.Enabled = True
        ChkLaptopBag.Enabled = True


    End Sub



    Private Sub TxtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtSubTotal.TextChanged
        ' Calculate SubTotal
        decSubtotal = (LaptopDecPrice + decMechanicalKeyboard + decWirelessMouse + decLaptopBag)
        TxtSubTotal.Text = decSubtotal.ToString("C")

    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged

        ' Calculate Discount
        decDiscountOffer = decSubtotal - decLaptopBag
        TxtDiscount.Text = decDiscountOffer.ToString("C")


    End Sub

    Private Sub TxtVAT_TextChanged(sender As Object, e As EventArgs) Handles TxtVAT.TextChanged

        'Caculate VAT (15% of subtotal after discount)
        decVAT = (decDiscountOffer) * 0.15
        TxtVAT.Text = decVAT.ToString("C")

    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged
        'Calculate Total amount
        dectotal = decDiscountOffer + decVAT
        TxtTotal.Text = dectotal.ToString("C")

    End Sub

    Private Sub LstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstDisplay.SelectedIndexChanged

    End Sub

    Private Sub LblSubTotal_Click(sender As Object, e As EventArgs) Handles LblSubTotal.Click
        ' Calculate SubTotal
        decSubtotal = (LaptopDecPrice + decMechanicalKeyboard + decWirelessMouse + decLaptopBag)
        TxtSubTotal.Text = decSubtotal.ToString("C")

    End Sub

    Private Sub LblDiscount_Click(sender As Object, e As EventArgs) Handles LblDiscount.Click
        ' Calculate Discount
        decDiscountOffer = decSubtotal - decLaptopBag
        TxtDiscount.Text = decDiscountOffer.ToString("C")

    End Sub

    Private Sub LblVAT_Click(sender As Object, e As EventArgs) Handles LblVAT.Click
        'Caculate VAT (15% of subtotal after discount)
        decVAT = (decDiscountOffer) * 0.15
        TxtVAT.Text = decVAT.ToString("C")

    End Sub

    Private Sub LblTotal_Click(sender As Object, e As EventArgs) Handles LblTotal.Click
        'Calculate Total amount
        dectotal = decDiscountOffer + decVAT
        TxtTotal.Text = dectotal.ToString("C")

    End Sub
End Class
