Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.IO

Public Class QuanLySanPham
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")
    Dim dt As New DataTable()

    Private Sub QuanLySanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDienThoai()
        SetupDataGridView()
    End Sub

    Private Sub LoadDienThoai()
        Dim da As New SqlDataAdapter("SELECT * FROM DienThoai", connection)
        dt.Clear()
        da.Fill(dt)
        dgvSanPham.DataSource = dt
    End Sub

    Private Sub SetupDataGridView()
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.MultiSelect = False
        dgvSanPham.ReadOnly = True
        dgvSanPham.AllowUserToAddRows = False
    End Sub

    Private Sub ClearForm()
        txtTenDienThoai.Clear()
        txtHang.Clear()
        txtCauHinh.Clear()
        txtGiaBan.Clear()
        txtSoLuong.Clear()
        txtTenDienThoai.Focus()
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSanPham.Rows(e.RowIndex)
            txtTenDienThoai.Text = row.Cells("TenDT").Value.ToString()
            txtHang.Text = row.Cells("HangSX").Value.ToString()
            txtCauHinh.Text = row.Cells("CauHinh").Value.ToString()
            txtGiaBan.Text = row.Cells("GiaBan").Value.ToString()
            txtSoLuong.Text = row.Cells("SoLuong").Value.ToString()
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtTenDienThoai.Text = "" Or txtHang.Text = "" Or txtCauHinh.Text = "" Or txtGiaBan.Text = "" Or txtSoLuong.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Dim giaBan As Decimal
        Dim soLuong As Integer

        If Not Decimal.TryParse(txtGiaBan.Text, giaBan) Then
            MessageBox.Show("Giá bán phải là số hợp lệ.")
            Return
        End If

        If Not Integer.TryParse(txtSoLuong.Text, soLuong) Then
            MessageBox.Show("Số lượng phải là số nguyên.")
            Return
        End If

        Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM DienThoai WHERE TenDT=@TenDT", connection)
        cmdCheck.Parameters.AddWithValue("@TenDT", txtTenDienThoai.Text)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
        connection.Close()

        If count > 0 Then
            ' Cập nhật
            Dim cmdUpdate As New SqlCommand("UPDATE DienThoai SET HangSX=@HangSX, CauHinh=@CauHinh, GiaBan=@GiaBan, SoLuong=@SoLuong WHERE TenDT=@TenDT", connection)
            cmdUpdate.Parameters.AddWithValue("@TenDT", txtTenDienThoai.Text)
            cmdUpdate.Parameters.AddWithValue("@HangSX", txtHang.Text)
            cmdUpdate.Parameters.AddWithValue("@CauHinh", txtCauHinh.Text)
            cmdUpdate.Parameters.AddWithValue("@GiaBan", giaBan)
            cmdUpdate.Parameters.AddWithValue("@SoLuong", soLuong)
            connection.Open()
            cmdUpdate.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Cập nhật thông tin điện thoại thành công.")
        Else
            ' Thêm mới
            Dim cmdInsert As New SqlCommand("INSERT INTO DienThoai (TenDT, HangSX, CauHinh, GiaBan, SoLuong) VALUES (@TenDT, @HangSX, @CauHinh, @GiaBan, @SoLuong)", connection)
            cmdInsert.Parameters.AddWithValue("@TenDT", txtTenDienThoai.Text)
            cmdInsert.Parameters.AddWithValue("@HangSX", txtHang.Text)
            cmdInsert.Parameters.AddWithValue("@CauHinh", txtCauHinh.Text)
            cmdInsert.Parameters.AddWithValue("@GiaBan", giaBan)
            cmdInsert.Parameters.AddWithValue("@SoLuong", soLuong)
            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Thêm điện thoại thành công.")
        End If

        LoadDienThoai()
        ClearForm()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvSanPham.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn điện thoại để xóa.")
            Return
        End If

        Dim tenDT As String = dgvSanPham.SelectedRows(0).Cells("TenDT").Value.ToString()
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa điện thoại '" & tenDT & "' không?", "Xác nhận", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim cmdDelete As New SqlCommand("DELETE FROM DienThoai WHERE TenDT=@TenDT", connection)
            cmdDelete.Parameters.AddWithValue("@TenDT", tenDT)
            connection.Open()
            cmdDelete.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Xóa điện thoại thành công.")
            LoadDienThoai()
            ClearForm()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim keyword As String = txtTenDienThoai.Text.Trim()
        Dim query As String = "SELECT * FROM DienThoai WHERE TenDT LIKE @keyword"
        Dim da As New SqlDataAdapter(query, connection)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim dtSearch As New DataTable()
        da.Fill(dtSearch)
        dgvSanPham.DataSource = dtSearch
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
        LoadDienThoai()
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatfile.Click
        If dgvSanPham.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo")
            Return
        End If

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel File|*.xlsx"
            saveDialog.Title = "Lưu danh sách điện thoại"
            saveDialog.FileName = "DienThoai.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("DienThoai")

                    ' Ghi tiêu đề
                    For col As Integer = 0 To dgvSanPham.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgvSanPham.Columns(col).HeaderText
                    Next

                    ' Ghi dữ liệu
                    For row As Integer = 0 To dgvSanPham.Rows.Count - 1
                        For col As Integer = 0 To dgvSanPham.Columns.Count - 1
                            ws.Cells(row + 2, col + 1).Value = dgvSanPham.Rows(row).Cells(col).Value?.ToString()
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

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvSanPham.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.")
            Return
        End If

        Dim maDT As Integer = Convert.ToInt32(dgvSanPham.CurrentRow.Cells("MaDT").Value)
        Dim tenDT As String = txtTenDienThoai.Text.Trim()
        Dim hangSX As String = txtHang.Text.Trim()
        Dim cauHinh As String = txtCauHinh.Text.Trim()
        Dim soLuong As Integer
        Dim giaBan As Decimal

        If tenDT = "" Or hangSX = "" Or cauHinh = "" Or
            Not Integer.TryParse(txtSoLuong.Text, soLuong) Or
            Not Decimal.TryParse(txtGiaBan.Text, giaBan) Then
            MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.")
            Return
        End If

        Dim query As String = "UPDATE DienThoai SET TenDT = @TenDT, HangSX = @HangSX, CauHinh = @CauHinh, SoLuong = @SoLuong, GiaBan = @GiaBan WHERE MaDT = @MaDT"

        Using connection As New SqlConnection("Data Source=NGOCTU\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TenDT", tenDT)
                command.Parameters.AddWithValue("@HangSX", hangSX)
                command.Parameters.AddWithValue("@CauHinh", cauHinh)
                command.Parameters.AddWithValue("@SoLuong", soLuong)
                command.Parameters.AddWithValue("@GiaBan", giaBan)
                command.Parameters.AddWithValue("@MaDT", maDT)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        MessageBox.Show("Cập nhật sản phẩm thành công.")
        LoadDienThoai() ' Gọi lại hàm load danh sách để cập nhật lưới
    End Sub
End Class
