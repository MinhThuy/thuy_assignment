Imports System.Data
Imports System.Data.SqlClient
Public Class FromCTHD
    Dim ketnoi As New SqlConnection("Data Source=admin\sqlexpress;Initial Catalog=thuyntmpk0354;Integrated Security=True")

    Private Sub Loadll()
        ketnoi.Open()
        Dim truyvan As New SqlCommand("select Ma_CTHD,San_pham.Ma_sanpham,San_Pham.Ten_sanpham,San_Pham.Gia from Chi_Tiet_Hoa_Don join San_Pham on Chi_Tiet_Hoa_Don.Ma_SP=San_Pham.Ma_sanpham", ketnoi)
        Dim adn As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        adn.Fill(table)
        ketnoi.Close()
        LstV1.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            LstV1.Items.Add(hang("Ma_CTHD").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ma_sanpham").ToString())
            LstV1.Items(i).SubItems.Add(hang("Ten_sanpham").ToString())
            LstV1.Items(i).SubItems.Add(hang("Gia").ToString())
            LstV1.Items(i).SubItems.Add(hang("Mota").ToString())
            i += 1
        Next
    End Sub

    Private Sub FromCTHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadll()
    End Sub

    Private Sub LstV1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstV1.SelectedIndexChanged
        For Each List As ListViewItem In LstV1.SelectedItems
            txtchitiethd.Text = List.SubItems(0).Text
            txtsanpham.Text = List.SubItems(1).Text
            TextBox1.Text = List.SubItems(3).Text
            txtmota.Text = List.SubItems(4).Text

        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ketnoi.Open()
        Dim Ma_san_pham As String = txtsanpham.Text
        Dim Mo_ta As String = txtmota.Text
        Dim Gia As DateTime = TextBox1.Text
        Dim truyvan1 As New SqlCommand("insert into Chi_Tiet_Hoa_Don (Ma_san_pham,Gia,Mo_ta) values ('" + Ma_san_pham + "','" + Gia + "','" + Mo_ta + "')", ketnoi)
        truyvan1.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loadll()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            ketnoi.Open()
            Dim ID As String = txtchitiethd.Text
            Dim truyvan1 As New SqlCommand("delete from Hoa_Don where Ma_Hoa_don = '" + ID + "'", ketnoi)
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
            Else
                ketnoi.Close()
            End If
            Loadll()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        btnsua.Enabled = False
        btnxoa.Enabled = False
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        ketnoi.Open()
        Dim ID As String = txtchitiethd.Text
        Dim ma_san_pham As String = txtsanpham.Text
        Dim Gia As String = TextBox1.Text
        Dim Mota As String = txtmota.Text

        Dim truyvan2 As New SqlCommand("Update Chi_Tiet_Hoa_Don set Ma_chi_tiet_hoa_don ='" + ID + "',Ma_san_pham='" + ma_san_pham + "',Mo_ta='" + Mota + "'", ketnoi)
        truyvan2.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loadll()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class