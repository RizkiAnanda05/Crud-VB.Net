<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nim = New System.Windows.Forms.TextBox()
        Me.txt_fakultas = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_jurusan = New System.Windows.Forms.TextBox()
        Me.txt_angkatan = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Input Update Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fakultas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Angkatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Alamat"
        '
        'txt_nim
        '
        Me.txt_nim.Location = New System.Drawing.Point(160, 68)
        Me.txt_nim.Name = "txt_nim"
        Me.txt_nim.Size = New System.Drawing.Size(100, 20)
        Me.txt_nim.TabIndex = 8
        '
        'txt_fakultas
        '
        Me.txt_fakultas.Location = New System.Drawing.Point(160, 114)
        Me.txt_fakultas.Name = "txt_fakultas"
        Me.txt_fakultas.Size = New System.Drawing.Size(100, 20)
        Me.txt_fakultas.TabIndex = 9
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(160, 91)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(174, 20)
        Me.txt_nama.TabIndex = 10
        '
        'txt_jurusan
        '
        Me.txt_jurusan.Location = New System.Drawing.Point(160, 138)
        Me.txt_jurusan.Name = "txt_jurusan"
        Me.txt_jurusan.Size = New System.Drawing.Size(100, 20)
        Me.txt_jurusan.TabIndex = 11
        '
        'txt_angkatan
        '
        Me.txt_angkatan.Location = New System.Drawing.Point(160, 161)
        Me.txt_angkatan.Name = "txt_angkatan"
        Me.txt_angkatan.Size = New System.Drawing.Size(100, 20)
        Me.txt_angkatan.TabIndex = 12
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(160, 183)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 13
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(160, 206)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(174, 43)
        Me.txt_alamat.TabIndex = 14
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(259, 307)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 15
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 342)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_angkatan)
        Me.Controls.Add(Me.txt_jurusan)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt_fakultas)
        Me.Controls.Add(Me.txt_nim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah"
        Me.Text = "Tambah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nim As System.Windows.Forms.TextBox
    Friend WithEvents txt_fakultas As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_jurusan As System.Windows.Forms.TextBox
    Friend WithEvents txt_angkatan As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
End Class
