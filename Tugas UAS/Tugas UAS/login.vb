Public Class login
    Dim conn As Odbc.OdbcConnection
    Dim strconn As String
    Dim reader1 As Odbc.OdbcDataReader
    Dim command As Odbc.OdbcCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        strconn = "DRIVER=MYSQL ODBC 5.1 Driver; SERVER=localhost; DATABASE=simda_rs; UID=root"
        conn = New Odbc.OdbcConnection(strconn)
        conn.Open()
    End Sub

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Data Login Belum Lengkap")
            Exit Sub
        Else
            command = New Odbc.OdbcCommand("select * from data_login where username='" + Me.txtusername.Text + "' and password = md5('" + Me.txtpassword.Text + "')", conn)
            reader1 = command.ExecuteReader()
            reader1.Read()
            If reader1.HasRows Then
                Me.Visible = False
                Menu_Utama.Show()
                
                Else
                MsgBox("Username atau Password salah")
                End If
            End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub

    Private Sub login_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Menu_Utama.Enabled = True
    End Sub

    Private Sub login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub
End Class