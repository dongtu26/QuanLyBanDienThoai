Public Class frmGioiThieuvb
    Private Sub frmGioiThieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGioiThieu.Text = "📱 PHẦN MỀM QUẢN LÝ BÁN ĐIỆN THOẠI" & vbCrLf & vbCrLf &
                            "✅ Tính năng nổi bật:" & vbCrLf &
                            "- Quản lý danh sách điện thoại, khách hàng, nhân viên." & vbCrLf &
                            "- Lập hóa đơn bán hàng, tính tiền tự động." & vbCrLf &
                            "- Theo dõi phiếu bảo hành sản phẩm." & vbCrLf &
                            "- Thống kê doanh thu theo ngày." & vbCrLf &
                            "- Đổi mật khẩu cho tài khoản đăng nhập." & vbCrLf & vbCrLf &
                            "👨‍💻 Nhóm phát triển: Nhóm 3 - CNTT (2024 - 2025)" & vbCrLf &
                            "- Thành viên: 
                                            + Đồng Ngọc Tú
                                            + Nguyễn Như Thuần
                                            + Đỗ Phan Tương Anh" & vbCrLf &
                            "🏫 Trường Đại học Kinh Doanh và Công Nghệ Hà Nội" & vbCrLf &
                            "📧 Liên hệ: nhom3@truongHUBT.edu.vn"
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class
