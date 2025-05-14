Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
                MessageBox.Show("Login berhasil! Selamat datang, Admin")
                Me.Hide()
                HomeAdmin.Show()
                Exit Sub
            End If

            Module1.koneksi()

            Module1.CMD = New MySqlCommand("SELECT username, NomorHP FROM tbUsers WHERE username = @UserName AND password = @pw", Module1.CONN)
            Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
            Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

            Module1.RD = Module1.CMD.ExecuteReader()
            If Module1.RD.Read() Then
                GlobalVariables.Username = Module1.RD("username").ToString()
                GlobalVariables.nomor_hp_user = Convert.ToInt64(Module1.RD("NomorHP"))

                MessageBox.Show("Login berhasil! Selamat datang, " & GlobalVariables.Username)

                Me.Hide()
                HomeUser.Show()
            Else
                MessageBox.Show("Login gagal. Username atau password salah.")
            End If

            Module1.RD.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FMenu.Show()
    End Sub
End Class
