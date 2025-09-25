Public Class Formmain

    Public Shared CurrentUsername As String

    Private Sub mnuKhachHang_Click(sender As Object, e As EventArgs) Handles mnuKhachHang.Click
        Dim f As New QuanLyKhachHang()
        f.ShowDialog()
    End Sub

    Private Sub mnuNhanVien_Click(sender As Object, e As EventArgs) Handles mnuNhanVien.Click
        Dim f As New QuanLyNhanVien()
        f.ShowDialog()
    End Sub

    Private Sub mnuSanPham_Click(sender As Object, e As EventArgs) Handles mnuSanPham.Click
        Dim f As New QuanLySanPham()
        f.ShowDialog()
    End Sub

    Private Sub mnuLapHoaDon_Click(sender As Object, e As EventArgs) Handles mnuLapHoaDon.Click
        Dim f As New LapHoaDon()
        f.ShowDialog()
    End Sub

    Private Sub mnuBaoCao_Click(sender As Object, e As EventArgs) Handles mnuBaoCao.Click
        Dim f As New BaoCao()
        f.ShowDialog()
    End Sub

    Private Sub mnuBaoHanh_Click(sender As Object, e As EventArgs) Handles mnuBaoHanh.Click
        Dim f As New frmBaoHanh()
        f.ShowDialog()
    End Sub
    Private Sub mnuSuaMatKhau_Click(sender As Object, e As EventArgs) Handles mnuSuaMatKhau.Click
        Dim frm As New frmSuaMatKhau(CurrentUsername)
        frm.ShowDialog()
    End Sub

    Private Sub mnuDangXuat_Click(sender As Object, e As EventArgs) Handles mnuDangXuat.Click
        Dim result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Ẩn frmMain và mở lại frmDangNhap
            Me.Hide()
            Dim frm As New Form1()
            frm.Show()
        End If
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub mnuHuongDan_Click(sender As Object, e As EventArgs) Handles mnuHuongDan.Click
        Dim frm As New frmHuongDan()
        frm.ShowDialog()
    End Sub

    Private Sub mnuGioiThieu_Click(sender As Object, e As EventArgs) Handles mnuGioiThieu.Click
        Dim frm As New frmGioiThieuvb()
        frm.ShowDialog()
    End Sub


End Class