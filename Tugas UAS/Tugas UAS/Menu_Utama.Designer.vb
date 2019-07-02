<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGolonganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PangkatPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MutasiPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MutasiJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PensiunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPangkatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanMutasiPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanMutasiJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPensiunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGATURANADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UBAHUSERDANPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.jam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama_komputer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Transaksi, Me.MASTERDATAToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.PENGATURANADMINToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 76)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Transaksi"
        '
        'Transaksi
        '
        Me.Transaksi.Image = CType(resources.GetObject("Transaksi.Image"), System.Drawing.Image)
        Me.Transaksi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Transaksi.Name = "Transaksi"
        Me.Transaksi.Size = New System.Drawing.Size(93, 72)
        Me.Transaksi.Text = "BERANDA"
        Me.Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MASTERDATAToolStripMenuItem
        '
        Me.MASTERDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPegawaiToolStripMenuItem, Me.DataJabatanToolStripMenuItem, Me.DataGolonganToolStripMenuItem})
        Me.MASTERDATAToolStripMenuItem.Image = CType(resources.GetObject("MASTERDATAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MASTERDATAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MASTERDATAToolStripMenuItem.Name = "MASTERDATAToolStripMenuItem"
        Me.MASTERDATAToolStripMenuItem.Size = New System.Drawing.Size(121, 72)
        Me.MASTERDATAToolStripMenuItem.Text = "MASTER DATA"
        Me.MASTERDATAToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Pegawai"
        '
        'DataJabatanToolStripMenuItem
        '
        Me.DataJabatanToolStripMenuItem.Name = "DataJabatanToolStripMenuItem"
        Me.DataJabatanToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DataJabatanToolStripMenuItem.Text = "Data Jabatan"
        '
        'DataGolonganToolStripMenuItem
        '
        Me.DataGolonganToolStripMenuItem.Name = "DataGolonganToolStripMenuItem"
        Me.DataGolonganToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DataGolonganToolStripMenuItem.Text = "Data Golongan"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PangkatPegawaiToolStripMenuItem, Me.MutasiPegawaiToolStripMenuItem, Me.MutasiJabatanToolStripMenuItem, Me.PensiunToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Image = CType(resources.GetObject("TRANSAKSIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TRANSAKSIToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(98, 72)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        Me.TRANSAKSIToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PangkatPegawaiToolStripMenuItem
        '
        Me.PangkatPegawaiToolStripMenuItem.Name = "PangkatPegawaiToolStripMenuItem"
        Me.PangkatPegawaiToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PangkatPegawaiToolStripMenuItem.Text = "Pangkat Pegawai"
        '
        'MutasiPegawaiToolStripMenuItem
        '
        Me.MutasiPegawaiToolStripMenuItem.Name = "MutasiPegawaiToolStripMenuItem"
        Me.MutasiPegawaiToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MutasiPegawaiToolStripMenuItem.Text = "Mutasi Pegawai"
        '
        'MutasiJabatanToolStripMenuItem
        '
        Me.MutasiJabatanToolStripMenuItem.Name = "MutasiJabatanToolStripMenuItem"
        Me.MutasiJabatanToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MutasiJabatanToolStripMenuItem.Text = "Mutasi Jabatan"
        '
        'PensiunToolStripMenuItem
        '
        Me.PensiunToolStripMenuItem.Name = "PensiunToolStripMenuItem"
        Me.PensiunToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PensiunToolStripMenuItem.Text = "Pensiun"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataPegawaiToolStripMenuItem, Me.LaporanPangkatToolStripMenuItem, Me.LaporanMutasiPegawaiToolStripMenuItem, Me.LaporanMutasiJabatanToolStripMenuItem, Me.LaporanDataPensiunToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Image = CType(resources.GetObject("LAPORANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LAPORANToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(93, 72)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        Me.LAPORANToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LaporanDataPegawaiToolStripMenuItem
        '
        Me.LaporanDataPegawaiToolStripMenuItem.Name = "LaporanDataPegawaiToolStripMenuItem"
        Me.LaporanDataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.LaporanDataPegawaiToolStripMenuItem.Text = "Laporan Data Pegawai"
        '
        'LaporanPangkatToolStripMenuItem
        '
        Me.LaporanPangkatToolStripMenuItem.Name = "LaporanPangkatToolStripMenuItem"
        Me.LaporanPangkatToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.LaporanPangkatToolStripMenuItem.Text = "Laporan Data Pangkat Pegawai"
        '
        'LaporanMutasiPegawaiToolStripMenuItem
        '
        Me.LaporanMutasiPegawaiToolStripMenuItem.Name = "LaporanMutasiPegawaiToolStripMenuItem"
        Me.LaporanMutasiPegawaiToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.LaporanMutasiPegawaiToolStripMenuItem.Text = "Laporan Data Mutasi Pegawai"
        '
        'LaporanMutasiJabatanToolStripMenuItem
        '
        Me.LaporanMutasiJabatanToolStripMenuItem.Name = "LaporanMutasiJabatanToolStripMenuItem"
        Me.LaporanMutasiJabatanToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.LaporanMutasiJabatanToolStripMenuItem.Text = "Laporan Data Mutasi Jabatan"
        '
        'LaporanDataPensiunToolStripMenuItem
        '
        Me.LaporanDataPensiunToolStripMenuItem.Name = "LaporanDataPensiunToolStripMenuItem"
        Me.LaporanDataPensiunToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.LaporanDataPensiunToolStripMenuItem.Text = "Laporan Data Pensiun"
        '
        'PENGATURANADMINToolStripMenuItem
        '
        Me.PENGATURANADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UBAHUSERDANPASSWORDToolStripMenuItem})
        Me.PENGATURANADMINToolStripMenuItem.Image = CType(resources.GetObject("PENGATURANADMINToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PENGATURANADMINToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PENGATURANADMINToolStripMenuItem.Name = "PENGATURANADMINToolStripMenuItem"
        Me.PENGATURANADMINToolStripMenuItem.Size = New System.Drawing.Size(123, 72)
        Me.PENGATURANADMINToolStripMenuItem.Text = "PENGATURAN"
        Me.PENGATURANADMINToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UBAHUSERDANPASSWORDToolStripMenuItem
        '
        Me.UBAHUSERDANPASSWORDToolStripMenuItem.Name = "UBAHUSERDANPASSWORDToolStripMenuItem"
        Me.UBAHUSERDANPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.UBAHUSERDANPASSWORDToolStripMenuItem.Text = "UBAH USER DAN PASSWORD"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Image = CType(resources.GetObject("LOGOUTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LOGOUTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(82, 72)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        Me.LOGOUTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Status
        '
        Me.Status.AllowItemReorder = True
        Me.Status.BackColor = System.Drawing.SystemColors.Menu
        Me.Status.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.jam, Me.ToolStripStatusLabel5, Me.tanggal, Me.status3, Me.nama_komputer})
        Me.Status.Location = New System.Drawing.Point(0, 578)
        Me.Status.Name = "Status"
        Me.Status.ShowItemToolTips = True
        Me.Status.Size = New System.Drawing.Size(1191, 22)
        Me.Status.SizingGrip = False
        Me.Status.TabIndex = 14
        Me.Status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(283, 17)
        Me.ToolStripStatusLabel4.Spring = True
        Me.ToolStripStatusLabel4.Text = "user aktif"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'jam
        '
        Me.jam.ForeColor = System.Drawing.Color.Black
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(283, 17)
        Me.jam.Spring = True
        Me.jam.Text = "jam"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'tanggal
        '
        Me.tanggal.ForeColor = System.Drawing.Color.Black
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(283, 17)
        Me.tanggal.Spring = True
        Me.tanggal.Text = "tanggal"
        '
        'status3
        '
        Me.status3.ForeColor = System.Drawing.Color.Black
        Me.status3.Name = "status3"
        Me.status3.Size = New System.Drawing.Size(19, 17)
        Me.status3.Text = " | "
        '
        'nama_komputer
        '
        Me.nama_komputer.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.nama_komputer.ForeColor = System.Drawing.Color.Black
        Me.nama_komputer.Name = "nama_komputer"
        Me.nama_komputer.Size = New System.Drawing.Size(283, 17)
        Me.nama_komputer.Spring = True
        Me.nama_komputer.Text = "nama_komputer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tugas_UAS.My.Resources.Resources.BACKGROUND
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1191, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Menu_Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Transaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGATURANADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGolonganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PangkatPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MutasiPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MutasiJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PensiunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPangkatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanMutasiPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanMutasiJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPensiunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama_komputer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UBAHUSERDANPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
