Imports System.Data.SqlClient

Public Class frmChonSanPham
    Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True")

    ' Trả dữ liệu về frmHoaDon
    Public Property SelectedMaDT As Integer
    Public Property SelectedTenDT As String
    Public Property SelectedDonGia As Decimal
    Public Property SelectedSoLuong As Integer

    Private Sub frmChonSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanPham()
    End Sub

    Private Sub LoadSanPham()
        Dim da As New SqlDataAdapter("SELECT MaDT, TenDT, GiaBan FROM DienThoai", connection)
        Dim dt As New DataTable()
        da.Fill(dt)

        cboTenDT.DataSource = dt
        cboTenDT.DisplayMember = "TenDT"
        cboTenDT.ValueMember = "MaDT"
    End Sub

    Private Sub cboSanPham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenDT.SelectedIndexChanged
        If cboTenDT.SelectedIndex >= 0 Then
            Dim drv As DataRowView = CType(cboTenDT.SelectedItem, DataRowView)
            txtGiaBan.Text = drv("GiaBan").ToString()
        End If
    End Sub

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        If cboTenDT.SelectedIndex < 0 Or txtSoLuong.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.")
            Return
        End If

        SelectedMaDT = CInt(cboTenDT.SelectedValue)
        SelectedTenDT = cboTenDT.Text
        SelectedDonGia = Decimal.Parse(txtGiaBan.Text)
        SelectedSoLuong = Integer.Parse(txtSoLuong.Text)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
