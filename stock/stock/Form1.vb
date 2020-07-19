Imports System.Net.Mail
Public Class Form1
    Dim iTax As Decimal
    Dim iSubTotal As Decimal
    Dim iTotal As Decimal
    Dim itemcost(30) As Decimal
    Const mcTax_Rate = 15

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("conform if you want to exit", "point of sale ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Numbers_Only(sender As Object, e As KeyPressEventArgs) Handles txt3MIndia.KeyPress, txtTataSponge.KeyPress, txtHEG.KeyPress, txtTataSteel.KeyPress, txtTideWaterOil.KeyPress, txtStovecInd.KeyPress,
        txtBajaj.KeyPress, txtVST.KeyPress, txtTCS.KeyPress, txtLTInfotech.KeyPress, txtLumaxInds.KeyPress, txtBosch.KeyPress, txtMarutiSuzuki.KeyPress, txtRavalgonSugar.KeyPress, txtBharatRasayan.KeyPress, txtNationalPerox.KeyPress,
        txtHero.KeyPress, txtMRF.KeyPress, txtEicherMotors.KeyPress, txtNestle.KeyPress, txtPG.KeyPress, txtWABCOIndia.KeyPress, txtMerck.KeyPress, txtMailbox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txt3MIndia, txtTataSponge, txtHEG, txtTataSteel, txtTideWaterOil, txtStovecInd, txtBajaj, txtVST, txtTCS, txtLTInfotech, txtLumaxInds, txtBosch, txtMarutiSuzuki,
            txtRavalgonSugar, txtBharatRasayan, txtNationalPerox, txtHero, txtMRF, txtEicherMotors, txtNestle, txtPG, txtWABCOIndia, txtMerck, txtMailbox}

        Next
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        lblTax.Text = ""

        For Each rad In {chk3MIndia, chkTataSponge, chkHEG, chkTataSteel, chkTideWaterOil, chkStovecInd, chkBajaj, chkVST, chkTCS, chkLTInfotech, chkLumaxInds, chkBosch,
            chkMarutiSuzuki, chkRavalgonSugar, chkBharatRasayan, chkNationalPerox, chkHero, chkMRF, chkEicherMotors, chkNestle, chkPG, chkWABCOIndia, chkMerck}
            rad.Checked = False
            rad.Enabled = False
        Next
        For Each rtb In {rtbReceipt}
            rtb.Text = ""

        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each t In {txt3MIndia, txtTataSponge, txtHEG, txtTataSteel, txtTideWaterOil, txtStovecInd, txtBajaj, txtVST, txtTCS, txtLTInfotech, txtLumaxInds, txtBosch, txtMarutiSuzuki,
            txtRavalgonSugar, txtBharatRasayan, txtNationalPerox, txtHero, txtMRF, txtEicherMotors, txtNestle, txtPG, txtWABCOIndia, txtMerck}
            t.Enabled = False
        Next

        For Each rad In {chk3MIndia, chkTataSponge, chkHEG, chkTataSteel, chkTideWaterOil, chkStovecInd, chkBajaj, chkVST, chkTCS, chkLTInfotech, chkLumaxInds, chkBosch, chkMarutiSuzuki,
            chkRavalgonSugar, chkBharatRasayan, chkNationalPerox, chkHero, chkMRF, chkEicherMotors, chkNestle, chkPG, chkWABCOIndia, chkMerck}
            rad.Enabled = False
        Next
    End Sub

    Private Sub btnApple_Click(sender As Object, e As EventArgs) Handles btnRavalgonSugar.Click
        chkRavalgonSugar.Enabled = True
    End Sub

    Private Sub btnMeatBall_Click(sender As Object, e As EventArgs) Handles btnMRF.Click
        chkMRF.Enabled = True
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnHEG.Click
        chkHEG.Enabled = True
    End Sub

    Private Sub btnMeat_Click(sender As Object, e As EventArgs) Handles btnEicherMotors.Click
        chkEicherMotors.Enabled = True
    End Sub

    Private Sub btnBroccoli_Click(sender As Object, e As EventArgs) Handles btnBosch.Click
        chkBosch.Enabled = True
    End Sub

    Private Sub btnBacon_Click(sender As Object, e As EventArgs) Handles btnMerck.Click
        chkMerck.Enabled = True
    End Sub

    Private Sub btnTomatoes_Click(sender As Object, e As EventArgs) Handles btn3MIndia.Click
        chk3MIndia.Enabled = True
    End Sub

    Private Sub btnSmoked_Click(sender As Object, e As EventArgs) Handles btnNationalPerox.Click
        chkNationalPerox.Enabled = True
    End Sub

    Private Sub btnMushrooms_Click(sender As Object, e As EventArgs) Handles btnTideWaterOil.Click
        chkTideWaterOil.Enabled = True
    End Sub

    Private Sub btnSmokedFish_Click(sender As Object, e As EventArgs) Handles btnBharatRasayan.Click
        chkBharatRasayan.Enabled = True
    End Sub

    Private Sub btnBeansprouts_Click(sender As Object, e As EventArgs) Handles btnMarutiSuzuki.Click
        chkMarutiSuzuki.Enabled = True
    End Sub

    Private Sub btnFish_Click(sender As Object, e As EventArgs) Handles btnNestle.Click
        chkNestle.Enabled = True
    End Sub

    Private Sub btnLettus_Click(sender As Object, e As EventArgs) Handles btnStovecInd.Click
        chkStovecInd.Enabled = True
    End Sub

    Private Sub btnRice_Click(sender As Object, e As EventArgs) Handles btnHero.Click
        chkHero.Enabled = True
    End Sub

    Private Sub btnGrapes_Click(sender As Object, e As EventArgs) Handles btnBajaj.Click
        chkBajaj.Enabled = True
    End Sub

    Private Sub btnBeans_Click(sender As Object, e As EventArgs) Handles btnWABCOIndia.Click
        chkWABCOIndia.Enabled = True
    End Sub

    Private Sub btnCucumber_Click(sender As Object, e As EventArgs) Handles btnVST.Click
        chkVST.Enabled = True
    End Sub

    Private Sub btnCheese_Click(sender As Object, e As EventArgs) Handles btnPG.Click
        chkPG.Enabled = True
    End Sub

    Private Sub btnCarrots_Click(sender As Object, e As EventArgs) Handles btnLumaxInds.Click
        chkLumaxInds.Enabled = True
    End Sub

    Private Sub btnCelery_Click(sender As Object, e As EventArgs) Handles btnLTInfotech.Click
        chkLTInfotech.Enabled = True
    End Sub


    Private Sub btnOnions_Click(sender As Object, e As EventArgs) Handles btnTataSteel.Click
        chkTataSteel.Enabled = True
    End Sub


    Private Sub btnSpringOnions_Click(sender As Object, e As EventArgs) Handles btnTataSponge.Click
        chkTataSponge.Enabled = True
    End Sub

    Private Sub btnCoriander_Click(sender As Object, e As EventArgs) Handles btnTCS.Click
        chkTCS.Enabled = True
    End Sub

    Private Sub chkApple_CheckedChanged(sender As Object, e As EventArgs) Handles chkRavalgonSugar.CheckedChanged
        If chkRavalgonSugar.Checked = True Then
            txtRavalgonSugar.Enabled = True
            txtRavalgonSugar.Text = ""
            txtRavalgonSugar.Focus()
        End If

        If chkRavalgonSugar.Checked = False Then
            txtRavalgonSugar.Enabled = False
            txtRavalgonSugar.Text = "0"

        End If
    End Sub

    Private Sub chkOrange_CheckedChanged(sender As Object, e As EventArgs) Handles chkHEG.CheckedChanged
        If chkHEG.Checked = True Then
            txtHEG.Enabled = True
            txtHEG.Text = ""
            txtHEG.Focus()
        End If

        If chkHEG.Checked = False Then
            txtHEG.Enabled = False
            txtHEG.Text = "0"

        End If
    End Sub

    Private Sub chkMeatBall_CheckedChanged(sender As Object, e As EventArgs) Handles chkMRF.CheckedChanged
        If chkMRF.Checked = True Then
            txtMRF.Enabled = True
            txtMRF.Text = ""
            txtMRF.Focus()
        End If

        If chkMRF.Checked = False Then
            txtMRF.Enabled = False
            txtMRF.Text = "0"

        End If
    End Sub

    Private Sub chkMeat_CheckedChanged(sender As Object, e As EventArgs) Handles chkEicherMotors.CheckedChanged
        If chkEicherMotors.Checked = True Then
            txtEicherMotors.Enabled = True
            txtEicherMotors.Text = ""
            txtEicherMotors.Focus()
        End If

        If chkEicherMotors.Checked = False Then
            txtEicherMotors.Enabled = False
            txtEicherMotors.Text = "0"

        End If
    End Sub

    Private Sub chkBroccoli_CheckedChanged(sender As Object, e As EventArgs) Handles chkBosch.CheckedChanged
        If chkBosch.Checked = True Then
            txtBosch.Enabled = True
            txtBosch.Text = ""
            txtBosch.Focus()
        End If

        If chkBosch.Checked = False Then
            txtBosch.Enabled = False
            txtBosch.Text = "0"

        End If
    End Sub

    Private Sub chkBacon_CheckedChanged(sender As Object, e As EventArgs) Handles chkMerck.CheckedChanged
        If chkMerck.Checked = True Then
            txtMerck.Enabled = True
            txtMerck.Text = ""
            txtMerck.Focus()
        End If

        If chkMerck.Checked = False Then
            txtMerck.Enabled = False
            txtMerck.Text = "0"

        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkPG.CheckedChanged
        If chkPG.Checked = True Then
            txtPG.Enabled = True
            txtPG.Text = ""
            txtPG.Focus()
        End If

        If chkPG.Checked = False Then
            txtPG.Enabled = False
            txtPG.Text = "0"

        End If
    End Sub

    Private Sub chkTomatoes_CheckedChanged(sender As Object, e As EventArgs) Handles chk3MIndia.CheckedChanged
        If chk3MIndia.Checked = True Then
            txt3MIndia.Enabled = True
            txt3MIndia.Text = ""
            txt3MIndia.Focus()
        End If

        If chk3MIndia.Checked = False Then
            txt3MIndia.Enabled = False
            txt3MIndia.Text = "0"

        End If
    End Sub

    Private Sub chkSmoked_CheckedChanged(sender As Object, e As EventArgs) Handles chkNationalPerox.CheckedChanged
        If chkNationalPerox.Checked = True Then
            txtNationalPerox.Enabled = True
            txtNationalPerox.Text = ""
            txtNationalPerox.Focus()
        End If

        If chkNationalPerox.Checked = False Then
            txtNationalPerox.Enabled = False
            txtNationalPerox.Text = "0"

        End If
    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As Object, e As EventArgs) Handles chkTideWaterOil.CheckedChanged
        If chkTideWaterOil.Checked = True Then
            txtTideWaterOil.Enabled = True
            txtTideWaterOil.Text = ""
            txtTideWaterOil.Focus()
        End If

        If chkTideWaterOil.Checked = False Then
            txtTideWaterOil.Enabled = False
            txtTideWaterOil.Text = "0"

        End If
    End Sub

    Private Sub chkSmokedFish_CheckedChanged(sender As Object, e As EventArgs) Handles chkBharatRasayan.CheckedChanged
        If chkBharatRasayan.Checked = True Then
            txtBharatRasayan.Enabled = True
            txtBharatRasayan.Text = ""
            txtBharatRasayan.Focus()
        End If

        If chkBharatRasayan.Checked = False Then
            txtBharatRasayan.Enabled = False
            txtBharatRasayan.Text = "0"

        End If
    End Sub

    Private Sub chkBeansprouts_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarutiSuzuki.CheckedChanged
        If chkMarutiSuzuki.Checked = True Then
            txtMarutiSuzuki.Enabled = True
            txtMarutiSuzuki.Text = ""
            txtMarutiSuzuki.Focus()
        End If

        If chkMarutiSuzuki.Checked = False Then
            txtMarutiSuzuki.Enabled = False
            txtMarutiSuzuki.Text = "0"

        End If
    End Sub

    Private Sub chkFish_CheckedChanged(sender As Object, e As EventArgs) Handles chkNestle.CheckedChanged
        If chkNestle.Checked = True Then
            txtNestle.Enabled = True
            txtNestle.Text = ""
            txtNestle.Focus()
        End If

        If chkNestle.Checked = False Then
            txtNestle.Enabled = False
            txtNestle.Text = "0"

        End If
    End Sub

    Private Sub chkLettus_CheckedChanged(sender As Object, e As EventArgs) Handles chkStovecInd.CheckedChanged
        If chkStovecInd.Checked = True Then
            txtStovecInd.Enabled = True
            txtStovecInd.Text = ""
            txtStovecInd.Focus()
        End If

        If chkStovecInd.Checked = False Then
            txtStovecInd.Enabled = False
            txtStovecInd.Text = "0"

        End If
    End Sub

    Private Sub chkRice_CheckedChanged(sender As Object, e As EventArgs) Handles chkHero.CheckedChanged
        If chkHero.Checked = True Then
            txtHero.Enabled = True
            txtHero.Text = ""
            txtHero.Focus()
        End If

        If chkHero.Checked = False Then
            txtHero.Enabled = False
            txtHero.Text = "0"

        End If
    End Sub

    Private Sub chkGrapes_CheckedChanged(sender As Object, e As EventArgs) Handles chkBajaj.CheckedChanged
        If chkBajaj.Checked = True Then
            txtBajaj.Enabled = True
            txtBajaj.Text = ""
            txtBajaj.Focus()
        End If

        If chkBajaj.Checked = False Then
            txtBajaj.Enabled = False
            txtBajaj.Text = "0"

        End If
    End Sub

    Private Sub chkBeans_CheckedChanged(sender As Object, e As EventArgs) Handles chkWABCOIndia.CheckedChanged
        If chkWABCOIndia.Checked = True Then
            txtWABCOIndia.Enabled = True
            txtWABCOIndia.Text = ""
            txtWABCOIndia.Focus()
        End If

        If chkWABCOIndia.Checked = False Then
            txtWABCOIndia.Enabled = False
            txtWABCOIndia.Text = "0"

        End If
    End Sub

    Private Sub chkCucumber_CheckedChanged(sender As Object, e As EventArgs) Handles chkVST.CheckedChanged
        If chkVST.Checked = True Then
            txtVST.Enabled = True
            txtVST.Text = ""
            txtVST.Focus()
        End If

        If chkVST.Checked = False Then
            txtVST.Enabled = False
            txtVST.Text = "0"

        End If
    End Sub

    Private Sub chkCarrots_CheckedChanged(sender As Object, e As EventArgs) Handles chkLumaxInds.CheckedChanged
        If chkLumaxInds.Checked = True Then
            txtLumaxInds.Enabled = True
            txtLumaxInds.Text = ""
            txtLumaxInds.Focus()
        End If

        If chkLumaxInds.Checked = False Then
            txtLumaxInds.Enabled = False
            txtLumaxInds.Text = "0"

        End If
    End Sub

    Private Sub chkCelery_CheckedChanged(sender As Object, e As EventArgs) Handles chkLTInfotech.CheckedChanged
        If chkLTInfotech.Checked = True Then
            txtLTInfotech.Enabled = True
            txtLTInfotech.Text = ""
            txtLTInfotech.Focus()
        End If

        If chkLTInfotech.Checked = False Then
            txtLTInfotech.Enabled = False
            txtLTInfotech.Text = "0"

        End If
    End Sub

    Private Sub chkOnions_CheckedChanged(sender As Object, e As EventArgs) Handles chkTataSteel.CheckedChanged
        If chkTataSteel.Checked = True Then
            txtTataSteel.Enabled = True
            txtTataSteel.Text = ""
            txtTataSteel.Focus()
        End If

        If chkTataSteel.Checked = False Then
            txtTataSteel.Enabled = False
            txtTataSteel.Text = "0"

        End If
    End Sub

    Private Sub chkSpringOnions_CheckedChanged(sender As Object, e As EventArgs) Handles chkTataSponge.CheckedChanged
        If chkTataSponge.Checked = True Then
            txtTataSponge.Enabled = True
            txtTataSponge.Text = ""
            txtTataSponge.Focus()
        End If

        If chkTataSponge.Checked = False Then
            txtTataSponge.Enabled = False
            txtTataSponge.Text = "0"

        End If
    End Sub
    Private Sub chkCoriander_CheckedChanged(sender As Object, e As EventArgs) Handles chkTCS.CheckedChanged
        If chkTCS.Checked = True Then
            txtTCS.Enabled = True
            txtTCS.Text = ""
            txtTCS.Focus()
        End If

        If chkTCS.Checked = False Then
            txtTCS.Enabled = False
            txtTCS.Text = "0"

        End If
    End Sub

    Private Sub Enter_zero(sender As Object, e As EventArgs) Handles GroupBox4.MouseHover, GroupBox3.MouseHover, GroupBox2.MouseHover, GroupBox1.MouseHover
        For Each txt In {txt3MIndia, txtTataSponge, txtHEG, txtTataSteel, txtTideWaterOil, txtStovecInd, txtBajaj, txtVST, txtTCS, txtLTInfotech, txtLumaxInds, txtBosch, txtMarutiSuzuki,
            txtRavalgonSugar, txtBharatRasayan, txtNationalPerox, txtHero, txtMRF, txtEicherMotors, txtNestle, txtPG, txtWABCOIndia, txtMerck}
            If txt.Text = "" Then
                txt.Text = "0"
                txt.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        itemcost(0) = Convert.ToDecimal(txtRavalgonSugar.Text) * 2772.05
        itemcost(1) = Convert.ToDecimal(txtHEG.Text) * 2121.05
        itemcost(2) = Convert.ToDecimal(txtMRF.Text) * 56009
        itemcost(3) = Convert.ToDecimal(txtEicherMotors.Text) * 20881.6
        itemcost(4) = Convert.ToDecimal(txtBosch.Text) * 17921.15
        itemcost(5) = Convert.ToDecimal(txtMerck.Text) * 3558.15
        itemcost(6) = Convert.ToDecimal(txt3MIndia.Text) * 23950.65
        itemcost(7) = Convert.ToDecimal(txtNationalPerox.Text) * 2758.85
        itemcost(8) = Convert.ToDecimal(txtMarutiSuzuki.Text) * 6585.7
        itemcost(9) = Convert.ToDecimal(txtNestle.Text) * 11027.9
        itemcost(10) = Convert.ToDecimal(txtStovecInd.Text) * 2379.9
        itemcost(11) = Convert.ToDecimal(txtHero.Text) * 2532.05
        itemcost(12) = Convert.ToDecimal(txtBajaj.Text) * 2941.15
        itemcost(13) = Convert.ToDecimal(txtWABCOIndia.Text) * 6345
        itemcost(14) = Convert.ToDecimal(txtVST.Text) * 3465
        itemcost(15) = Convert.ToDecimal(txtPG.Text) * 10610.1
        itemcost(16) = Convert.ToDecimal(txtLumaxInds.Text) * 6028.8
        itemcost(17) = Convert.ToDecimal(txtLTInfotech.Text) * 1683.85
        itemcost(18) = Convert.ToDecimal(txtTataSteel.Text) * 507
        itemcost(19) = Convert.ToDecimal(txtTataSponge.Text) * 753.65
        itemcost(20) = Convert.ToDecimal(txtTCS.Text) * 2000.45
        itemcost(21) = Convert.ToDecimal(txtBharatRasayan.Text) * 1100

        itemcost(22) = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) + itemcost(7)
        itemcost(23) = itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) + itemcost(14) + itemcost(15)
        itemcost(24) = itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21)

        itemcost(25) = itemcost(22) + itemcost(23) + itemcost(24)
        iTax = cFindTax(itemcost(25))

        lblSubTotal.Text = itemcost(25)

        lblTax.Text = FormatCurrency(iTax)
        lblSubTotal.Text = FormatCurrency(itemcost(25))
        lblTotal.Text = FormatCurrency(iTax + itemcost(25))

        rtbReceipt.AppendText(vbTab + vbTab + vbTab + "STOCKS")
        rtbReceipt.AppendText(" from 10:00 to 5:0)    STOCKS ")
        rtbReceipt.AppendText(" ds ")
        rtbReceipt.AppendText(" sd ")
        rtbReceipt.AppendText(vbTab + "Tax" + lblTax.Text + vbNewLine)
        rtbReceipt.AppendText(vbTab + "subtotal" + lblSubTotal.Text + vbNewLine)
        rtbReceipt.AppendText(vbTab + "total" + lblTotal.Text + vbNewLine)

    End Sub
    Private Function cFindTax(ByVal cAmount As Decimal) As Decimal
        cFindTax = cAmount - (cAmount * mcTax_Rate)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EmailMessage As New MailMessage()
        Try

        Catch ex As Exception
            EmailMessage.From = New MailAddress("siddhantmadmax@gmail.com")
            EmailMessage.To.Add(txtmailbox.Text)
            EmailMessage.Body = rtbReceipt.Rtf
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("siddhantmadmax@gmail.com", "sitcoe@123")
            SMTP.Send(EmailMessage)
            MsgBox("mail sent")
        End Try

    End Sub
End Class

