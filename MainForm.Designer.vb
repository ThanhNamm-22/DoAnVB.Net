<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Label1 = New Label()
        btnQuanLySV = New Button()
        Button2 = New Button()
        btnQuanLyLop = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(144, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 28)
        Label1.TabIndex = 0
        Label1.Text = "Chào Mừng Bạn Đến Với Hệ Thống Quản Lý Sinh Viên"
        ' 
        ' btnQuanLySV
        ' 
        btnQuanLySV.Location = New Point(122, 107)
        btnQuanLySV.Name = "btnQuanLySV"
        btnQuanLySV.Size = New Size(213, 132)
        btnQuanLySV.TabIndex = 1
        btnQuanLySV.Text = "Quản Lý Sinh Viên"
        btnQuanLySV.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(322, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 66)
        Button2.TabIndex = 2
        Button2.Text = "Thoát"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnQuanLyLop
        ' 
        btnQuanLyLop.Location = New Point(486, 107)
        btnQuanLyLop.Name = "btnQuanLyLop"
        btnQuanLyLop.Size = New Size(213, 132)
        btnQuanLyLop.TabIndex = 3
        btnQuanLyLop.Text = "Quản Lý LỚp Học"
        btnQuanLyLop.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnQuanLyLop)
        Controls.Add(Button2)
        Controls.Add(btnQuanLySV)
        Controls.Add(Label1)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuanLySV As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnQuanLyLop As Button
End Class
