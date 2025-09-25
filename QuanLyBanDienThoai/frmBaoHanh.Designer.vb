<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoHanh
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
        Me.cboMaHD = New System.Windows.Forms.ComboBox()
        Me.cboMaDT = New System.Windows.Forms.ComboBox()
        Me.dtpNgayBH = New System.Windows.Forms.DateTimePicker()
        Me.txtHanBH = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgvBaoHanh = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnXuatExcel = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvBaoHanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày bảo hành"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hạn bảo hành"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ghi chú"
        '
        'cboMaHD
        '
        Me.cboMaHD.FormattingEnabled = True
        Me.cboMaHD.Location = New System.Drawing.Point(140, 27)
        Me.cboMaHD.Name = "cboMaHD"
        Me.cboMaHD.Size = New System.Drawing.Size(250, 24)
        Me.cboMaHD.TabIndex = 5
        '
        'cboMaDT
        '
        Me.cboMaDT.FormattingEnabled = True
        Me.cboMaDT.Location = New System.Drawing.Point(140, 81)
        Me.cboMaDT.Name = "cboMaDT"
        Me.cboMaDT.Size = New System.Drawing.Size(250, 24)
        Me.cboMaDT.TabIndex = 6
        '
        'dtpNgayBH
        '
        Me.dtpNgayBH.Location = New System.Drawing.Point(139, 130)
        Me.dtpNgayBH.Name = "dtpNgayBH"
        Me.dtpNgayBH.Size = New System.Drawing.Size(251, 22)
        Me.dtpNgayBH.TabIndex = 7
        '
        'txtHanBH
        '
        Me.txtHanBH.Location = New System.Drawing.Point(142, 182)
        Me.txtHanBH.Name = "txtHanBH"
        Me.txtHanBH.Size = New System.Drawing.Size(247, 22)
        Me.txtHanBH.TabIndex = 8
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(142, 231)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(247, 22)
        Me.txtGhiChu.TabIndex = 9
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(36, 23)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 48)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(168, 23)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 48)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(299, 23)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 48)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(36, 102)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(95, 48)
        Me.btnTimKiem.TabIndex = 13
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(168, 102)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 48)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(299, 102)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 48)
        Me.btnThoat.TabIndex = 15
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgvBaoHanh
        '
        Me.dgvBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoHanh.Location = New System.Drawing.Point(650, 19)
        Me.dgvBaoHanh.Name = "dgvBaoHanh"
        Me.dgvBaoHanh.RowHeadersWidth = 51
        Me.dgvBaoHanh.RowTemplate.Height = 24
        Me.dgvBaoHanh.Size = New System.Drawing.Size(413, 405)
        Me.dgvBaoHanh.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.txtHanBH)
        Me.GroupBox1.Controls.Add(Me.dtpNgayBH)
        Me.GroupBox1.Controls.Add(Me.cboMaDT)
        Me.GroupBox1.Controls.Add(Me.cboMaHD)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 272)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Xuất"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnTimKiem)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Location = New System.Drawing.Point(177, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 159)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.Location = New System.Drawing.Point(650, 430)
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Size = New System.Drawing.Size(413, 60)
        Me.btnXuatExcel.TabIndex = 16
        Me.btnXuatExcel.Text = "Xuất excel"
        Me.btnXuatExcel.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Gemini_Generated_Image_bmtt00bmtt00bmtt
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 113)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'frmBaoHanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnXuatExcel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBaoHanh)
        Me.Name = "frmBaoHanh"
        Me.Text = "frmBaoHanh"
        CType(Me.dgvBaoHanh, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboMaHD As ComboBox
    Friend WithEvents cboMaDT As ComboBox
    Friend WithEvents dtpNgayBH As DateTimePicker
    Friend WithEvents txtHanBH As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents dgvBaoHanh As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnXuatExcel As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
