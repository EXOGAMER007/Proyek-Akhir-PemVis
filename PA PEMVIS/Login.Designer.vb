<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        BtnKembali = New Button()
        BtnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        LihatPass = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(629, 457)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 33)
        Label1.TabIndex = 14
        Label1.Text = "SihCepat"
        ' 
        ' Button1
        ' 
        BtnKembali.BackColor = Color.Transparent
        BtnKembali.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        BtnKembali.BackgroundImageLayout = ImageLayout.Zoom
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.ForeColor = Color.Transparent
        BtnKembali.Location = New Point(10, 6)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 44)
        BtnKembali.TabIndex = 13
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.DarkGoldenrod
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(328, 298)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(320, 35)
        BtnLogin.TabIndex = 17
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Swis721 Cn BT", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(328, 187)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(320, 29)
        txtUsername.TabIndex = 16
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Swis721 Cn BT", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(328, 251)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(320, 29)
        txtPassword.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(328, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 24)
        Label2.TabIndex = 18
        Label2.Text = "Nomor HP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(328, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 19
        Label3.Text = "Password"
        ' 
        ' LihatPass
        ' 
        LihatPass.BackgroundImage = My.Resources.Resources.Desain_tanpa_judul__11_
        LihatPass.BackgroundImageLayout = ImageLayout.Zoom
        LihatPass.FlatAppearance.BorderSize = 0
        LihatPass.FlatStyle = FlatStyle.Flat
        LihatPass.Location = New Point(612, 287)
        LihatPass.Name = "LihatPass"
        LihatPass.Size = New Size(28, 28)
        LihatPass.TabIndex = 20
        LihatPass.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Swis721 Cn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(326, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 21
        Label4.Text = "+62"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(Label4)
        Controls.Add(LihatPass)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnLogin)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(BtnKembali)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LihatPass As Button
    Friend WithEvents Label4 As Label
End Class
