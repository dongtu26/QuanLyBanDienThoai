<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSuaMatKhau = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNhanVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.BánHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLapHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBaoCao = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBaoHanh = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHuongDan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGioiThieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "QUẢN LÝ BÁN ĐIỆN THOẠI"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.BánHàngToolStripMenuItem, Me.mnuBaoHanh, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDangXuat, Me.mnuSuaMatKhau, Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'mnuDangXuat
        '
        Me.mnuDangXuat.Name = "mnuDangXuat"
        Me.mnuDangXuat.Size = New System.Drawing.Size(182, 26)
        Me.mnuDangXuat.Text = "Đăng xuất"
        '
        'mnuSuaMatKhau
        '
        Me.mnuSuaMatKhau.Name = "mnuSuaMatKhau"
        Me.mnuSuaMatKhau.Size = New System.Drawing.Size(182, 26)
        Me.mnuSuaMatKhau.Text = "Sửa mật khẩu"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSanPham, Me.mnuNhanVien, Me.mnuKhachHang})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'mnuSanPham
        '
        Me.mnuSanPham.Name = "mnuSanPham"
        Me.mnuSanPham.Size = New System.Drawing.Size(221, 26)
        Me.mnuSanPham.Text = "Quản lý sản phẩm"
        '
        'mnuNhanVien
        '
        Me.mnuNhanVien.Name = "mnuNhanVien"
        Me.mnuNhanVien.Size = New System.Drawing.Size(221, 26)
        Me.mnuNhanVien.Text = "Quản lý nhân viên"
        '
        'mnuKhachHang
        '
        Me.mnuKhachHang.Name = "mnuKhachHang"
        Me.mnuKhachHang.Size = New System.Drawing.Size(221, 26)
        Me.mnuKhachHang.Text = "Quản lý khách hàng"
        '
        'BánHàngToolStripMenuItem
        '
        Me.BánHàngToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BánHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLapHoaDon, Me.mnuBaoCao})
        Me.BánHàngToolStripMenuItem.Name = "BánHàngToolStripMenuItem"
        Me.BánHàngToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.BánHàngToolStripMenuItem.Text = "Bán hàng"
        '
        'mnuLapHoaDon
        '
        Me.mnuLapHoaDon.Name = "mnuLapHoaDon"
        Me.mnuLapHoaDon.Size = New System.Drawing.Size(183, 26)
        Me.mnuLapHoaDon.Text = "Lập đơn hàng"
        '
        'mnuBaoCao
        '
        Me.mnuBaoCao.Name = "mnuBaoCao"
        Me.mnuBaoCao.Size = New System.Drawing.Size(183, 26)
        Me.mnuBaoCao.Text = "Báo cáo"
        '
        'mnuBaoHanh
        '
        Me.mnuBaoHanh.BackColor = System.Drawing.Color.White
        Me.mnuBaoHanh.Name = "mnuBaoHanh"
        Me.mnuBaoHanh.Size = New System.Drawing.Size(85, 24)
        Me.mnuBaoHanh.Text = "Bảo hành"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.TrợGiúpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHuongDan, Me.mnuGioiThieu})
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'mnuHuongDan
        '
        Me.mnuHuongDan.Name = "mnuHuongDan"
        Me.mnuHuongDan.Size = New System.Drawing.Size(244, 26)
        Me.mnuHuongDan.Text = "Hướng dẫn"
        '
        'mnuGioiThieu
        '
        Me.mnuGioiThieu.Name = "mnuGioiThieu"
        Me.mnuGioiThieu.Size = New System.Drawing.Size(244, 26)
        Me.mnuGioiThieu.Text = "Giới thiệu chương trình"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Gemini_Generated_Image_bmtt00bmtt00bmtt
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 361)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 111)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Formmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formmain"
        Me.Text = "Formmain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDangXuat As ToolStripMenuItem
    Friend WithEvents mnuSuaMatKhau As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSanPham As ToolStripMenuItem
    Friend WithEvents mnuNhanVien As ToolStripMenuItem
    Friend WithEvents mnuKhachHang As ToolStripMenuItem
    Friend WithEvents BánHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLapHoaDon As ToolStripMenuItem
    Friend WithEvents mnuBaoCao As ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHuongDan As ToolStripMenuItem
    Friend WithEvents mnuGioiThieu As ToolStripMenuItem
    Friend WithEvents mnuBaoHanh As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
End Class
