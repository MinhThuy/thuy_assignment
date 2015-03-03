Imports System.Data
Imports System.Data.SqlClient
Public Class fromloaisanpham
    Dim ketnoi As New SqlConnection("Data Source=admin\sqlexpress;Initial Catalog=thuyntmpk0354;Integrated Security=True")
    Private Sub lstloaisanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstloaisanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstloaisanpham.SelectedItems
            txtmaloai.Text = List.SubItems(0).Text
            txttenloai.Text = List.SubItems(1).Text
            txtmota.Text = List.SubItems(2).Text
        Next
    End Sub
    Private Sub Loaddl()
        ketnoi.Open()
        Dim truyvan As New SqlCommand("select * from Loai_San_Pham", ketnoi)
        Dim adc As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        adc.Fill(table)
        ketnoi.Close()
        lstloaisanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstloaisanpham.Items.Add(hang("MaLSP").ToString())
            lstloaisanpham.Items(i).SubItems.Add(hang("Ten_loai").ToString())
            lstloaisanpham.Items(i).SubItems.Add(hang("Mo_ta").ToString())
            i += 1
        Next
    End Sub
    Private Sub fromloaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddl()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            ketnoi.Open()
            Dim Ma As String = txtmaloai.Text
            Dim truyvan1 As New SqlCommand("delete from Loai_san_pham where Ma_loai_san_pham = '" + Ma + "'", ketnoi)
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
            Else
                ketnoi.Close()
            End If
            Loaddl()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        btnsua.Enabled = False
        btnxoa.Enabled = False


    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ketnoi.Open()
        Dim Tenloai As String = txttenloai.Text
        Dim mota As String = txtmota.Text
        Dim truyvan1 As New SqlCommand("insert into Loai_san_pham values (N'" + Tenloai + "',N'" + mota + "')", ketnoi)
        truyvan1.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddl()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        ketnoi.Open()
        Dim ID As String = txtmaloai.Text
        Dim Tenloai As String = txttenloai.Text
        Dim mota As String = txtmota.Text
        Dim truyvan2 As New SqlCommand("Update Loai_san_pham set Ten_loai=N'" + Tenloai + "',Mo_ta=N'" + mota + "'where Ma_loai_san_pham='" + Ma + "'", ketnoi)
        truyvan2.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddl()
    End Sub

    Private Function Ma() As String
        Throw New NotImplementedException
    End Function

  
End Class