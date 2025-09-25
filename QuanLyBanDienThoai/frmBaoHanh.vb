Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.IO
Public Class frmBaoHanh
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")
    Dim dt As New DataTable()

    Private Sub frmBaoHanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaHD()
        dgvBaoHanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBaoHanh.ReadOnly = True
        LoadBaoHanh()
    End Sub

    Private Sub LoadMaHD()
        Dim da As New SqlDataAdapter("SELECT MaHD FROM HoaDon", connection)
        Dim dtHD As New DataTable()
        da.Fill(dtHD)
        cboMaHD.DataSource = dtHD
        cboMaHD.DisplayMember = "MaHD"
        cboMaHD.ValueMember = "MaHD"
    End Sub

    Private Sub LoadMaDT(maHD As Integer)
        Dim da As New SqlDataAdapter("SELECT DISTINCT MaDT FROM ChiTietHoaDon WHERE MaHD = @MaHD", connection)
        da.SelectCommand.Parameters.AddWithValue("@MaHD", maHD)
        Dim dtDT As New DataTable()
        da.Fill(dtDT)
        cboMaDT.DataSource = dtDT
        cboMaDT.DisplayMember = "MaDT"
        cboMaDT.ValueMember = "MaDT"
    End Sub

    Private Sub cboMaHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaHD.SelectedIndexChanged
        If TypeOf cboMaHD.SelectedItem Is DataRowView Then
            Dim drv As DataRowView = CType(cboMaHD.SelectedItem, DataRowView)
            LoadMaDT(CInt(drv("MaHD")))
        End If
    End Sub

    Private Sub LoadBaoHanh()
        Dim da As New SqlDataAdapter("SELECT * FROM PhieuBaoHanh", connection)
        dt.Clear()
        da.Fill(dt)
        dgvBaoHanh.DataSource = dt
    End Sub

    Private Sub ClearForm()
        txtHanBH.Clear()
        txtGhiChu.Clear()
        dtpNgayBH.Value = Date.Today
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If cboMaHD.SelectedValue Is Nothing Or cboMaDT.SelectedValue Is Nothing Or txtHanBH.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Dim cmd As New SqlCommand("INSERT INTO PhieuBaoHanh (MaHD, MaDT, NgayBH, HanBH, GhiChu) VALUES (@MaHD, @MaDT, @NgayBH, @HanBH, @GhiChu)", connection)
        cmd.Parameters.AddWithValue("@MaHD", cboMaHD.SelectedValue)
        cmd.Parameters.AddWithValue("@MaDT", cboMaDT.SelectedValue)
        cmd.Parameters.AddWithValue("@NgayBH", dtpNgayBH.Value)
        cmd.Parameters.AddWithValue("@HanBH", Integer.Parse(txtHanBH.Text))
        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Thêm phiếu bảo hành thành công.")
        LoadBaoHanh()
        ClearForm()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvBaoHanh.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn phiếu để sửa.")
            Return
        End If

        Dim maPhieu As Integer = dgvBaoHanh.SelectedRows(0).Cells("MaPhieu").Value

        Dim cmd As New SqlCommand("UPDATE PhieuBaoHanh SET MaHD=@MaHD, MaDT=@MaDT, NgayBH=@NgayBH, HanBH=@HanBH, GhiChu=@GhiChu WHERE MaPhieu=@MaPhieu", connection)
        cmd.Parameters.AddWithValue("@MaHD", cboMaHD.SelectedValue)
        cmd.Parameters.AddWithValue("@MaDT", cboMaDT.SelectedValue)
        cmd.Parameters.AddWithValue("@NgayBH", dtpNgayBH.Value)
        cmd.Parameters.AddWithValue("@HanBH", Integer.Parse(txtHanBH.Text))
        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text)
        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Cập nhật phiếu bảo hành thành công.")
        LoadBaoHanh()
        ClearForm()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvBaoHanh.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn phiếu để xóa.")
            Return
        End If

        Dim maPhieu As Integer = dgvBaoHanh.SelectedRows(0).Cells("MaPhieu").Value

        Dim result = MessageBox.Show("Bạn có chắc muốn xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM PhieuBaoHanh WHERE MaPhieu=@MaPhieu", connection)
            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu)

            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Xóa thành công.")
            LoadBaoHanh()
            ClearForm()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim da As New SqlDataAdapter("SELECT * FROM PhieuBaoHanh WHERE MaHD = @MaHD", connection)
        da.SelectCommand.Parameters.AddWithValue("@MaHD", cboMaHD.SelectedValue)
        Dim dtTK As New DataTable()
        da.Fill(dtTK)
        dgvBaoHanh.DataSource = dtTK
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
        LoadBaoHanh()
    End Sub

    Private Sub dgvBaoHanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaoHanh.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBaoHanh.Rows(e.RowIndex)
            cboMaHD.SelectedValue = row.Cells("MaHD").Value
            cboMaDT.SelectedValue = row.Cells("MaDT").Value
            dtpNgayBH.Value = CDate(row.Cells("NgayBH").Value)
            txtHanBH.Text = row.Cells("HanBH").Value.ToString()
            txtGhiChu.Text = row.Cells("GhiChu").Value.ToString()
        End If
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        If dgvBaoHanh.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất.")
            Return
        End If

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel File|*.xlsx"
            saveDialog.Title = "Lưu danh sách phiếu bảo hành"
            saveDialog.FileName = "DanhSachPhieuBaoHanh.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("PhieuBaoHanh")

                    ' Ghi tiêu đề cột
                    For col As Integer = 0 To dgvBaoHanh.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgvBaoHanh.Columns(col).HeaderText
                    Next

                    ' Ghi dữ liệu
                    For row As Integer = 0 To dgvBaoHanh.Rows.Count - 1
                        For col As Integer = 0 To dgvBaoHanh.Columns.Count - 1
                            ws.Cells(row + 2, col + 1).Value = dgvBaoHanh.Rows(row).Cells(col).Value?.ToString()
                        Next
                    Next

                    package.SaveAs(New FileInfo(saveDialog.FileName))
                    MessageBox.Show("Xuất Excel thành công!")
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
