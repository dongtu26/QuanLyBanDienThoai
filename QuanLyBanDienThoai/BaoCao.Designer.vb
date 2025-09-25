<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaoCao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTongDoanhThu = New System.Windows.Forms.Label()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.btnXuatFileExcel = New System.Windows.Forms.Button()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.dgvChiTiet = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Từ ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Đến ngày"
        '
        'lblTongDoanhThu
        '
        Me.lblTongDoanhThu.AutoSize = True
        Me.lblTongDoanhThu.Location = New System.Drawing.Point(63, 137)
        Me.lblTongDoanhThu.Name = "lblTongDoanhThu"
        Me.lblTongDoanhThu.Size = New System.Drawing.Size(100, 16)
        Me.lblTongDoanhThu.TabIndex = 2
        Me.lblTongDoanhThu.Text = "Tổng doanh thu"
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(27, 22)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(95, 59)
        Me.btnThongKe.TabIndex = 3
        Me.btnThongKe.Text = "Thống Kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'btnXuatFileExcel
        '
        Me.btnXuatFileExcel.Location = New System.Drawing.Point(155, 22)
        Me.btnXuatFileExcel.Name = "btnXuatFileExcel"
        Me.btnXuatFileExcel.Size = New System.Drawing.Size(95, 59)
        Me.btnXuatFileExcel.TabIndex = 4
        Me.btnXuatFileExcel.Text = "Xuất file excel"
        Me.btnXuatFileExcel.UseVisualStyleBackColor = True
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Location = New System.Drawing.Point(144, 46)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(250, 22)
        Me.dtpTuNgay.TabIndex = 5
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Location = New System.Drawing.Point(144, 93)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(250, 22)
        Me.dtpDenNgay.TabIndex = 6
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(537, 33)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.RowHeadersWidth = 51
        Me.dgvHoaDon.RowTemplate.Height = 24
        Me.dgvHoaDon.Size = New System.Drawing.Size(515, 346)
        Me.dgvHoaDon.TabIndex = 7
        '
        'dgvChiTiet
        '
        Me.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTiet.Location = New System.Drawing.Point(537, 399)
        Me.dgvChiTiet.Name = "dgvChiTiet"
        Me.dgvChiTiet.RowHeadersWidth = 51
        Me.dgvChiTiet.RowTemplate.Height = 24
        Me.dgvChiTiet.Size = New System.Drawing.Size(515, 72)
        Me.dgvChiTiet.TabIndex = 8
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(282, 22)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 59)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.GroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.GroupBox1.Controls.Add(Me.lblTongDoanhThu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 185)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Xuát"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnXuatFileExcel)
        Me.GroupBox2.Controls.Add(Me.btnThongKe)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 110)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Gemini_Generated_Image_bmtt00bmtt00bmtt
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 113)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'BaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvChiTiet)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Name = "BaoCao"
        Me.Text = "BaoCao"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTongDoanhThu As Label
    Friend WithEvents btnThongKe As Button
    Friend WithEvents btnXuatFileExcel As Button
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents dgvHoaDon As DataGridView
    Friend WithEvents dgvChiTiet As DataGridView
    Friend WithEvents btnThoat As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
