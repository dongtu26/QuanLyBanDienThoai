Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.IO

Public Class QuanLyNhanVien
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")

    Private Sub QuanLyNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNhanVien()
    End Sub

    Private Sub LoadNhanVien()
        Dim da As New SqlDataAdapter("SELECT * FROM NhanVien", connection)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvNhanVien.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenNhanVien.Text = "" Or txtSDT.Text = "" Or txtChucVu.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.")
            Return
        End If

        Dim maNV As String = "NV" & Now.Ticks.ToString().Substring(10)

        Dim cmd As New SqlCommand("INSERT INTO NhanVien ( TenNV, SDT, ChucVu) VALUES ( @TenNV, @SDT, @ChucVu)", connection)

        cmd.Parameters.AddWithValue("@TenNV", txtTenNhanVien.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        LoadNhanVien()
        MessageBox.Show("Thêm nhân viên thành công.")
        ClearForm()
    End Sub

    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvNhanVien.Rows(e.RowIndex)
            txtTenNhanVien.Text = row.Cells("TenNV").Value.ToString()
            txtSDT.Text = row.Cells("SDT").Value.ToString()
            txtChucVu.Text = row.Cells("ChucVu").Value.ToString()
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvNhanVien.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn nhân viên cần sửa.")
            Return
        End If

        Dim maNV As String = dgvNhanVien.SelectedRows(0).Cells("MaNV").Value.ToString()

        Dim cmd As New SqlCommand("UPDATE NhanVien SET TenNV=@TenNV, SDT=@SDT, ChucVu=@ChucVu WHERE MaNV=@MaNV", connection)
        cmd.Parameters.AddWithValue("@TenNV", txtTenNhanVien.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text)
        cmd.Parameters.AddWithValue("@MaNV", maNV)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        LoadNhanVien()
        MessageBox.Show("Sửa thông tin thành công.")
        ClearForm()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvNhanVien.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn nhân viên cần xóa.")
            Return
        End If

        Dim maNV As String = dgvNhanVien.SelectedRows(0).Cells("MaNV").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM NhanVien WHERE MaNV = @MaNV", connection)
            cmd.Parameters.AddWithValue("@MaNV", maNV)

            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()

            LoadNhanVien()
            MessageBox.Show("Xóa thành công.")
            ClearForm()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
        LoadNhanVien()
    End Sub

    Private Sub ClearForm()
        txtTenNhanVien.Clear()
        txtSDT.Clear()
        txtChucVu.Clear()
        txtTenNhanVien.Focus()
    End Sub

    ' Xuất danh sách nhân viên ra file Excel dùng EPPlus
    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatfile.Click
        If dgvNhanVien.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo")
            Return
        End If

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel File|*.xlsx"
            saveDialog.Title = "Lưu danh sách nhân viên"
            saveDialog.FileName = "DanhSachNhanVien.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("NhanVien")

                    For col As Integer = 0 To dgvNhanVien.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgvNhanVien.Columns(col).HeaderText
                    Next

                    For row As Integer = 0 To dgvNhanVien.Rows.Count - 1
                        For col As Integer = 0 To dgvNhanVien.Columns.Count - 1
                            ws.Cells(row + 2, col + 1).Value = dgvNhanVien.Rows(row).Cells(col).Value?.ToString()
                        Next
                    Next

                    Dim fileInfo As New IO.FileInfo(saveDialog.FileName)
                    package.SaveAs(fileInfo)

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo")
                End Using
            End If
        End Using
    End Sub

    ' Nút thoát form, trở về frmMain hoặc đóng form
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            ' Hoặc nếu muốn thoát chương trình:
            ' Application.Exit()
        End If
    End Sub
End Class
