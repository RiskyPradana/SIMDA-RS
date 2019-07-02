<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_golongan
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenjang = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.golongan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Image = Global.Tugas_UAS.My.Resources.Resources.Refresh
        Me.Button5.Location = New System.Drawing.Point(154, 91)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 41)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "RESET DATA ISIAN"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Berlin Sans FB Demi", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(490, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(244, 31)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "DATA GOLONGAN"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Location = New System.Drawing.Point(454, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(511, 298)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATA GOLONGAN"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 274)
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button2
        '
        Me.Button2.Image = Global.Tugas_UAS.My.Resources.Resources.edit
        Me.Button2.Location = New System.Drawing.Point(179, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "UBAH"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 139)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MENU"
        '
        'Button6
        '
        Me.Button6.Image = Global.Tugas_UAS.My.Resources.Resources.Delete
        Me.Button6.Location = New System.Drawing.Point(296, 28)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 41)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "HAPUS"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Tugas_UAS.My.Resources.Resources.Save
        Me.Button3.Location = New System.Drawing.Point(63, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 41)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SIMPAN"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Tugas_UAS.My.Resources.Resources.Prev
        Me.Button4.Location = New System.Drawing.Point(349, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 41)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "KEMBALI"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.jenjang)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.golongan)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 106)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA ISIAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jenjang Pangkat"
        '
        'jenjang
        '
        Me.jenjang.Location = New System.Drawing.Point(157, 60)
        Me.jenjang.Name = "jenjang"
        Me.jenjang.Size = New System.Drawing.Size(258, 20)
        Me.jenjang.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Image = Global.Tugas_UAS.My.Resources.Resources.Search2
        Me.Button7.Location = New System.Drawing.Point(335, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 44)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "CARI"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Golongan/Ruang"
        '
        'golongan
        '
        Me.golongan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.golongan.Location = New System.Drawing.Point(157, 24)
        Me.golongan.Name = "golongan"
        Me.golongan.Size = New System.Drawing.Size(176, 20)
        Me.golongan.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(-145, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 74)
        Me.Panel1.TabIndex = 58
        '
        'master_golongan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.Capture
        Me.ClientSize = New System.Drawing.Size(973, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "master_golongan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jenjang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents golongan As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Private WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
