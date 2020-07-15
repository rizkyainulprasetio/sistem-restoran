Public Class Murstrn_madu_al_zikrah

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psnhitung.Click
        Dim Hrg_spaghetti As Integer = 30000
        Dim Hrg_sandwich As Integer = 35000
        Dim Hrg_pancake As Integer = 45000
        Dim Hrg_hamburger As Integer = 50000
        Dim Hrg_ice_drink As Integer = 20000
        Dim Hrg_cklt_pns As Integer = 25000
        Dim Hrg_alpukat As Integer = 35000
        Dim Hrg_milk_shake As Integer = 40000
        Dim Jlh_spaghetti = TxtJlh_spaghetti.Text
        Dim Jlh_sandwich = TxtJlh_sandwich.Text
        Dim Jlh_pancake = TxtJlh_pancake.Text
        Dim Jlh_hamburger = TxtJlh_hamburger.Text
        Dim Jlh_ice_drink = TxtJlh_ice_drink.Text
        Dim Jlh_cklt_pns = TxtJlh_cklt_pns.Text
        Dim Jlh_alpukat = TxtJlh_alpukat.Text
        Dim Jlh_milk_shake = TxtJlh_milk_shake.Text
        Dim Totalhrg_spaghetti As Integer
        Dim Totalhrg_sandwich As Integer
        Dim Totalhrg_pancake As Integer
        Dim Totalhrg_hamburger As Integer
        Dim Totalhrg_ice_drink As Integer
        Dim Totalhrg_cklt_pns As Integer
        Dim Totalhrg_alpukat As Integer
        Dim Totalhrg_milk_shake As Integer
        Dim Total_byr As Integer

        If Chbx_spaghetti.Checked Then
            Totalhrg_spaghetti = Hrg_spaghetti * Jlh_spaghetti
        Else
            Totalhrg_spaghetti = 0
        End If
        If Chbx_sandwich.Checked Then
            Totalhrg_sandwich = Hrg_sandwich * Jlh_sandwich
        Else
            Totalhrg_sandwich = 0
        End If
        If Chbx_pancake.Checked Then
            Totalhrg_pancake = Hrg_pancake * Jlh_pancake
        Else
            Totalhrg_pancake = 0
        End If
        If Chbx_hamburger.Checked Then
            Totalhrg_hamburger = Hrg_hamburger * Jlh_hamburger
        Else
            Totalhrg_hamburger = 0
        End If
        If Chbx_ice_drink.Checked Then
            Totalhrg_ice_drink = Hrg_ice_drink * Jlh_ice_drink
        Else
            Totalhrg_ice_drink = 0
        End If
        If Chbx_cklt_pns.Checked Then
            Totalhrg_cklt_pns = Hrg_cklt_pns * Jlh_cklt_pns
        Else
            Totalhrg_cklt_pns = 0
        End If
        If Chbx_alpukat.Checked Then
            Totalhrg_alpukat = Hrg_alpukat * Jlh_alpukat
        Else
            Totalhrg_alpukat = 0
        End If
        If Chbx_milk_shake.Checked Then
            Totalhrg_milk_shake = Hrg_milk_shake * Jlh_milk_shake
        Else
            Totalhrg_milk_shake = 0
        End If
        Total_byr = Totalhrg_spaghetti + Totalhrg_sandwich + Totalhrg_pancake + Totalhrg_hamburger + Totalhrg_ice_drink + Totalhrg_cklt_pns + Totalhrg_alpukat + Totalhrg_milk_shake
        LblTotal_byr.Text = Total_byr
    End Sub

    Private Sub Btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_reset.Click
        Dim x = MsgBox("Apakah anda ingin reset menu makanan / minuman yang sudah di pilih?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If x = vbYes Then
            TxtJlh_spaghetti.Text = 0
            TxtJlh_sandwich.Text = 0
            TxtJlh_pancake.Text = 0
            TxtJlh_hamburger.Text = 0
            TxtJlh_ice_drink.Text = 0
            TxtJlh_cklt_pns.Text = 0
            TxtJlh_alpukat.Text = 0
            TxtJlh_milk_shake.Text = 0
            LblTotal_byr.Text = 0
        End If
    End Sub

    Private Sub Btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_keluar.Click
        Dim x = MsgBox("Apakah Anda Ingin Keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If x = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_mmbuat_pesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_mmbuat_pesanan.Click
        Crmmbuat_pesanan.Show()
    End Sub
End Class