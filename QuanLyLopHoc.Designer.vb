<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyLopHoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTenLop = New Label()
        txtMaLop = New Label()
        txtMaSV = New TextBox()
        TextBox1 = New TextBox()
        dgvLop = New DataGridView()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        CType(dgvLop, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTenLop
        ' 
        txtTenLop.AutoSize = True
        txtTenLop.Location = New Point(89, 141)
        txtTenLop.Name = "txtTenLop"
        txtTenLop.Size = New Size(58, 20)
        txtTenLop.TabIndex = 2
        txtTenLop.Text = "Tên lớp"
        ' 
        ' txtMaLop
        ' 
        txtMaLop.AutoSize = True
        txtMaLop.Location = New Point(89, 84)
        txtMaLop.Name = "txtMaLop"
        txtMaLop.Size = New Size(56, 20)
        txtMaLop.TabIndex = 3
        txtMaLop.Text = "Mã lớp"
        ' 
        ' txtMaSV
        ' 
        txtMaSV.Location = New Point(159, 84)
        txtMaSV.Name = "txtMaSV"
        txtMaSV.Size = New Size(175, 27)
        txtMaSV.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(159, 138)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 27)
        TextBox1.TabIndex = 9
        ' 
        ' dgvLop
        ' 
        dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLop.Location = New Point(352, 84)
        dgvLop.Name = "dgvLop"
        dgvLop.RowHeadersWidth = 51
        dgvLop.Size = New Size(436, 276)
        dgvLop.TabIndex = 13
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(67, 183)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(88, 40)
        btnThem.TabIndex = 18
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(222, 183)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(88, 40)
        btnSua.TabIndex = 19
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(143, 229)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(88, 40)
        btnXoa.TabIndex = 21
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' QuanLyLopHoc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(dgvLop)
        Controls.Add(TextBox1)
        Controls.Add(txtMaSV)
        Controls.Add(txtMaLop)
        Controls.Add(txtTenLop)
        Name = "QuanLyLopHoc"
        Text = "QuanLyLopHoc"
        CType(dgvLop, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTenLop As Label
    Friend WithEvents txtMaLop As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvLop As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
End Class
