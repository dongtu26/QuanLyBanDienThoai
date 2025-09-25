<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDan
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
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNoiDung
        '
        Me.txtNoiDung.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoiDung.Location = New System.Drawing.Point(0, 0)
        Me.txtNoiDung.Multiline = True
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.ReadOnly = True
        Me.txtNoiDung.Size = New System.Drawing.Size(532, 508)
        Me.txtNoiDung.TabIndex = 0
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(190, 448)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(147, 48)
        Me.btnDong.TabIndex = 1
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmHuongDan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanDienThoai.My.Resources.Resources.Your_paragrtext
        Me.ClientSize = New System.Drawing.Size(1064, 508)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Name = "frmHuongDan"
        Me.Text = "frmHuongDan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents btnDong As Button
End Class
