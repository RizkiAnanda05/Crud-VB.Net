<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_datamahasiswa = New System.Windows.Forms.DataGridView()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_datamahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Mahasiswa"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_datamahasiswa)
        Me.Panel1.Location = New System.Drawing.Point(59, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 188)
        Me.Panel1.TabIndex = 1
        '
        'dgv_datamahasiswa
        '
        Me.dgv_datamahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datamahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_datamahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.dgv_datamahasiswa.Name = "dgv_datamahasiswa"
        Me.dgv_datamahasiswa.Size = New System.Drawing.Size(533, 188)
        Me.dgv_datamahasiswa.TabIndex = 0
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(355, 278)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 3
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(436, 278)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 3
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(517, 278)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 4
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 335)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mahasiswa"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_datamahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv_datamahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button

End Class
