Imports System.Data.SqlClient

Public Class frmSuaMatKhau
    Private tenDangNhap As String
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")

    Public Sub New(_tenDangNhap As String)
        InitializeComponent()
        tenDangNhap = _tenDangNhap
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim mkCu = txtMatKhauCu.Text.Trim()
        Dim mkMoi = txtMatKhauMoi.Text.Trim()
        Dim mkNhapLai = txtXacNhanMatKhau.Text.Trim()

        If mkCu = "" Or mkMoi = "" Or mkNhapLai = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.")
            Return
        End If

        If mkMoi <> mkNhapLai Then
            MessageBox.Show("Mật khẩu mới và xác nhận không khớp.")
            Return
        End If

        ' Kiểm tra mật khẩu cũ
        Dim cmdCheck As New SqlCommand("SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap = @TenDN", connection)
        cmdCheck.Parameters.AddWithValue("@TenDN", tenDangNhap)
        connection.Open()
        Dim mkHienTai = cmdCheck.ExecuteScalar()?.ToString()
        connection.Close()

        If mkCu <> mkHienTai Then
            MessageBox.Show("Mật khẩu cũ không đúng.")
            Return
        End If

        ' Cập nhật mật khẩu mới
        Dim cmdUpdate As New SqlCommand("UPDATE TaiKhoan SET MatKhau = @MatKhau WHERE TenDangNhap = @TenDN", connection)
        cmdUpdate.Parameters.AddWithValue("@MatKhau", mkMoi)
        cmdUpdate.Parameters.AddWithValue("@TenDN", tenDangNhap)
        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Đổi mật khẩu thành công.")
        Me.Close()
    End Sub


    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub chkMatKhauMoi_CheckedChanged(sender As Object, e As EventArgs) Handles chkMatKhauMoi.CheckedChanged
        txtMatKhauMoi.UseSystemPasswordChar = Not chkMatKhauMoi.Checked
    End Sub

    Private Sub chkXacNhan_CheckedChanged(sender As Object, e As EventArgs) Handles chkXacNhan.CheckedChanged
        txtXacNhanMatKhau.UseSystemPasswordChar = Not chkXacNhan.Checked
    End Sub
End Class
