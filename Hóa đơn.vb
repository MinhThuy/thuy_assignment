Imports System.Data
Imports System.Data.SqlClient
Public Class fromhoadon
    Dim ketnoi As New SqlConnection("Data Source=admin\sqlexpress;Initial Catalog=thuyntmpk0354;Integrated Security=True")
    Private Sub fromhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadh()
    End Sub
    Private Sub Loadh()
        ketnoi.Open()
        Dim truyvan As New SqlCommand("select Ma_Hoa_don,Hoa_don.Ma_Khachhang,Ma_CTHD,Ngaylap,Trangthai,Ten_KH from Hoa_Don join Khach_Hang on Hoa_Don.Ma_Khachhang=Khach_Hang.Ma_khach_hang", ketnoi)
        Dim ads As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ads.Fill(table)
        ketnoi.Close()
        LstV1.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            LstV1.Items.Add(hang("Ma_Hoa_don").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ma_Khachhang").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ma_CTHD").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ngaylap").ToString())
            LstV1.Items(i).SubItems.Add(hang("Trangthai").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ten_KH").ToString())
            i += 1
        Next
    End Sub

    Private Sub LstV1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstV1.SelectedIndexChanged
        For Each List As ListViewItem In LstV1.SelectedItems
            txtidhoadon.Text = List.SubItems(0).Text
            txtidkhachhang.Text = List.SubItems(1).Text
            txtchitiethoadon.Text = List.SubItems(2).Text
            txtngaytao.Text = List.SubItems(3).Text
            txtghichu.Text = List.SubItems(4).Text
            txttenkhachhang.Text = List.SubItems(5).Text
        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ketnoi.Open()
        Dim Ma_khach_hang As String = txtidkhachhang.Text
        Dim ID_chi_tiet_hd As String = txtchitiethoadon.Text
        Dim Ngay As DateTime = txtngaytao.Text
        Dim Ghi_chu As String = txtghichu.Text
        Dim truyvan1 As New SqlCommand("insert into Hoa_Don (Ma_khach_hang,Ma_Khac_Hang,Ngay,Ghi_chu) values ('" + Ma_khach_hang + "','" + Ma_khach_hang + "','" + Ngay + "',N'" + Ghi_chu + "')", ketnoi)
        truyvan1.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loadh()

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            ketnoi.Open()
            Dim ID As String = txtidhoadon.Text
            Dim truyvan1 As New SqlCommand("delete from Hoa_Don where ID_Hoa_don = '" + ID + "'", ketnoi)
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
            Else
                ketnoi.Close()
            End If
            Loadh()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        btnsua.Enabled = False
        btnxoa.Enabled = False
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            ketnoi.Open()
            Dim Ma As String = txtidhoadon.Text
            Dim Ma_khachhang As String = txtidkhachhang.Text
            Dim Ma_CTHD As String = txtchitiethoadon.Text
            Dim ngaylap As DateTime = txtngaytao.Text
            Dim Trangthai As String = txtghichu.Text
            Dim truyvan2 As New SqlCommand("Update Hoa_Don set Ma_khach_hang='" + Ma_khachhang + "',Ma_chi_tiet_hd='" + Ma_CTHD + "',Ngay='" + ngaylap + "',Ghi_chu='" + Trangthai + "' where Ma_Hoa_don='" + Ma + "'", ketnoi)
            truyvan2.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loadh()
        Catch ex As Exception
            MessageBox.Show("Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
End Class