Imports System.DirectoryServices

Public Class Form1
    Private Sub CHKLAPTOPBAGG_CheckedChanged(sender As Object, e As EventArgs) Handles CHKLAPTOPBAGG.CheckedChanged

    End Sub
    Private Sub LSTDISPLAY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSTDISPLAY.SelectedIndexChanged

    End Sub



    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim STRNAME, STRSURNAME As String
        Dim INTCONTACT As Integer
        Dim DECLAPTOP, LAPTOPDECPRICE, DECWIRELESSMOUSE, DECMECHANICALKEYBOARD, DECSTUDENTLAPTOP, DECLAPTOPBAG As Decimal
        Dim DECAMOUNTB4PROMO, DECPROMODISCOUNT, DECVAT, DECTOTAL As Decimal
        STRNAME = CStr(TXTNAME.Text)
        STRSURNAME = CStr(TXTSURNAME.Text)
        INTCONTACT = CInt(TXTCONTACT.Text)
        LSTDISPLAY.Items.Add("QUOTATION FOR:" & vbTab & TXTNAME.Text & vbTab & TXTSURNAME.Text)
        LSTDISPLAY.Items.Add("CUSTOMER CONTACT:" & vbTab & TXTCONTACT.Text)
        LSTDISPLAY.Items.Add("........................................................")
        If RADGAMINGLAPTOP.Checked Then
            LAPTOPDECPRICE = 10000
            LSTDISPLAY.Items.Add("LAPTOP NAME: GAMING LAPTOP" & vbTab & LAPTOPDECPRICE)
        End If
        If RADBUSINESSLAPTOP.Checked Then
            LAPTOPDECPRICE = 7000
            LSTDISPLAY.Items.Add("LAPTOP NAME: BUSINESS LAPTOP" & vbTab & LAPTOPDECPRICE)
        End If
        If RADSTUDENTLAPTOP.Checked Then
            LAPTOPDECPRICE = 4500
            LSTDISPLAY.Items.Add("LAPTOP NAME: STUDENT LAPTOP" & vbTab & LAPTOPDECPRICE)
        End If
        If CHKWIRELESSMOUSE.Checked = True Then
            DECWIRELESSMOUSE = 100
            LSTDISPLAY.Items.Add("WIRELESSMOUSE:" & vbTab & DECWIRELESSMOUSE)
        End If
        If CHKMECHANICALKEYBOARD.Checked = True Then
            DECMECHANICALKEYBOARD = 150
            LSTDISPLAY.Items.Add("MECHANICALKEYBOARD:" & vbTab & DECMECHANICALKEYBOARD)
        End If
        If CHKLAPTOPBAGG.Checked = True Then
            DECLAPTOPBAG = 250
            LSTDISPLAY.Items.Add("LAPTOPBAG:" & vbTab & DECLAPTOPBAG)
        End If
        DECAMOUNTB4PROMO = (LAPTOPDECPRICE + DECMECHANICALKEYBOARD + DECWIRELESSMOUSE + DECLAPTOPBAG)
        DECPROMODISCOUNT = (DECAMOUNTB4PROMO) -
        TXTPROMODISCOUNT.Text = DECPROMODISCOUNT.ToString()





        DECVAT = (DECAMOUNTB4PROMO) * (0.15)
        DECTOTAL = (DECPROMODISCOUNT) + (DECVAT)
        TXTAMOUNTB4PROMO.Text = DECAMOUNTB4PROMO.ToString("C")
        TXTPROMODISCOUNT.Text = DECLAPTOP.ToString("C")
        TXTVAT.Text = DECVAT.ToString("C")
        TXTTOTAL.Text = DECTOTAL.ToString("C")
    End Sub


End Class
