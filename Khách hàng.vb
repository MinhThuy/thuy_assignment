Imports System.Data
Imports System.Data.SqlClient
Public Class fromkhachang
    Dim ketnoi As New SqlConnection("Data Source=admin\sqlexpress;Initial Catalog=thuyntmpk0354;Integrated Security=True")
    Private Sub Loaddd()
        ketnoi.Open()
        Dim truyvan As New SqlCommand("select * from Khach_Hang", ketnoi)
        Dim adh As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        adh.Fill(table)
        ketnoi.Close()
        lstvkhachhang.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstvkhachhang.Items.Add(hang("Ma_khach_hang").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("Ten_KH").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("Dia_chi").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("SDT").ToString())
            i += 1
        Next
    End Sub
    Private Sub fromkhachang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddd()
    End Sub
    Private Function kiemtra() As Boolean
        If txttenkh.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng")
            Return False
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ")
            Return False
        ElseIf txtsodt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
            Return False
        End If
        Return True
    End Function

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If kiemtra() = True Then
            Try
                ketnoi.Open()
                Dim Ten_KH As String = txttenkh.Text
                Dim Dia_chi As String = txtdiachi.Text
                Dim SDT As String = txtsodt.Text
                Dim truyvan1 As New SqlCommand("insert into Khach_hang values (N'" + Ten_KH + "',N'" + Dia_chi + "',N'" + SDT + "')", ketnoi)
                truyvan1.ExecuteNonQuery()
                ketnoi.Close()
                MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loaddd()
            Catch ex As Exception
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        ketnoi.Open()
        Dim Ma_KH As String = txtmakh.Text
        Dim truyvan1 As New SqlCommand("delete from Khach_hang where Ma_khach_hang = '" + Ma_KH + "'", ketnoi)
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            truyvan1.ExecuteNonQuery()
            ketnoi.Close()
        Else
            ketnoi.Close()
        End If
        Loaddd()
    End Sub

    Private Sub lstvkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvkhachhang.SelectedIndexChanged
        For Each List As ListViewItem In lstvkhachhang.SelectedItems
            txtmakh.Text = List.SubItems(0).Text
            txttenkh.Text = List.SubItems(1).Text
            txtdiachi.Text = List.SubItems(2).Text
            txtsodt.Text = List.SubItems(3).Text
        Next
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        ketnoi.Open()
        Dim Ma As String = txtmakh.Text
        Dim Ten_khachhang As String = txttenkh.Text
        Dim Dia_chi As String = txtdiachi.Text
        Dim SDT As String = txtsodt.Text

        Dim truyvan2 As New SqlCommand("Update Khach_hang set Ten_KH=N'" + Ten_khachhang + "',Dia_chi=N'" + Dia_chi + "',So_dien_thoai= '" + SDT + "' where Ma_khach_hang = '" + Ma + "'", ketnoi)
        truyvan2.ExecuteNonQuery()
        ketnoi.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddd()
    End Sub
End Class