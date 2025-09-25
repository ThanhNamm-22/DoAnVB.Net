<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quanlysinhvien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtMaSV = New TextBox()
        txtHoTen = New TextBox()
        txtDiaChi = New TextBox()
        dgvSinhVien = New DataGridView()
        Label8 = New Label()
        txtTimKiem = New TextBox()
        dtNgaySinh = New DateTimePicker()
        cboGioiTinh = New ComboBox()
        btnThem = New Button()
        btnSua = New Button()
        btnLoad = New Button()
        btnXoa = New Button()
        btnTimKiem = New Button()
        btnThoat = New Button()
        txtMaLop = New ComboBox()
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(287, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 23)
        Label1.TabIndex = 0
        Label1.Text = "QUẢN LÝ SINH VIÊN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mã SV"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 2
        Label3.Text = "Họ Tên "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 3
        Label4.Text = "Ngày Sinh "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 4
        Label5.Text = "Giới Tính "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 5
        Label6.Text = "Địa Chỉ"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(40, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 20)
        Label7.TabIndex = 6
        Label7.Text = "Mã Lớp"
        ' 
        ' txtMaSV
        ' 
        txtMaSV.Location = New Point(107, 79)
        txtMaSV.Name = "txtMaSV"
        txtMaSV.Size = New Size(175, 27)
        txtMaSV.TabIndex = 7
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(106, 112)
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(175, 27)
        txtHoTen.TabIndex = 8
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(118, 240)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(164, 27)
        txtDiaChi.TabIndex = 10
        ' 
        ' dgvSinhVien
        ' 
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSinhVien.Location = New Point(339, 152)
        dgvSinhVien.Name = "dgvSinhVien"
        dgvSinhVien.RowHeadersWidth = 51
        dgvSinhVien.Size = New Size(436, 276)
        dgvSinhVien.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(373, 86)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 20)
        Label8.TabIndex = 13
        Label8.Text = "Tên"
        ' 
        ' txtTimKiem
        ' 
        txtTimKiem.Location = New Point(439, 82)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.Size = New Size(175, 27)
        txtTimKiem.TabIndex = 14
        ' 
        ' dtNgaySinh
        ' 
        dtNgaySinh.Location = New Point(107, 157)
        dtNgaySinh.Name = "dtNgaySinh"
        dtNgaySinh.Size = New Size(175, 27)
        dtNgaySinh.TabIndex = 15
        ' 
        ' cboGioiTinh
        ' 
        cboGioiTinh.FormattingEnabled = True
        cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        cboGioiTinh.Location = New Point(118, 198)
        cboGioiTinh.Name = "cboGioiTinh"
        cboGioiTinh.Size = New Size(163, 28)
        cboGioiTinh.TabIndex = 16
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(47, 325)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(88, 40)
        btnThem.TabIndex = 17
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(141, 325)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(88, 40)
        btnSua.TabIndex = 18
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(73, 371)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(89, 40)
        btnLoad.TabIndex = 19
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(245, 325)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(88, 40)
        btnXoa.TabIndex = 20
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Location = New Point(660, 82)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(70, 29)
        btnTimKiem.TabIndex = 21
        btnTimKiem.Text = "Search"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(194, 371)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(88, 40)
        btnThoat.TabIndex = 22
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' txtMaLop
        ' 
        txtMaLop.FormattingEnabled = True
        txtMaLop.Items.AddRange(New Object() {"L01", "L02", "L03"})
        txtMaLop.Location = New Point(119, 280)
        txtMaLop.Name = "txtMaLop"
        txtMaLop.Size = New Size(163, 28)
        txtMaLop.TabIndex = 23
        ' 
        ' quanlysinhvien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMaLop)
        Controls.Add(btnThoat)
        Controls.Add(btnTimKiem)
        Controls.Add(btnXoa)
        Controls.Add(btnLoad)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(cboGioiTinh)
        Controls.Add(dtNgaySinh)
        Controls.Add(txtTimKiem)
        Controls.Add(Label8)
        Controls.Add(dgvSinhVien)
        Controls.Add(txtDiaChi)
        Controls.Add(txtHoTen)
        Controls.Add(txtMaSV)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "quanlysinhvien"
        Text = "quanlysinhvien"
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dtNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtMaLop As ComboBox

End Class
