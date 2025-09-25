Imports System.Data.SqlClient

Public Class LapHoaDon
    Dim connection As New SqlConnection("Data Source=.




\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")
    Dim dtChiTiet As New DataTable()

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKhachHang()
        LoadNhanVien()
        InitChiTietGrid()
    End Sub

    Private Sub LoadKhachHang()
        Dim da As New SqlDataAdapter("SELECT MaKH, TenKH FROM KhachHang", connection)
        Dim dt As New DataTable()
        da.Fill(dt)
        cboKhachHang.DataSource = dt
        cboKhachHang.DisplayMember = "TenKH"
        cboKhachHang.ValueMember = "MaKH"
    End Sub

    Private Sub LoadNhanVien()
        Dim da As New SqlDataAdapter("SELECT MaNV, TenNV FROM NhanVien", connection)
        Dim dt As New DataTable()
        da.Fill(dt)
        cboNhanVien.DataSource = dt
        cboNhanVien.DisplayMember = "TenNV"
        cboNhanVien.ValueMember = "MaNV"
    End Sub

    Private Sub InitChiTietGrid()
        dtChiTiet.Columns.Add("MaDT", GetType(Integer))
        dtChiTiet.Columns.Add("TenDT", GetType(String))
        dtChiTiet.Columns.Add("SoLuong", GetType(Integer))
        dtChiTiet.Columns.Add("DonGia", GetType(Decimal))
        dtChiTiet.Columns.Add("ThanhTien", GetType(Decimal))
        dgvChiTietDonHang.DataSource = dtChiTiet

        dgvChiTietDonHang.Columns("MaDT").Visible = False ' Ẩn cột MaDT, chỉ dùng khi lưu
    End Sub

    Private Sub btnThemSanPham_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frmChon As New frmChonSanPham()
        If frmChon.ShowDialog() = DialogResult.OK Then
            Dim maDT = frmChon.SelectedMaDT
            Dim tenDT = frmChon.SelectedTenDT
            Dim donGia = frmChon.SelectedDonGia
            Dim soLuong = frmChon.SelectedSoLuong
            Dim thanhTien = donGia * soLuong

            dtChiTiet.Rows.Add(maDT, tenDT, soLuong, donGia, thanhTien)
        End If
    End Sub

    Private Function TinhTongTien() As Decimal
        Dim tong As Decimal = 0
        For Each row As DataRow In dtChiTiet.Rows
            tong += Convert.ToDecimal(row("ThanhTien"))
        Next
        Return tong
    End Function

    Private Sub btnLuuHoaDon_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If dtChiTiet.Rows.Count = 0 Then
            MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn.")
            Return
        End If

        Dim maKH As Integer = CInt(cboKhachHang.SelectedValue)
        Dim maNV As Integer = CInt(cboNhanVien.SelectedValue)
        Dim ngayLap As Date = dtpNgayLap.Value

        ' Tạo hóa đơn
        Dim cmdHD As New SqlCommand("INSERT INTO HoaDon (NgayLap, MaKH, MaNV) VALUES (@NgayLap, @MaKH, @MaNV); SELECT SCOPE_IDENTITY();", connection)
        cmdHD.Parameters.AddWithValue("@NgayLap", ngayLap)
        cmdHD.Parameters.AddWithValue("@MaKH", maKH)
        cmdHD.Parameters.AddWithValue("@MaNV", maNV)

        connection.Open()
        Dim maHD As Integer = Convert.ToInt32(cmdHD.ExecuteScalar()) ' Lấy ID vừa tạo

        ' Lưu chi tiết hóa đơn
        For Each row As DataRow In dtChiTiet.Rows
            Dim cmdCT As New SqlCommand("INSERT INTO ChiTietHoaDon (MaHD, MaDT, SoLuong, DonGia) VALUES (@MaHD, @MaDT, @SoLuong, @DonGia)", connection)
            cmdCT.Parameters.AddWithValue("@MaHD", maHD)
            cmdCT.Parameters.AddWithValue("@MaDT", row("MaDT"))
            cmdCT.Parameters.AddWithValue("@SoLuong", row("SoLuong"))
            cmdCT.Parameters.AddWithValue("@DonGia", row("DonGia"))
            cmdCT.ExecuteNonQuery()
        Next

        connection.Close()

        MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        dtChiTiet.Clear()
        cboKhachHang.SelectedIndex = 0
        cboNhanVien.SelectedIndex = 0
        dtpNgayLap.Value = Date.Today
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            ' Hoặc nếu muốn thoát chương trình:
            ' Application.Exit()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
