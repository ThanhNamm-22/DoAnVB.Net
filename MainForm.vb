Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuanLySV_Click(sender As Object, e As EventArgs) Handles btnQuanLySV.Click
        Dim f As New quanlysinhvien()
        f.ShowDialog()
    End Sub

    Private Sub btnQuanLyLop_Click(sender As Object, e As EventArgs) Handles btnQuanLyLop.Click
        Dim f As New QuanLyLopHoc()
        f.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class