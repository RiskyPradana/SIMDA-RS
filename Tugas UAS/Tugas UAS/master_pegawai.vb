Public Class master_pegawai
    Dim conn As Odbc.OdbcConnection
    Dim strconn As String
    Dim reader As Odbc.OdbcDataReader
    Dim strsql As String
    Dim command As Odbc.OdbcCommand
    Private Sub kosongkan_text()
        Me.nip.Text = ""
        Me.nama.Text = ""
        Me.tempat_lahir.Text = ""
        Me.tgl_lahir.Text = ""
        Me.jenis_kelamin.SelectedIndex = -1
        Me.agama.SelectedIndex = -1
        Me.status_nikah.SelectedIndex = -1
        Me.pendidikan.Text = ""
        Me.status_pegawai.SelectedIndex = -1
        Me.no_tlp.Text = ""
        Me.alamat.Text = ""
        Me.nip.Focus()
    End Sub

    Private Sub master_pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strconn = "DRIVER=MYSQL ODBC 5.1 Driver; SERVER=localhost; DATABASE=simda_rs; UID=root"
        conn = New Odbc.OdbcConnection(strconn)
        conn.Open()
        Call isi_tbl_view()
      
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
        ListView1.Columns.Add("NIP", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nama Pegawai", 118, HorizontalAlignment.Left)
        ListView1.Columns.Add("Tempat Lahir", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Tanggal Lahir", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Jenis Kelamin", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Agama", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Status Perkawinan", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Pendidikan", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Status Pegawai", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("No.Telepon", 112, HorizontalAlignment.Left)
        ListView1.Columns.Add("Alamat", 112, HorizontalAlignment.Left)
        strsql = "select * from master_pegawai"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        While reader.Read
            StrItem(0) = reader.Item("nip")
            StrItem(1) = reader.Item("nama")
            StrItem(2) = reader.Item("tempat_lahir")
            StrItem(3) = reader.Item("tgl_lahir")
            StrItem(4) = reader.Item("jenis_kelamin")
            StrItem(5) = reader.Item("agama")
            StrItem(6) = reader.Item("status_nikah")
            StrItem(7) = reader.Item("pendidikan")
            StrItem(8) = reader.Item("status_pegawai")
            StrItem(9) = reader.Item("no_tlp")
            StrItem(10) = reader.Item("alamat")
            item = New ListViewItem(StrItem)
            ListView1.Items.Add(item)
        End While
    End Sub

    Private Sub no_tlp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles no_tlp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strsql = "select * from master_pegawai where nip='" + Me.nip.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            command = New Odbc.OdbcCommand(strsql, conn)
            reader = command.ExecuteReader()
            While reader.Read
                Me.nip.Text = reader.Item("nip")
                Me.nama.Text = reader.Item("nama")
                Me.tempat_lahir.Text = reader.Item("tempat_lahir")
                Me.tgl_lahir.Text = reader.Item("tgl_lahir")
                Me.jenis_kelamin.SelectedItem = reader.Item("jenis_kelamin")
                Me.agama.SelectedItem = reader.Item("agama")
                Me.status_nikah.SelectedItem = reader.Item("status_nikah")
                Me.pendidikan.Text = reader.Item("pendidikan")
                Me.status_pegawai.SelectedItem = reader.Item("status_pegawai")
                Me.no_tlp.Text = reader.Item("no_tlp")
                Me.alamat.Text = reader.Item("alamat")
            End While
            Me.nip.Focus()
        Else
            MessageBox.Show("Data Belum Ada")
            Call kosongkan_text()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        strsql = "select * from master_pegawai where nip ='" + Me.nip.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            Call kosongkan_text()
        ElseIf nip.Text = "" Or nama.Text = "" Or tempat_lahir.Text = "" Or jenis_kelamin.Text = "" Or agama.Text = "" Or status_nikah.Text = "" Or pendidikan.Text = "" Or status_pegawai.Text = "" Or alamat.Text = "" Then
            MessageBox.Show("Lengkapi Semua Data")
        Else
            Dim str_insert As String
            str_insert = "insert into master_pegawai values ('" +
            Me.nip.Text + "','" +
            Me.nama.Text + "','" +
            Me.tempat_lahir.Text + "','" +
            Format(tgl_lahir.Value, "yyyy-MM-dd") + "','" +
            Me.jenis_kelamin.Text + "','" +
            Me.agama.Text + "','" +
            Me.status_nikah.Text + "','" +
            Me.pendidikan.Text + "','" +
            Me.status_pegawai.Text + "','" +
            Me.no_tlp.Text + "','" +
            Me.alamat.Text + "')"
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
        strsql = "select * from master_pegawai where nip='" + Me.nip.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            Dim str_ubah As String
            str_ubah = "update master_pegawai set nama ='" + Me.nama.Text +
            "',tempat_lahir='" + Me.tempat_lahir.Text +
            "',tgl_lahir='" + Format(tgl_lahir.Value, "yyyy-MM-dd") +
            "',jenis_kelamin='" + Me.jenis_kelamin.Text +
            "',agama='" + Me.agama.Text +
            "',status_nikah='" + Me.status_nikah.Text +
            "',pendidikan='" + Me.pendidikan.Text +
            "',status_pegawai='" + Me.status_pegawai.Text +
            "',no_tlp='" + Me.no_tlp.Text +
            "',alamat='" + Me.alamat.Text +
            "' where nip='" + Me.nip.Text + "'"
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
        strsql = "select * from master_pegawai where nip='" + Me.nip.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        If reader.Read = True Then
            Dim str_hapus As String
            str_hapus = "delete from master_pegawai where nip='" + Me.nip.Text + "'"
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

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        With ListView1.SelectedItems.Item(0)
            nip.Text = .SubItems(0).Text
            nama.Text = .SubItems(1).Text
            tempat_lahir.Text = .SubItems(2).Text
            tgl_lahir.Text = .SubItems(3).Text
            jenis_kelamin.Text = .SubItems(4).Text
            agama.Text = .SubItems(5).Text
            status_nikah.Text = .SubItems(6).Text
            pendidikan.Text = .SubItems(7).Text
            status_pegawai.Text = .SubItems(8).Text
            no_tlp.Text = .SubItems(9).Text
            alamat.Text = .SubItems(10).Text
        End With
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        Dim sql As String
        If Me.filter.SelectedItem = "NIP" Then
            sql = "select * from master_pegawai where nip like '%" + TxtCari.Text + "%'"
        End If
        If Me.filter.SelectedItem = "NAMA" Then
            sql = "select * from master_pegawai where nama like '%" + TxtCari.Text + "%'"
        End If
        If Me.filter.SelectedItem = "ALAMAT" Then
            sql = "select * from master_pegawai where alamat like '%" + TxtCari.Text + "%'"
        End If
        command = New Odbc.OdbcCommand(sql, conn)
        reader = command.ExecuteReader()
        If reader.HasRows Then
            ListView1.Items.Clear()
            While reader.Read
                Dim IsiGrid As ListViewItem = ListView1.Items.Add(reader("nip"))
                IsiGrid.SubItems.Add(reader("nama"))
                IsiGrid.SubItems.Add(reader("tempat_lahir"))
                IsiGrid.SubItems.Add(reader("tgl_lahir"))
                IsiGrid.SubItems.Add(reader("jenis_kelamin"))
                IsiGrid.SubItems.Add(reader("agama"))
                IsiGrid.SubItems.Add(reader("status_nikah"))
                IsiGrid.SubItems.Add(reader("pendidikan"))
                IsiGrid.SubItems.Add(reader("status_pegawai"))
                IsiGrid.SubItems.Add(reader("no_tlp"))
                IsiGrid.SubItems.Add(reader("alamat"))
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

    Private Sub nip_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nip.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

End Class