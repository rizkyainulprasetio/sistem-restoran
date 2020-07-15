Public Class SelamatDatang

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Selamat Datang di Restoran Madu Al - Zikrah")
        No_meja.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x = MsgBox("Apakah Anda Ingin Keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If x = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
