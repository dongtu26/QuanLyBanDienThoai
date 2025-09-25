Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True"

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim user As String = txtTenDangNhap.Text.Trim()
        Dim pass As String = txtMatKhau.Text.Trim()

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", user)
            cmd.Parameters.AddWithValue("@pass", pass)

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Formmain.CurrentUsername = txtTenDangNhap.Text.Trim()
                    Formmain.Show()
                    Me.Hide()


                Else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Lỗi kết nối: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub chkHienMatKhau_CheckedChanged(sender As Object, e As EventArgs) Handles chkHienMatKhau.CheckedChanged
        txtMatKhau.UseSystemPasswordChar = Not chkHienMatKhau.Checked
    End Sub
End Class
