Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click

        Tambah.Show()
        Tambah.Aksi = "Insert"

    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
    Sub showdata()
        Try
            datatable.Clear()
            koneksi()
            cmd.CommandText = "SELECT * FROM mahasiswa"
            cmd.Connection = conn

            myadapter.SelectCommand = cmd

            myadapter.Fill(datatable)
            dgv_datamahasiswa.DataSource = datatable
            dgv_datamahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            cmd.Dispose()
            myadapter.Dispose()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        Finally
            Try
                If Module1.conn.State = ConnectionState.Open Then
                    Module1.conn.Close()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myadapter.Dispose()
        showdata()


    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Dim Dialog
        Dialog = MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If Dialog = vbYes Then
            Try
                Call koneksi()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM mahasiswa WHERE nim = '" & Tambah.txt_nim.Text & "'"
                cmd.ExecuteNonQuery()

                conn.Close()
                showdata()
                MessageBox.Show("Berhasil Menghapus Data", "Berhasil Di hapus")

            Catch ex As Exception

            End Try
            
        End If
    End Sub




    Private Sub dgv_datamahasiswa_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datamahasiswa.CellContentClick
        Dim i As Integer

        i = dgv_datamahasiswa.CurrentRow.Index
        Tambah.txt_nim.Text = dgv_datamahasiswa.Item(0, i).Value
        Tambah.txt_nama.Text = dgv_datamahasiswa.Item(1, i).Value
        Tambah.txt_fakultas.Text = dgv_datamahasiswa.Item(2, i).Value
        Tambah.txt_jurusan.Text = dgv_datamahasiswa.Item(3, i).Value
        Tambah.txt_angkatan.Text = dgv_datamahasiswa.Item(4, i).Value
        Tambah.txt_email.Text = dgv_datamahasiswa.Item(5, i).Value
        Tambah.txt_alamat.Text = dgv_datamahasiswa.Item(6, i).Value
        
        Tambah.Aksi = "Update"
        Tambah.txt_nim.Enabled = False
        Tambah.Show()
    End Sub
End Class
