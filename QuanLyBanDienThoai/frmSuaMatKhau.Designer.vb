<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaMatKhau
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
        Me.txtMatKhauCu = New System.Windows.Forms.TextBox()
        Me.txtMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.txtXacNhanMatKhau = New System.Windows.Forms.TextBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkXacNhan = New System.Windows.Forms.CheckBox()
        Me.chkMatKhauMoi = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mật khẩu Cũ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu mới"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Xác nhận mật khẩu mới"
        '
        'txtMatKhauCu
        '
        Me.txtMatKhauCu.Location = New System.Drawing.Point(194, 61)
        Me.txtMatKhauCu.Name = "txtMatKhauCu"
        Me.txtMatKhauCu.Size = New System.Drawing.Size(281, 22)
        Me.txtMatKhauCu.TabIndex = 3
        '
        'txtMatKhauMoi
        '
        Me.txtMatKhauMoi.Location = New System.Drawing.Point(194, 107)
        Me.txtMatKhauMoi.Name = "txtMatKhauMoi"
        Me.txtMatKhauMoi.Size = New System.Drawing.Size(281, 22)
        Me.txtMatKhauMoi.TabIndex = 4
        Me.txtMatKhauMoi.UseSystemPasswordChar = True
        '
        'txtXacNhanMatKhau
        '
        Me.txtXacNhanMatKhau.Location = New System.Drawing.Point(194, 161)
        Me.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau"
        Me.txtXacNhanMatKhau.Size = New System.Drawing.Size(281, 22)
        Me.txtXacNhanMatKhau.TabIndex = 5
        Me.txtXacNhanMatKhau.UseSystemPasswordChar = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(311, 363)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(120, 49)
        Me.btnLuu.TabIndex = 6
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(643, 363)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(120, 49)
        Me.btnHuy.TabIndex = 7
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.chkXacNhan)
        Me.GroupBox1.Controls.Add(Me.chkMatKhauMoi)
        Me.GroupBox1.Controls.Add(Me.txtXacNhanMatKhau)
        Me.GroupBox1.Controls.Add(Me.txtMatKhauMoi)
        Me.GroupBox1.Controls.Add(Me.txtMatKhauCu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(229, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 236)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đổi mật khẩu"
        '
        'chkXacNhan
        '
        Me.chkXacNhan.AutoSize = True
        Me.chkXacNhan.Location = New System.Drawing.Point(194, 189)
        Me.chkXacNhan.Name = "chkXacNhan"
        Me.chkXacNhan.Size = New System.Drawing.Size(114, 20)
        Me.chkXacNhan.TabIndex = 9
        Me.chkXacNhan.Text = "Hiện mật khầu"
        Me.chkXacNhan.UseVisualStyleBackColor = True
        '
        'chkMatKhauMoi
        '
        Me.chkMatKhauMoi.AutoSize = True
        Me.chkMatKhauMoi.Location = New System.Drawing.Point(194, 135)
        Me.chkMatKhauMoi.Name = "chkMatKhauMoi"
        Me.chkMatKhauMoi.Size = New System.Drawing.Size(114, 20)
        Me.chkMatKhauMoi.TabIndex = 8
        Me.chkMatKhauMoi.Text = "Hiện mật khầu"
        Me.chkMatKhauMoi.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Gemini_Generated_Image_bmtt00bmtt00bmtt
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-8, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 111)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'frmSuaMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnLuu)
        Me.DoubleBuffered = True
        Me.Name = "frmSuaMatKhau"
        Me.Text = "frmSuaMatKhau"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMatKhauCu As TextBox
    Friend WithEvents txtMatKhauMoi As TextBox
    Friend WithEvents txtXacNhanMatKhau As TextBox
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkXacNhan As CheckBox
    Friend WithEvents chkMatKhauMoi As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
