<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGioiThieuvb
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
        Me.txtGioiThieu = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGioiThieu
        '
        Me.txtGioiThieu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtGioiThieu.Location = New System.Drawing.Point(0, 0)
        Me.txtGioiThieu.Multiline = True
        Me.txtGioiThieu.Name = "txtGioiThieu"
        Me.txtGioiThieu.ReadOnly = True
        Me.txtGioiThieu.Size = New System.Drawing.Size(533, 508)
        Me.txtGioiThieu.TabIndex = 1
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(193, 448)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(147, 48)
        Me.btnDong.TabIndex = 2
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmGioiThieuvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.txtGioiThieu)
        Me.Name = "frmGioiThieuvb"
        Me.Text = "frmGioiThieuvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGioiThieu As TextBox
    Friend WithEvents btnDong As Button
End Class
