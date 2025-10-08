Imports Microsoft.Data.SqlClient
Imports System.Data
Public Class QuanLyLopHoc
    Dim connectionString As String = "Data Source=LAPTOP-J6E59HOB\SQLEXPRESS;Initial Catalog=QLSinhVien;Encrypt=False;TrustServerCertificate=True;Integrated Security=True"
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub QuanLyLopHoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        conn = New SqlConnection(connectionString)
        Dim sql As String = "SELECT * FROM Lop"
        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        dgvLop.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaLop.Text = "" Or txtTenLop.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        conn = New SqlConnection(connectionString)
        conn.Open()
        Dim sql As String = "INSERT INTO Lop(MaLop, TenLop) VALUES(@MaLop, @TenLop)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        LoadData()
        MessageBox.Show("Thêm lớp thành công!")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaLop.Text = "" Then
            MessageBox.Show("Vui lòng chọn lớp cần sửa!")
            Return
        End If

        conn = New SqlConnection(connectionString)
        conn.Open()
        Dim sql As String = "UPDATE Lop SET TenLop = @TenLop WHERE MaLop = @MaLop"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        LoadData()
        MessageBox.Show("Cập nhật lớp thành công!")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaLop.Text = "" Then
            MessageBox.Show("Vui lòng chọn lớp cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            conn = New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "DELETE FROM Lop WHERE MaLop = @MaLop"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadData()
            MessageBox.Show("Xóa lớp thành công!")
        End If
    End Sub
End Class