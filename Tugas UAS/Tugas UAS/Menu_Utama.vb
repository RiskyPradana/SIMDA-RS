Public Class Menu_Utama
    Dim strconn As String
    Dim conn As Odbc.OdbcConnection
    Private Sub DataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        master_pegawai.Show()
        master_pegawai.MdiParent = Me
    End Sub

    Private Sub DataJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJabatanToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        master_jabatan.Show()
        master_jabatan.MdiParent = Me
    End Sub

    Private Sub PangkatPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PangkatPegawaiToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        transaksi_pangkat_pegawai.Show()
        transaksi_pangkat_pegawai.MdiParent = Me
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim keluar As MsgBoxResult
        keluar = MsgBox("Apakah Anda yakin ingin keluar dari aplikasi ?", MsgBoxStyle.YesNo, "Peringatan")
        If keluar = MsgBoxResult.Yes Then
            Close()
            login.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam.Text = FormatDateTime(Now(), DateFormat.LongTime)
        tanggal.Text = Format(Now(), "dddd dd-MM-yyyy")
    End Sub

    Private Sub Menu_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nama_komputer.Text = System.Net.Dns.GetHostName()
        jam.Text = FormatDateTime(Now(), DateFormat.LongTime)
        tanggal.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        strconn = "DRIVER=MYSQL ODBC 5.1 Driver; SERVER=localhost; DATABASE=simda_rs; UID=root"
        conn = New Odbc.OdbcConnection(strconn)
        conn.Open()
        Dim reader1 As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select username from data_login"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader1 = command.ExecuteReader()
        If reader1.Read = True Then
            command = New Odbc.OdbcCommand(strsql, conn)
            reader1 = command.ExecuteReader()
            While reader1.Read
                ToolStripStatusLabel4.Text = "Selamat Datang : " + reader1.Item("username")
            End While
        End If
    End Sub

    Private Sub Transaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transaksi.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND
    End Sub


    Private Sub UBAHUSERDANPASSWORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UBAHUSERDANPASSWORDToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        pengaturan_ubah_admin.Show()
        pengaturan_ubah_admin.MdiParent = Me
    End Sub

    Private Sub DataGolonganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGolonganToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        master_golongan.Show()
        master_golongan.MdiParent = Me
    End Sub

    Private Sub MutasiPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MutasiPegawaiToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        transaksi_mutasi_pegawai.Show()
        transaksi_mutasi_pegawai.MdiParent = Me
    End Sub

    Private Sub MutasiJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MutasiJabatanToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        transaksi_mutasi_jabatan.Show()
        transaksi_mutasi_jabatan.MdiParent = Me
    End Sub

    Private Sub PensiunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PensiunToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        transaksi_pensiun_pegawai.Show()
        transaksi_pensiun_pegawai.MdiParent = Me
    End Sub

    Private Sub LaporanDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataPegawaiToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        laporan_data_pegawai.Show()
        laporan_data_pegawai.MdiParent = Me
    End Sub

    Private Sub LaporanPangkatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPangkatToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        laporan_data_pangkat_pegawai.Show()
        laporan_data_pangkat_pegawai.MdiParent = Me
    End Sub

    Private Sub LaporanMutasiPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanMutasiPegawaiToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        laporan_data_mutasi_pegawai.Show()
        laporan_data_mutasi_pegawai.MdiParent = Me
    End Sub

    Private Sub LaporanMutasiJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanMutasiJabatanToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        laporan_data_mutasi_jabatan.Show()
        laporan_data_mutasi_jabatan.MdiParent = Me
    End Sub

    Private Sub LaporanDataPensiunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataPensiunToolStripMenuItem.Click
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND_BLUR
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        laporan_data_pensiun.Show()
        laporan_data_pensiun.MdiParent = Me
    End Sub

    Private Sub Menu_Utama_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub
End Class