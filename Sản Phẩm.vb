Imports System.Data
Imports System.Data.SqlClient
Public Class Fromqlbanhang
    Dim ketnoi As New SqlConnection("Data Source=admin\sqlexpress;Initial Catalog=thuyntmpk0354;Integrated Security=True")
    Private Sub Loadg()
        ketnoi.Open()
        Dim truyvan As New SqlCommand("select Ma_sanpham,Ten_sanpham,San_Pham.Loai_Sanpham,Ten_loai,San_pham.Mo_ta,Gia from San_Pham join Loai_san_pham on San_Pham.Loai_Sanpham=Loai_San_Pham.MaLSP", ketnoi)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoi.Close()
        lstsanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstsanpham.Items.Add(hang("Ma_sanpham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Ten_sanpham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Loai_Sanpham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Ten_loai").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Mo_ta").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Gia").ToString())
            i += 1
        Next
    End Sub
    Private Sub Fromqlbanhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadg()
    End Sub

    Private Sub lstsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstsanpham.SelectedItems
            txtidsanpham.Text = List.SubItems(0).Text
            Txttensanpham.Text = List.SubItems(1).Text
            Txtloaisanpham.Text = List.SubItems(2).Text
            Txtmota.Text = List.SubItems(4).Text
            txtgia.Text = List.SubItems(5).Text
        Next
    End Sub
    Private Function kiemtra() As Boolean
        If Txttensanpham.Text = "" Then
            MessageBox.Show("Chưa nhập tên sản phẩm")
            Return False
        ElseIf Txtloaisanpham.Text = "" Then
            MessageBox.Show("Chưa nhập loại sản phẩm")
            Return False
        ElseIf txtgia.Text = "" Then
            MessageBox.Show("Chưa nhập giá sản phẩm")
            Return False
        End If
        Return True
    End Function

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            ketnoi.Open()
            Dim Ma As String = txtidsanpham.Text
            Dim truyvan1 As New SqlCommand("delete from San_pham where Ma_san_pham = '" + Ma + "'", ketnoi)
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
            Else
                ketnoi.Close()
            End If
            Loadg()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        btnsua.Enabled = False
        btnxoa.Enabled = False
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        ketnoi.Open()
        Dim Ma As String = txtidsanpham.Text
        Dim Ten_san_pham As String = Txttensanpham.Text
        Dim Ma_Loai_san_pham As String = Txtloaisanpham.Text
        Dim Mo_ta As String = Txtmota.Text
        Dim Gia As String = txtgia.Text
        Dim truyvan2 As New SqlCommand("Update San_pham set Ten_san_pham='" + Ten_san_pham + "',Ma_Loai_san_pham='" + Ma_Loai_san_pham + "',Mo_ta= N'" + Mo_ta + "',Gia='" + Gia + "' where Ma_sanpham='" + Ma + "'", ketnoi)
        truyvan2.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loadg()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If kiemtra() = True Then
            Try
                ketnoi.Open()
                Dim Ten_san_pham As String = Txttensanpham.Text
                Dim Ma_Loai_san_pham As String = Txtloaisanpham.Text
                Dim Mo_ta As String = Txtmota.Text
                Dim Gia As String = txtgia.Text
                Dim truyvan1 As New SqlCommand("insert into San_pham (Ten_sanpham,Ma_LSP,Mo_ta,Gia) values (N'" + Ten_san_pham + "',N'" + Ma_Loai_san_pham + "',N'" + Mo_ta + "','" + Gia + "')", ketnoi)
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
                MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loadg()
            Catch ex As Exception
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class