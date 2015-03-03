<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fromqlbanhang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Txtmota = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.Txttensanpham = New System.Windows.Forms.TextBox()
        Me.Txtloaisanpham = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidsanpham = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstsanpham = New System.Windows.Forms.ListView()
        Me.clID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltensanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.Txtmota)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.Txttensanpham)
        Me.GroupBox1.Controls.Add(Me.Txtloaisanpham)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidsanpham)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(24, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 335)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP THÔNG TIN"
        '
        'btnsua
        '
        Me.btnsua.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.edit
        Me.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnsua.Location = New System.Drawing.Point(226, 262)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(76, 26)
        Me.btnsua.TabIndex = 13
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.delete
        Me.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnxoa.Location = New System.Drawing.Point(118, 262)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(82, 28)
        Me.btnxoa.TabIndex = 14
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.icon
        Me.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnthem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthem.Location = New System.Drawing.Point(4, 262)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 26)
        Me.btnthem.TabIndex = 15
        Me.btnthem.Text = "Thêm "
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Txtmota
        '
        Me.Txtmota.Location = New System.Drawing.Point(107, 180)
        Me.Txtmota.Name = "Txtmota"
        Me.Txtmota.Size = New System.Drawing.Size(195, 20)
        Me.Txtmota.TabIndex = 4
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(107, 221)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(195, 20)
        Me.txtgia.TabIndex = 5
        '
        'Txttensanpham
        '
        Me.Txttensanpham.Location = New System.Drawing.Point(107, 94)
        Me.Txttensanpham.Name = "Txttensanpham"
        Me.Txttensanpham.Size = New System.Drawing.Size(195, 20)
        Me.Txttensanpham.TabIndex = 2
        '
        'Txtloaisanpham
        '
        Me.Txtloaisanpham.Location = New System.Drawing.Point(107, 135)
        Me.Txtloaisanpham.Name = "Txtloaisanpham"
        Me.Txtloaisanpham.Size = New System.Drawing.Size(195, 20)
        Me.Txtloaisanpham.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã sản phẩm"
        '
        'txtidsanpham
        '
        Me.txtidsanpham.Location = New System.Drawing.Point(107, 49)
        Me.txtidsanpham.Name = "txtidsanpham"
        Me.txtidsanpham.Size = New System.Drawing.Size(195, 20)
        Me.txtidsanpham.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(11, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(13, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(11, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loại sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(11, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mô tả"
        '
        'lstsanpham
        '
        Me.lstsanpham.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clID, Me.cltensanpham, Me.clloaisanpham, Me.cltenloai, Me.clmota, Me.clgia})
        Me.lstsanpham.FullRowSelect = True
        Me.lstsanpham.GridLines = True
        Me.lstsanpham.Location = New System.Drawing.Point(347, 82)
        Me.lstsanpham.Name = "lstsanpham"
        Me.lstsanpham.Size = New System.Drawing.Size(462, 335)
        Me.lstsanpham.TabIndex = 10
        Me.lstsanpham.UseCompatibleStateImageBehavior = False
        Me.lstsanpham.View = System.Windows.Forms.View.Details
        '
        'clID
        '
        Me.clID.Text = "Mã Sản Phẩm"
        Me.clID.Width = 82
        '
        'cltensanpham
        '
        Me.cltensanpham.Text = "Tên sản phẩm"
        Me.cltensanpham.Width = 116
        '
        'clloaisanpham
        '
        Me.clloaisanpham.Text = "Mã loại"
        Me.clloaisanpham.Width = 79
        '
        'cltenloai
        '
        Me.cltenloai.Text = "Tên loại"
        Me.cltenloai.Width = 90
        '
        'clmota
        '
        Me.clmota.Text = "Mô tả"
        Me.clmota.Width = 106
        '
        'clgia
        '
        Me.clgia.Text = "Giá"
        Me.clgia.Width = 157
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(296, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SẢN PHẨM"
        '
        'Fromqlbanhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstsanpham)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Fromqlbanhang"
        Me.Text = "Phần mềm quản lí bán hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents Txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents Txtloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidsanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstsanpham As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltensanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clloaisanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents clgia As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
