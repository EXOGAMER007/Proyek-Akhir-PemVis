Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form_input_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form_input_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = DaftarUser.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PeriksaKosongFormLogin() Then
            Try
                If GlobalVariables.AkunAdmin(0, 0) = CStr(83110940598) And txtPassword.Text = "daffa" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Daffa")
                    Me.Close()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf GlobalVariables.AkunAdmin(1, 0) = CStr(81346531543) And txtPassword.Text = "ayya" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Ayya")
                    Me.Close()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf GlobalVariables.AkunAdmin(2, 0) = CStr(81244746892) And txtPassword.Text = "rehan" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Rayhan")
                    Me.Close()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                Else
                    Module1.koneksi()

                    Module1.CMD = New MySqlCommand("SELECT username, NomorHP FROM tbUsers WHERE NomorHP = @UserName AND password = @pw", Module1.CONN)
                    Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
                    Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

                    Module1.RD = Module1.CMD.ExecuteReader()
                    If Module1.RD.Read() Then
                        GlobalVariables.Username = Module1.RD("username").ToString()
                        GlobalVariables.nomor_hp_user = Convert.ToInt64(Module1.RD("NomorHP"))

                        MessageBox.Show("Login berhasil! Selamat datang, " & GlobalVariables.Username)

                        Me.Close()
                        HomeUser.Show()
                        KosongkanForm()
                    Else
                        MessageBox.Show("Login gagal. Username atau password salah.")
                    End If
                    Module1.RD.Close()
                End If


            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message)
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub KosongkanForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
        FMenu.Show()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        txtUsername.MaxLength = 50
        Module1.HanyaAngka(e)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.MaxLength = 50
    End Sub

    Function PeriksaKosongFormLogin() As Boolean
        If txtUsername.Text = "" Then
            MessageBox.Show("username harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("password harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LihatPass_Click(sender As Object, e As EventArgs) Handles LihatPass.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__13_
        Else
            txtPassword.PasswordChar = "*"
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
        GlobalVariables.AkunAdmin(0, 0) = "83110940598"
        GlobalVariables.AkunAdmin(0, 1) = "daffa"
        GlobalVariables.AkunAdmin(1, 0) = "81346531543"
        GlobalVariables.AkunAdmin(1, 1) = "ayya"
        GlobalVariables.AkunAdmin(2, 0) = "81244746892"
        GlobalVariables.AkunAdmin(2, 1) = "rehan"
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtPassword.PasswordChar = "*"
        LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
    End Sub
End Class
