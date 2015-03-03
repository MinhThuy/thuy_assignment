<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromkhachang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lstvkhachhang = New System.Windows.Forms.ListView()
        Me.clmakh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cldiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsodt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtsodt)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.txttenkh)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Location = New System.Drawing.Point(404, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 297)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin"
        '
        'btnsua
        '
        Me.btnsua.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.edit
        Me.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnsua.Location = New System.Drawing.Point(237, 232)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(76, 26)
        Me.btnsua.TabIndex = 16
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.delete
        Me.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnxoa.Location = New System.Drawing.Point(128, 230)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(82, 28)
        Me.btnxoa.TabIndex = 17
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.icon
        Me.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnthem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthem.Location = New System.Drawing.Point(15, 232)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 26)
        Me.btnthem.TabIndex = 18
        Me.btnthem.Text = "Thêm "
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(17, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Số điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(17, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(17, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã khách hàng"
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(149, 180)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(164, 20)
        Me.txtsodt.TabIndex = 4
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(149, 132)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(164, 20)
        Me.txtdiachi.TabIndex = 3
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(149, 88)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(164, 20)
        Me.txttenkh.TabIndex = 2
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(149, 45)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(164, 20)
        Me.txtmakh.TabIndex = 1
        '
        'lstvkhachhang
        '
        Me.lstvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmakh, Me.cltenkh, Me.cldiachi, Me.clsodt})
        Me.lstvkhachhang.FullRowSelect = True
        Me.lstvkhachhang.GridLines = True
        Me.lstvkhachhang.Location = New System.Drawing.Point(12, 23)
        Me.lstvkhachhang.Name = "lstvkhachhang"
        Me.lstvkhachhang.Size = New System.Drawing.Size(376, 297)
        Me.lstvkhachhang.TabIndex = 4
        Me.lstvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lstvkhachhang.View = System.Windows.Forms.View.Details
        '
        'clmakh
        '
        Me.clmakh.Text = "Mã khách hàng"
        Me.clmakh.Width = 88
        '
        'cltenkh
        '
        Me.cltenkh.Text = "Tên khách hàng"
        Me.cltenkh.Width = 93
        '
        'cldiachi
        '
        Me.cldiachi.Text = "Địa chỉ"
        Me.cldiachi.Width = 99
        '
        'clsodt
        '
        Me.clsodt.Text = "Số điện thoại"
        Me.clsodt.Width = 118
        '
        'fromkhachang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvkhachhang)
        Me.Name = "fromkhachang"
        Me.Text = "Phần Mềm quản lí bán hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lstvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents clmakh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cldiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clsodt As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
End Class
