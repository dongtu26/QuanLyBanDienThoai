Public Class frmHuongDan
    Private Sub frmHuongDan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNoiDung.Text = "📌 HƯỚNG DẪN SỬ DỤNG PHẦN MỀM QUẢN LÝ BÁN ĐIỆN THOẠI:" & vbCrLf & vbCrLf &
                          "1. Đăng nhập vào phần mềm bằng tài khoản được cấp." & vbCrLf &
                          "2. Vào menu 'Quản lý' để thêm/sửa điện thoại, khách hàng, nhân viên." & vbCrLf &
                          "3. Chọn 'Bán hàng' để lập hóa đơn bán sản phẩm cho khách." & vbCrLf &
                          "4. Vào mục 'Bảo hành' để theo dõi, thêm phiếu bảo hành sản phẩm." & vbCrLf &
                          "5. Xem báo cáo doanh thu trong mục 'Báo cáo'." & vbCrLf &
                          "6. Đổi mật khẩu trong mục 'Sửa mật khẩu'." & vbCrLf &
                          "7. Đăng xuất khỏi hệ thống khi hoàn tất công việc."
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class
