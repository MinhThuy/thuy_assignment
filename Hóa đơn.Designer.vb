<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromhoadon
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtngaytao = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtghichu = New System.Windows.Forms.TextBox()
        Me.txtchitiethoadon = New System.Windows.Forms.TextBox()
        Me.txtidkhachhang = New System.Windows.Forms.TextBox()
        Me.txtidhoadon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstV1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(323, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HÓA ĐƠN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.txtngaytao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttenkhachhang)
        Me.GroupBox1.Controls.Add(Me.txtghichu)
        Me.GroupBox1.Controls.Add(Me.txtchitiethoadon)
        Me.GroupBox1.Controls.Add(Me.txtidkhachhang)
        Me.GroupBox1.Controls.Add(Me.txtidhoadon)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 173)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP THÔNG TIN"
        '
        'btnsua
        '
        Me.btnsua.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.edit
        Me.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnsua.Location = New System.Drawing.Point(207, 137)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(78, 26)
        Me.btnsua.TabIndex = 6
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.delete
        Me.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnxoa.Location = New System.Drawing.Point(104, 138)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(85, 28)
        Me.btnxoa.TabIndex = 7
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.icon
        Me.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnthem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthem.Location = New System.Drawing.Point(6, 138)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(81, 26)
        Me.btnthem.TabIndex = 8
        Me.btnthem.Text = "Thêm "
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtngaytao
        '
        Me.txtngaytao.Location = New System.Drawing.Point(392, 35)
        Me.txtngaytao.Name = "txtngaytao"
        Me.txtngaytao.Size = New System.Drawing.Size(134, 20)
        Me.txtngaytao.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(300, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày tạo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(300, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tên khách hàng"
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(402, 114)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(134, 20)
        Me.txttenkhachhang.TabIndex = 2
        '
        'txtghichu
        '
        Me.txtghichu.Location = New System.Drawing.Point(397, 74)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(134, 20)
        Me.txtghichu.TabIndex = 2
        '
        'txtchitiethoadon
        '
        Me.txtchitiethoadon.Location = New System.Drawing.Point(112, 101)
        Me.txtchitiethoadon.Name = "txtchitiethoadon"
        Me.txtchitiethoadon.Size = New System.Drawing.Size(134, 20)
        Me.txtchitiethoadon.TabIndex = 2
        '
        'txtidkhachhang
        '
        Me.txtidkhachhang.Location = New System.Drawing.Point(109, 62)
        Me.txtidkhachhang.Name = "txtidkhachhang"
        Me.txtidkhachhang.Size = New System.Drawing.Size(137, 20)
        Me.txtidkhachhang.TabIndex = 2
        '
        'txtidhoadon
        '
        Me.txtidhoadon.Location = New System.Drawing.Point(109, 26)
        Me.txtidhoadon.Name = "txtidhoadon"
        Me.txtidhoadon.Size = New System.Drawing.Size(137, 20)
        Me.txtidhoadon.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(300, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Trạng thái"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(15, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Chi tiết HD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'LstV1
        '
        Me.LstV1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LstV1.FullRowSelect = True
        Me.LstV1.GridLines = True
        Me.LstV1.Location = New System.Drawing.Point(43, 229)
        Me.LstV1.Name = "LstV1"
        Me.LstV1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstV1.Size = New System.Drawing.Size(666, 223)
        Me.LstV1.TabIndex = 7
        Me.LstV1.UseCompatibleStateImageBehavior = False
        Me.LstV1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = " Mã Hóa Đơn"
        Me.ColumnHeader1.Width = 98
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã khách hàng"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mã CTHD"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 78
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ngày lập"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Trạng thái"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fromhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 464)
        Me.Controls.Add(Me.LstV1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fromhoadon"
        Me.Text = "Phần mềm quản lí bán hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtngaytao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtghichu As System.Windows.Forms.TextBox
    Friend WithEvents txtchitiethoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtidkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtidhoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstV1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
