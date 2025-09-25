<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLySanPham
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenDienThoai = New System.Windows.Forms.TextBox()
        Me.txtHang = New System.Windows.Forms.TextBox()
        Me.txtCauHinh = New System.Windows.Forms.TextBox()
        Me.txtGiaBan = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXuatfile = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên điện thoại "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hãng sản xuất "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(63, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cấu hình "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(69, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giá bán"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(63, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số lượng"
        '
        'txtTenDienThoai
        '
        Me.txtTenDienThoai.Location = New System.Drawing.Point(139, 31)
        Me.txtTenDienThoai.Name = "txtTenDienThoai"
        Me.txtTenDienThoai.Size = New System.Drawing.Size(287, 22)
        Me.txtTenDienThoai.TabIndex = 5
        '
        'txtHang
        '
        Me.txtHang.Location = New System.Drawing.Point(139, 71)
        Me.txtHang.Name = "txtHang"
        Me.txtHang.Size = New System.Drawing.Size(287, 22)
        Me.txtHang.TabIndex = 6
        '
        'txtCauHinh
        '
        Me.txtCauHinh.Location = New System.Drawing.Point(139, 115)
        Me.txtCauHinh.Name = "txtCauHinh"
        Me.txtCauHinh.Size = New System.Drawing.Size(287, 22)
        Me.txtCauHinh.TabIndex = 7
        '
        'txtGiaBan
        '
        Me.txtGiaBan.Location = New System.Drawing.Point(139, 157)
        Me.txtGiaBan.Name = "txtGiaBan"
        Me.txtGiaBan.Size = New System.Drawing.Size(287, 22)
        Me.txtGiaBan.TabIndex = 8
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(139, 202)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(287, 22)
        Me.txtSoLuong.TabIndex = 9
        '
        'dgvSanPham
        '
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(645, 12)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.RowHeadersWidth = 51
        Me.dgvSanPham.RowTemplate.Height = 24
        Me.dgvSanPham.Size = New System.Drawing.Size(407, 416)
        Me.dgvSanPham.TabIndex = 10
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(60, 45)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(100, 48)
        Me.btnLuu.TabIndex = 12
        Me.btnLuu.Text = "Thêm"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.ForeColor = System.Drawing.Color.Black
        Me.btnXoa.Location = New System.Drawing.Point(311, 45)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 48)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.ForeColor = System.Drawing.Color.Black
        Me.btnSua.Location = New System.Drawing.Point(190, 45)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 48)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiem.Location = New System.Drawing.Point(60, 115)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(100, 48)
        Me.btnTimKiem.TabIndex = 15
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(311, 115)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 48)
        Me.btnThoat.TabIndex = 16
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXuatfile
        '
        Me.btnXuatfile.Location = New System.Drawing.Point(645, 434)
        Me.btnXuatfile.Name = "btnXuatfile"
        Me.btnXuatfile.Size = New System.Drawing.Size(407, 56)
        Me.btnXuatfile.TabIndex = 17
        Me.btnXuatfile.Text = "Xuất file execl"
        Me.btnXuatfile.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(190, 115)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 48)
        Me.btnReset.TabIndex = 37
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.txtGiaBan)
        Me.GroupBox1.Controls.Add(Me.txtCauHinh)
        Me.GroupBox1.Controls.Add(Me.txtHang)
        Me.GroupBox1.Controls.Add(Me.txtTenDienThoai)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(166, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 271)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Xuất"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnTimKiem)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(166, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 201)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Gemini_Generated_Image_bmtt00bmtt00bmtt
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 111)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'QuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnXuatfile)
        Me.Controls.Add(Me.dgvSanPham)
        Me.DoubleBuffered = True
        Me.Name = "QuanLySanPham"
        Me.Text = "QuanLySanPham"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenDienThoai As TextBox
    Friend WithEvents txtHang As TextBox
    Friend WithEvents txtCauHinh As TextBox
    Friend WithEvents txtGiaBan As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXuatfile As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
