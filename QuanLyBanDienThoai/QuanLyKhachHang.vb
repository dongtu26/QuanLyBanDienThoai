Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.IO
Public Class QuanLyKhachHang
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")

    Private Sub QuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKhachHang()
    End Sub

    Private Sub LoadKhachHang()
        Dim da As New SqlDataAdapter("SELECT * FROM KhachHang", connection)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvKhachHang.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenKhachHang.Text = "" Or txtSDT.Text = "" Or txtDiaChi.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.")
            Return
        End If

        Dim maKH As String = "KH" & Now.Ticks.ToString().Substring(10)

        Dim cmd As New SqlCommand("INSERT INTO KhachHang (TenKH, SDT, DiaChi) VALUES ( @TenKH, @SDT, @DiaChi)", connection)
        cmd.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        LoadKhachHang()
        MessageBox.Show("Thêm khách hàng thành công.")
        ClearForm()
    End Sub

    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            txtTenKhachHang.Text = row.Cells("TenKH").Value.ToString()
            txtSDT.Text = row.Cells("SDT").Value.ToString()
            txtDiaChi.Text = row.Cells("DiaChi").Value.ToString()
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvKhachHang.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn khách hàng cần sửa.")
            Return
        End If

        Dim maKH As String = dgvKhachHang.SelectedRows(0).Cells("MaKH").Value.ToString()

        Dim cmd As New SqlCommand("UPDATE KhachHang SET TenKH=@TenKH, SDT=@SDT, DiaChi=@DiaChi WHERE MaKH=@MaKH", connection)
        cmd.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
        cmd.Parameters.AddWithValue("@MaKH", maKH)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        LoadKhachHang()
        MessageBox.Show("Sửa thông tin thành công.")
        ClearForm()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvKhachHang.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn khách hàng cần xóa.")
            Return
        End If

        Dim maKH As String = dgvKhachHang.SelectedRows(0).Cells("MaKH").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", connection)
            cmd.Parameters.AddWithValue("@MaKH", maKH)

            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()

            LoadKhachHang()
            MessageBox.Show("Xóa thành công.")
            ClearForm()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim keyword As String = txtTenKhachHang.Text.Trim()

        Dim da As New SqlDataAdapter("SELECT * FROM KhachHang WHERE TenKH LIKE @keyword", connection)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

        Dim dt As New DataTable()
        da.Fill(dt)
        dgvKhachHang.DataSource = dt
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
        LoadKhachHang()
    End Sub

    Private Sub ClearForm()
        txtTenKhachHang.Clear()
        txtSDT.Clear()
        txtDiaChi.Clear()
        txtTenKhachHang.Focus()
    End Sub

    Private Sub btnXuatfile_Click(sender As Object, e As EventArgs) Handles btnXuatfile.Click
        If dgvKhachHang.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo")
            Return
        End If

        ' Cấu hình để dùng EPPlus (phải có ở đầu file: Imports OfficeOpenXml)
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel File|*.xlsx"
            saveDialog.Title = "Lưu danh sách khách hàng"
            saveDialog.FileName = "DanhSachKhachHang.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("KhachHang")

                    ' Ghi tiêu đề cột
                    For col As Integer = 0 To dgvKhachHang.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgvKhachHang.Columns(col).HeaderText
                    Next

                    ' Ghi dữ liệu
                    For row As Integer = 0 To dgvKhachHang.Rows.Count - 1
                        For col As Integer = 0 To dgvKhachHang.Columns.Count - 1
                            ws.Cells(row + 2, col + 1).Value = dgvKhachHang.Rows(row).Cells(col).Value
                        Next
                    Next

                    ' Lưu file
                    Dim file = New FileInfo(saveDialog.FileName)
                    package.SaveAs(file)
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo")
                End Using
            End If
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
