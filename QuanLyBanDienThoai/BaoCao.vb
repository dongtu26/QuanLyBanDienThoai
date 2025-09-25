Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.IO

Public Class BaoCao
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")

    Private Sub frmBaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Date.Today.AddDays(-7)
        dtpDenNgay.Value = Date.Today
        lblTongDoanhThu.Text = "Tổng doanh thu: 0 đ"
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        LoadHoaDon()
    End Sub

    Private Sub LoadHoaDon()
        Dim query As String = "
            SELECT 
                hd.MaHD,
                hd.NgayLap,
                kh.TenKH,
                nv.TenNV,
                SUM(ct.SoLuong * ct.DonGia) AS TongTien
            FROM HoaDon hd
            JOIN KhachHang kh ON hd.MaKH = kh.MaKH
            JOIN NhanVien nv ON hd.MaNV = nv.MaNV
            JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
            WHERE hd.NgayLap BETWEEN @TuNgay AND @DenNgay
            GROUP BY hd.MaHD, hd.NgayLap, kh.TenKH, nv.TenNV
            ORDER BY hd.NgayLap DESC
        "

        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date)
        cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgvHoaDon.DataSource = dt
        lblTongDoanhThu.Text = "Tổng doanh thu: " & dt.AsEnumerable().Sum(Function(r) r.Field(Of Decimal)("TongTien")).ToString("N0") & " đ"

        dgvChiTiet.DataSource = Nothing
    End Sub

    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        If e.RowIndex >= 0 Then
            Dim maHD As Integer = Convert.ToInt32(dgvHoaDon.Rows(e.RowIndex).Cells("MaHD").Value)
            LoadChiTiet(maHD)
        End If
    End Sub

    Private Sub LoadChiTiet(maHD As Integer)
        Dim query As String = "
            SELECT dt.TenDT, cthd.SoLuong, cthd.DonGia, (cthd.SoLuong * cthd.DonGia) AS ThanhTien
            FROM ChiTietHoaDon cthd
            JOIN DienThoai dt ON cthd.MaDT = dt.MaDT
            WHERE cthd.MaHD = @MaHD
        "

        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@MaHD", maHD)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgvChiTiet.DataSource = dt
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatFileExcel.Click
        If dgvHoaDon.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất.")
            Return
        End If

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel File|*.xlsx"
            saveDialog.Title = "Xuất báo cáo doanh thu"
            saveDialog.FileName = "BaoCaoDoanhThu.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("HoaDon")

                    ' Xuất bảng hóa đơn
                    For col As Integer = 0 To dgvHoaDon.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgvHoaDon.Columns(col).HeaderText
                    Next

                    For row As Integer = 0 To dgvHoaDon.Rows.Count - 1
                        For col As Integer = 0 To dgvHoaDon.Columns.Count - 1
                            ws.Cells(row + 2, col + 1).Value = dgvHoaDon.Rows(row).Cells(col).Value?.ToString()
                        Next
                    Next

                    ' Ghi tổng doanh thu
                    Dim rowTotal = dgvHoaDon.Rows.Count + 3
                    ws.Cells(rowTotal, 1).Value = "Tổng doanh thu:"
                    ws.Cells(rowTotal, 2).Value = lblTongDoanhThu.Text

                    package.SaveAs(New FileInfo(saveDialog.FileName))
                    MessageBox.Show("Xuất Excel thành công!")
                End Using
            End If
        End Using
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            ' Hoặc nếu muốn thoát chương trình:
            ' Application.Exit()
        End If
    End Sub
End Class
