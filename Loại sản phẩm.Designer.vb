<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromloaisanpham
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.lstloaisanpham = New System.Windows.Forms.ListView()
        Me.clmaloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tên loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mô tả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã loại"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(391, 113)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(94, 20)
        Me.txtmota.TabIndex = 13
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(391, 75)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(94, 20)
        Me.txttenloai.TabIndex = 9
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(391, 39)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(94, 20)
        Me.txtmaloai.TabIndex = 7
        '
        'lstloaisanpham
        '
        Me.lstloaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmaloai, Me.cltenloai, Me.clmota})
        Me.lstloaisanpham.FullRowSelect = True
        Me.lstloaisanpham.GridLines = True
        Me.lstloaisanpham.Location = New System.Drawing.Point(12, 24)
        Me.lstloaisanpham.Name = "lstloaisanpham"
        Me.lstloaisanpham.Size = New System.Drawing.Size(318, 128)
        Me.lstloaisanpham.TabIndex = 8
        Me.lstloaisanpham.UseCompatibleStateImageBehavior = False
        Me.lstloaisanpham.View = System.Windows.Forms.View.Details
        '
        'clmaloai
        '
        Me.clmaloai.Text = "Mã loại"
        '
        'cltenloai
        '
        Me.cltenloai.Text = "Tên loại"
        Me.cltenloai.Width = 123
        '
        'clmota
        '
        Me.clmota.Text = "Mô tả"
        Me.clmota.Width = 125
        '
        'btnsua
        '
        Me.btnsua.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.edit
        Me.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnsua.Location = New System.Drawing.Point(241, 160)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(76, 26)
        Me.btnsua.TabIndex = 19
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.delete
        Me.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnxoa.Location = New System.Drawing.Point(132, 158)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(82, 28)
        Me.btnxoa.TabIndex = 20
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.BackgroundImage = Global.Assignment_thuyntmpk00354.My.Resources.Resources.icon
        Me.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnthem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthem.Location = New System.Drawing.Point(19, 160)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 26)
        Me.btnthem.TabIndex = 21
        Me.btnthem.Text = "Thêm "
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'fromloaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 189)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txttenloai)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.lstloaisanpham)
        Me.Name = "fromloaisanpham"
        Me.Text = "Phần mềm quản lí bán hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents lstloaisanpham As System.Windows.Forms.ListView
    Friend WithEvents clmaloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
End Class
