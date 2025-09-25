
Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Public Class quanlysinhvien

    Dim connectionString As String = "Data Source=LAPTOP-J6E59HOB\SQLEXPRESS;Initial Catalog=QLSinhVien;Encrypt=False;TrustServerCertificate=True;Integrated Security=True"
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim cmd As SqlCommand

    Private Function KiemTraThongTin() As Boolean
        If String.IsNullOrWhiteSpace(txtMaSV.Text) OrElse
       String.IsNullOrWhiteSpace(txtHoTen.Text) OrElse
       String.IsNullOrWhiteSpace(cboGioiTinh.Text) OrElse
       String.IsNullOrWhiteSpace(txtDiaChi.Text) OrElse
       String.IsNullOrWhiteSpace(txtMaLop.Text) Then

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Dim regex As New Regex("^[\p{L}\s]+$")

        If Not regex.IsMatch(txtHoTen.Text) Then
            MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not regex.IsMatch(txtDiaChi.Text) Then
            MessageBox.Show("Địa chỉ chỉ được chứa chữ cái và khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub LoadData()
        Try
            conn = New SqlConnection(connectionString)
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM SinhVien", conn)
            dt = New DataTable()
            da.Fill(dt)
            dgvSinhVien.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub quanlysinhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        dtNgaySinh.Format = DateTimePickerFormat.Custom
        dtNgaySinh.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            If Not KiemTraThongTin() Then Exit Sub

            conn = New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop) 
                                 VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtNgaySinh.Value))
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadData()
            MessageBox.Show("Thêm sinh viên thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            If Not KiemTraThongTin() Then Exit Sub
            Using conn = New SqlConnection(connectionString)
                conn.Open()
                Dim sql As String = "UPDATE SinhVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, MaLop=@MaLop " &
                                    "WHERE MaSV=@MaSV"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtNgaySinh.Value))
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
            MessageBox.Show("Sửa sinh viên thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi sửa: " & ex.Message)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            If Not KiemTraThongTin() Then Exit Sub
            Using conn = New SqlConnection(connectionString)
                conn.Open()
                Dim sql As String = "DELETE FROM SinhVien WHERE MaSV=@MaSV"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
            MessageBox.Show("Xóa sinh viên thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadData()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            If Not KiemTraThongTin() Then Exit Sub
            Using conn = New SqlConnection(connectionString)
                conn.Open()
                ' Ví dụ tìm theo tên hoặc mã lớp hoặc mã sv
                Dim sql As String = "SELECT * FROM SinhVien WHERE HoTen LIKE @key OR MaSV LIKE @key OR MaLop LIKE @key"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@key", "%" & txtTimKiem.Text & "%")
                    Dim da2 As New SqlDataAdapter(cmd)
                    Dim dt2 As New DataTable()
                    da2.Fill(dt2)
                    dgvSinhVien.DataSource = dt2
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi tìm kiếm: " & ex.Message)
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
