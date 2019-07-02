<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_pegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.status_pegawai = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.status_nikah = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.no_tlp = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pendidikan = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tempat_lahir = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nip = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.status_pegawai)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.status_nikah)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.agama)
        Me.GroupBox2.Controls.Add(Me.jenis_kelamin)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.alamat)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.no_tlp)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.pendidikan)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tempat_lahir)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tgl_lahir)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.nama)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nip)
        Me.GroupBox2.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1016, 253)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA ISIAN"
        '
        'status_pegawai
        '
        Me.status_pegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_pegawai.FormattingEnabled = True
        Me.status_pegawai.Items.AddRange(New Object() {"PNS", "Non-PNS"})
        Me.status_pegawai.Location = New System.Drawing.Point(806, 97)
        Me.status_pegawai.Name = "status_pegawai"
        Me.status_pegawai.Size = New System.Drawing.Size(148, 25)
        Me.status_pegawai.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(755, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 17)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(594, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Status Pegawai"
        '
        'Button1
        '
        Me.Button1.Image = Global.Tugas_UAS.My.Resources.Resources.Search2
        Me.Button1.Location = New System.Drawing.Point(383, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 44)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "CARI"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'status_nikah
        '
        Me.status_nikah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_nikah.FormattingEnabled = True
        Me.status_nikah.Items.AddRange(New Object() {"Kawin", "Belum Kawin"})
        Me.status_nikah.Location = New System.Drawing.Point(806, 33)
        Me.status_nikah.Name = "status_nikah"
        Me.status_nikah.Size = New System.Drawing.Size(148, 25)
        Me.status_nikah.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 17)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = ":"
        '
        'agama
        '
        Me.agama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"Islam", "Hindu", "Buddha", "Katolik", "Kristen Protestan", "Kong Hu Cu"})
        Me.agama.Location = New System.Drawing.Point(218, 215)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(180, 25)
        Me.agama.TabIndex = 77
        '
        'jenis_kelamin
        '
        Me.jenis_kelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jenis_kelamin.FormattingEnabled = True
        Me.jenis_kelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.jenis_kelamin.Location = New System.Drawing.Point(218, 175)
        Me.jenis_kelamin.Name = "jenis_kelamin"
        Me.jenis_kelamin.Size = New System.Drawing.Size(180, 25)
        Me.jenis_kelamin.TabIndex = 76
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(755, 162)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(12, 17)
        Me.Label22.TabIndex = 75
        Me.Label22.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(594, 159)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 17)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(806, 162)
        Me.alamat.Multiline = True
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(183, 22)
        Me.alamat.TabIndex = 73
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(755, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(12, 17)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(594, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 17)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "No. Telp"
        '
        'no_tlp
        '
        Me.no_tlp.Location = New System.Drawing.Point(806, 130)
        Me.no_tlp.Name = "no_tlp"
        Me.no_tlp.Size = New System.Drawing.Size(183, 24)
        Me.no_tlp.TabIndex = 70
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(755, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 17)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(594, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 17)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Pendidikan Terakhir"
        '
        'pendidikan
        '
        Me.pendidikan.Location = New System.Drawing.Point(806, 67)
        Me.pendidikan.Name = "pendidikan"
        Me.pendidikan.Size = New System.Drawing.Size(183, 24)
        Me.pendidikan.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(755, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 17)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(594, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 17)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Status Perkawinan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(167, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 17)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Agama"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 17)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Tempat Lahir"
        '
        'tempat_lahir
        '
        Me.tempat_lahir.Location = New System.Drawing.Point(218, 98)
        Me.tempat_lahir.Name = "tempat_lahir"
        Me.tempat_lahir.Size = New System.Drawing.Size(261, 24)
        Me.tempat_lahir.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Tgl Lahir"
        '
        'tgl_lahir
        '
        Me.tgl_lahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl_lahir.Location = New System.Drawing.Point(218, 132)
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.Size = New System.Drawing.Size(230, 24)
        Me.tgl_lahir.TabIndex = 56
        Me.tgl_lahir.Value = New Date(2016, 5, 14, 16, 25, 57, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nama"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(218, 67)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(261, 24)
        Me.nama.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nip"
        '
        'nip
        '
        Me.nip.Location = New System.Drawing.Point(218, 37)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(159, 24)
        Me.nip.TabIndex = 50
        Me.nip.Tag = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1034, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 253)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MENU"
        '
        'Button5
        '
        Me.Button5.Image = Global.Tugas_UAS.My.Resources.Resources.Refresh
        Me.Button5.Location = New System.Drawing.Point(8, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 41)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "RESET DATA ISIAN"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Tugas_UAS.My.Resources.Resources.edit
        Me.Button2.Location = New System.Drawing.Point(55, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 41)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "UBAH"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Tugas_UAS.My.Resources.Resources.Delete
        Me.Button6.Location = New System.Drawing.Point(55, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 42)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "HAPUS"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Tugas_UAS.My.Resources.Resources.Save
        Me.Button3.Location = New System.Drawing.Point(55, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 41)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "SIMPAN"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Filter Berdasarkan :"
        '
        'TxtCari
        '
        Me.TxtCari.Enabled = False
        Me.TxtCari.Location = New System.Drawing.Point(349, 23)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(260, 24)
        Me.TxtCari.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1206, 224)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'filter
        '
        Me.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"NIP", "NAMA", "ALAMAT"})
        Me.filter.Location = New System.Drawing.Point(157, 22)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(174, 25)
        Me.filter.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = Global.Tugas_UAS.My.Resources.Resources.Prev
        Me.Button4.Location = New System.Drawing.Point(1086, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 40)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "KELUAR"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Berlin Sans FB Demi", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(569, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(215, 31)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "DATA PEGAWAI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtCari)
        Me.GroupBox1.Controls.Add(Me.filter)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1228, 297)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PEGAWAI"
        '
        'Button7
        '
        Me.Button7.Image = Global.Tugas_UAS.My.Resources.Resources.Refresh
        Me.Button7.Location = New System.Drawing.Point(624, 14)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 41)
        Me.Button7.TabIndex = 56
        Me.Button7.Text = "REFRESH"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(-7, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 63)
        Me.Panel1.TabIndex = 57
        '
        'master_pegawai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.Capture
        Me.ClientSize = New System.Drawing.Size(1252, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "master_pegawai"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents status_nikah As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents agama As System.Windows.Forms.ComboBox
    Friend WithEvents jenis_kelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents no_tlp As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tempat_lahir As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents pendidikan As System.Windows.Forms.TextBox
    Friend WithEvents status_pegawai As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents filter As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents nip As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
