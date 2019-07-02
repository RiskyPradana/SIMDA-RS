Public Class master_golongan
    Dim conn As Odbc.OdbcConnection
    Dim strconn As String
    Private Sub kosongkan_text()
        Me.golongan.Text = ""
        Me.jenjang.Text = ""
        Me.golongan.Focus()
    End Sub

    Private Sub master_golongan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim StrItem(1) As String
        Dim item As ListViewItem
        Dim Rs As New DataSet
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        Dim reader As Odbc.OdbcDataReader
        ListView1.Columns.Add("Golongan", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Jenjang Pangkat", 400, HorizontalAlignment.Left)
        strsql = "select * from master_golongan"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader = command.ExecuteReader()
        While reader.Read
            StrItem(0) = reader.Item("golongan")
            StrItem(1) = reader.Item("jenjang")
            item = New ListViewItem(StrItem)
            ListView1.Items.Add(item)
        End While
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim reader1 As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from master_golongan where golongan='" + Me.golongan.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader1 = command.ExecuteReader()
        If reader1.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            command = New Odbc.OdbcCommand(strsql, conn)
            reader1 = command.ExecuteReader()
            While reader1.Read
                Me.jenjang.Text = reader1.Item("jenjang")
            End While
            Me.golongan.Focus()
        Else
            MessageBox.Show("Data Belum Ada")
            Call kosongkan_text()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim reader1 As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from master_golongan where golongan='" + Me.golongan.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader1 = command.ExecuteReader()
        If reader1.Read = True Then
            MessageBox.Show("Data Sudah Ada")
            Call kosongkan_text()
        ElseIf golongan.Text = "" Or jenjang.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
        Else
            Dim str_insert As String
            str_insert = "insert into master_golongan (golongan,jenjang) values ('" +
            Me.golongan.Text + "','" +
            Me.jenjang.Text + "')"
            command = New Odbc.OdbcCommand(str_insert, conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Disimpan")
            Call kosongkan_text()
            Call isi_tbl_view()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim reader1 As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from master_golongan where golongan='" + Me.golongan.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader1 = command.ExecuteReader()
        If reader1.Read = True Then
            Dim str_ubah As String
            str_ubah = "update master_golongan set jenjang ='" + Me.jenjang.Text +
            "' where golongan='" + Me.golongan.Text + "'"
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
        Dim reader1 As Odbc.OdbcDataReader
        Dim strsql As String
        Dim command As Odbc.OdbcCommand
        strsql = "select * from master_golongan where golongan='" + Me.golongan.Text + "'"
        command = New Odbc.OdbcCommand(strsql, conn)
        reader1 = command.ExecuteReader()
        If reader1.Read = True Then
            Dim str_hapus As String
            str_hapus = "delete from master_golongan where golongan='" +
            Me.golongan.Text + "'"
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
        Call kosongkan_text()
        Call isi_tbl_view()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
        Menu_Utama.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        With (ListView1.SelectedItems.Item(0))
            golongan.Text = .SubItems(0).Text
            jenjang.Text = .SubItems(1).Text
        End With
    End Sub
End Class