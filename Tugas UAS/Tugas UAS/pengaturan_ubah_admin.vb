Public Class pengaturan_ubah_admin
    Dim conn As Odbc.OdbcConnection
    Dim strconn As String

    Private Sub pengaturan_ubah_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strconn = "DRIVER=MYSQL ODBC 5.1 Driver; SERVER=localhost; DATABASE=simda_rs; UID=root"
        conn = New Odbc.OdbcConnection(strconn)
        conn.Open()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_sandi.Text = "" Then
            MsgBox("Masukan Password Dulu")
        ElseIf txt_nama.Text = "" Then
            Dim command As Odbc.OdbcCommand
            Dim str_ubah As String
            str_ubah = "update data_login set password= md5('" + Me.txt_sandi.Text + "')"
            command = New Odbc.OdbcCommand(str_ubah, conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Password Berhasil Diubah")
        Else
            Dim command As Odbc.OdbcCommand
            Dim str_ubah As String
            str_ubah = "update data_login set username ='" + Me.txt_nama.Text +
            "', password= md5('" + Me.txt_sandi.Text + "')"
            Command = New Odbc.OdbcCommand(str_ubah, conn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Username Dan Password Berhasil Diubah")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Menu_Utama.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim command As Odbc.OdbcCommand
        Dim str_ubah As String
        str_ubah = "update data_login set username = 'admin' , password= md5('admin')"
        command = New Odbc.OdbcCommand(str_ubah, conn)
        command.ExecuteNonQuery()
        MessageBox.Show("Username Dan Password Direset ke Default")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class