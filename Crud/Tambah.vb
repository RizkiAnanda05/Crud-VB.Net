Public Class Tambah
    Public Aksi As String
    Dim SQL As String
    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_angkatan.Text = "" Or txt_nim.Text = "" Or txt_alamat.Text = "" Or txt_fakultas.Text = "" Or txt_jurusan.Text = "" Then
            MsgBox("Harap masukan semua data")
        Else
            Call koneksi()

            Try


                cmd.CommandType = CommandType.Text
                If Aksi = "Insert" Then
                    Sql = "INSERT INTO mahasiswa (nim,nama,fakultas,jurusan,angkatan,email,alamat) VALUES('" & txt_nim.Text & "'," &
                "'" & txt_nama.Text & "'," &
                "'" & txt_fakultas.Text & "'," &
                "'" & txt_jurusan.Text & "'," &
                "'" & txt_angkatan.Text & "'," &
                "'" & txt_email.Text & "'," &
                "'" & txt_alamat.Text & "')"
                Else

                    SQL = "UPDATE mahasiswa SET nama = " &
                "'" & txt_nama.Text & "', fakultas = " &
                "'" & txt_fakultas.Text & "', jurusan = " &
                "'" & txt_jurusan.Text & "', angkatan = " &
                "'" & txt_angkatan.Text & "', email = " &
                "'" & txt_email.Text & "', alamat = " &
                "'" & txt_alamat.Text & "' WHERE nim = '" & txt_nim.Text & "'"
                End If

                cmd.CommandText = SQL
                cmd.Connection = conn
                
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan", MsgBoxStyle.Information, "Informasi")

                conn.Close()
                Form1.showdata()


            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try


        End If
    End Sub
End Class