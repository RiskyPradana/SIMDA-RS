Public Class transaksi_pensiun_pegawai
    Dim conn As Odbc.OdbcConnection
    Dim strconn As String
    Dim reader As Odbc.OdbcDataReader
    Dim strsql As String
    Dim command As Odbc.OdbcCommand
    Private Sub kosongkan_text()
        Me.id.Text = ""
        Me.cmb_nip.SelectedIndex = -1
        Me.nama.Text = ""
        Me.golongan.Text = ""
        Me.jenjang.Text = ""
        Me.jabatan.Text = ""
        Me.tgl.Text = ""
        Me.no_sk.Text = ""
        Me.id.Focus()
    End Sub
    Private Sub transaksi_pensiun_pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strconn = "DRIVER=MYSQL ODBC 5.1 Driver; SERVER=localhost; DATABASE=simda_rs; UID=root"
        conn = New Odbc.OdbcConnection(strconn)
        conn.Open()
        Call isi_tbl_view()
        Call isi_cmb_nip()
    End Sub
    Private Sub isi_tbl_view()
        ListView1.Refresh()
        ListView1.FullRowSelect = True
        ListView1.View = View.Details
        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        Dim StrItem(10) As String
        Dim item As ListViewItem
        Dim Rs As New DataSet
        Dim reader As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        ListView1.Columns.Add("ID Pensiun", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("NIP", 118, HorizontalAlignment.Left)
        ListView1.Columns.Add("Tanggal Pensiun", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nomor SK", 112, HorizontalAlignment.Left)
        strsql = "select * from transaksi_pensiun"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        While reader.Read
            StrItem(0) = reader.Item("id_pensiun")
            StrItem(1) = reader.Item("nip")
            StrItem(2) = reader.Item("tgl_pensiun")
            StrItem(3) = reader.Item("no_sk")
            item = New ListViewItem(StrItem)
            ListView1.Items.Add(item)
        End While
    End Sub
    Private Sub isi_cmb_nip()
        Dim command_isi_cmb_nip As Odbc.OdbcCommand
        Dim strsql_isi_cmb_nip As String
        Dim reader_isi_cmb_nip As Odbc.OdbcDataReader

        strsql_isi_cmb_nip = "select nip from master_pegawai"
        command_isi_cmb_nip = New Odbc.OdbcCommand(strsql_isi_cmb_nip, conn)
        reader_isi_cmb_nip = command_isi_cmb_nip.ExecuteReader()
        If reader_isi_cmb_nip.HasRows = True Then
            cmb_nip.Items.Clear()
            While reader_isi_cmb_nip.Read
                cmb_nip.Items.Add(reader_isi_cmb_nip.GetString(0))
            End While
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reader As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from transaksi_pensiun where id_pensiun='" + Me.id.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            command = New Odbc.OdbcCommand(strsql, conn)
            reader = command.ExecuteReader()
            While reader.Read
                Me.cmb_nip.SelectedItem = reader.Item("nip")
                Me.tgl.Text = reader.Item("tgl_pensiun")
                Me.no_sk.Text = reader.Item("no_sk")
            End While
            Me.id.Focus()
        Else
            MessageBox.Show("Data Belum Ada")
            Call kosongkan_text()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim reader As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from transaksi_pensiun where id_pensiun ='" + Me.id.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            Call kosongkan_text()
        ElseIf id.Text = "" Or cmb_nip.Text = "" Or no_sk.Text = "" Then
            MessageBox.Show("Lengkapi Semua Data")
        Else
            Dim str_insert As String
            str_insert = "insert into transaksi_pensiun values ('" +
            Me.id.Text + "','" +
            Me.cmb_nip.Text + "','" +
            Format(tgl.Value, "yyyy-MM-dd") + "','" +
            Me.no_sk.Text + "')"
            command = New Odbc.OdbcCommand(str_insert, conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Disimpan")
            Call kosongkan_text()
            Call isi_tbl_view()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim reader As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from transaksi_pensiun where id_pensiun ='" + Me.id.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            Dim str_ubah As String
            str_ubah = "update transaksi_pensiun set nip ='" + Me.cmb_nip.Text +
            "',tgl_pensiun='" + Format(tgl.Value, "yyyy-MM-dd") +
            "',no_sk='" + Me.no_sk.Text +
            "' where id_pensiun='" + Me.id.Text + "'"
            command = New Odbc.OdbcCommand(str_ubah, conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah")
            Call kosongkan_text()
            Call isi_tbl_view()
        Else
            MessageBox.Show("Data Kosong. Tidak Ada Data Yang Diubah")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim reader As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from transaksi_pensiun where id_pensiun='" + Me.id.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            Dim str_hapus As String
            str_hapus = "delete from transaksi_pensiun where id_pensiun='" + Me.id.Text + "'"
            command = New Odbc.OdbcCommand(str_hapus, conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosongkan_text()
            Call isi_tbl_view()
        Else
            MessageBox.Show("Data Kosong. Tidak Ada Data Yang Dihapus")
            Call kosongkan_text()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        kosongkan_text()
        Call isi_tbl_view()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
        Menu_Utama.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_nip.SelectedIndexChanged
        Dim reader_SIC As Odbc.OdbcDataReader
        Dim strsql_SIC As String
        Dim command_SIC As Odbc.OdbcCommand
        strsql_SIC = "select * from master_pegawai where nip='" + Me.cmb_nip.Text + "'"
        command_SIC = New Odbc.OdbcCommand(strsql_SIC, conn)
        reader_SIC = command_SIC.ExecuteReader()
        While reader_SIC.Read
            Me.nama.Text = reader_SIC.Item("nama")
        End While
        Me.cmb_nip.Focus()
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        With ListView1.SelectedItems.Item(0)
            id.Text = .SubItems(0).Text
            cmb_nip.Text = .SubItems(1).Text
            tgl.Text = .SubItems(2).Text
            no_sk.Text = .SubItems(3).Text
        End With
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        Dim reader As Odbc.OdbcDataReader
        Dim command As Odbc.OdbcCommand
        Dim cari As String
        If Me.filter.SelectedItem = "NIP" Then
            cari = "select * from transaksi_pensiun where nip like '%" + TxtCari.Text + "%'"
        End If
        If Me.filter.SelectedItem = "TANGGAL PENSIUN" Then
            cari = "select * from transaksi_pensiun where tgl_pensiun like '%" + TxtCari.Text + "%'"
        End If
        command = New Odbc.OdbcCommand(cari, conn)
        reader = command.ExecuteReader()
        If reader.HasRows Then
            ListView1.Items.Clear()
            While reader.Read
                Dim IsiGrid As ListViewItem = ListView1.Items.Add(reader("id_pensiun"))
                IsiGrid.SubItems.Add(reader("nip"))
                IsiGrid.SubItems.Add(reader("tgl_pensiun"))
                IsiGrid.SubItems.Add(reader("no_sk"))
            End While
        Else : ListView1.Items.Clear()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.TxtCari.Text = ""
        filter.SelectedIndex = -1
        Me.TxtCari.Enabled = False
    End Sub

    Private Sub filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.SelectedIndexChanged
        Me.TxtCari.Enabled = True
        Me.TxtCari.Text = ""
    End Sub

    Private Sub tempat_lahir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nama.TextChanged
        Dim reader_SIC As Odbc.OdbcDataReader
        Dim strsql_SIC As String
        Dim command_SIC As Odbc.OdbcCommand
        strsql_SIC = "select * from transaksi_pangkat where nip='" + Me.cmb_nip.Text + "'"
        command_SIC = New Odbc.OdbcCommand(strsql_SIC, conn)
        reader_SIC = command_SIC.ExecuteReader()
        While reader_SIC.Read
            Me.golongan.Text = reader_SIC.Item("golongan")
            Me.jabatan.Text = reader_SIC.Item("jabatan")
        End While
    End Sub

    Private Sub golongan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golongan.TextChanged
        Dim reader_SIC As Odbc.OdbcDataReader
        Dim strsql_SIC As String
        Dim command_SIC As Odbc.OdbcCommand
        strsql_SIC = "select * from master_golongan where golongan='" + Me.golongan.Text + "'"
        command_SIC = New Odbc.OdbcCommand(strsql_SIC, conn)
        reader_SIC = command_SIC.ExecuteReader()
        While reader_SIC.Read
            Me.jenjang.Text = reader_SIC.Item("jenjang")
        End While
    End Sub

    Private Sub jenjang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jenjang.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class