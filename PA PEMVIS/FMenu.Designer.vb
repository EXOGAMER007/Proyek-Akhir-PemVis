﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BtnDaftar = New Button()
        BtnLogin = New Button()
        Label4 = New Label()
        BtnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(7, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 35)
        Label1.TabIndex = 0
        Label1.Text = "SihCepat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(187, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 57)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 Hv BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(36, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(290, 77)
        Label3.TabIndex = 2
        Label3.Text = "Selamat"
        ' 
        ' BtnDaftar
        ' 
        BtnDaftar.BackColor = Color.White
        BtnDaftar.Cursor = Cursors.Hand
        BtnDaftar.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnDaftar.FlatAppearance.BorderSize = 0
        BtnDaftar.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnDaftar.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnDaftar.FlatStyle = FlatStyle.Flat
        BtnDaftar.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDaftar.ForeColor = Color.DarkGoldenrod
        BtnDaftar.Location = New Point(425, 169)
        BtnDaftar.Name = "BtnDaftar"
        BtnDaftar.Size = New Size(200, 55)
        BtnDaftar.TabIndex = 5
        BtnDaftar.Text = "Daftar"
        BtnDaftar.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.White
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.LemonChiffon
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnLogin.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.DarkGoldenrod
        BtnLogin.Location = New Point(425, 249)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(200, 55)
        BtnLogin.TabIndex = 6
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Swis721 Hv BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(36, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(281, 77)
        Label4.TabIndex = 7
        Label4.Text = "Datang!"
        ' 
        ' BtnExit
        ' 
        BtnExit.BackgroundImage = My.Resources.Resources.Desain_tanpa_judul__14_
        BtnExit.BackgroundImageLayout = ImageLayout.Zoom
        BtnExit.Cursor = Cursors.Hand
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Location = New Point(716, 11)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(35, 35)
        BtnExit.TabIndex = 8
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' FMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__3_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(BtnExit)
        Controls.Add(Label4)
        Controls.Add(BtnLogin)
        Controls.Add(BtnDaftar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "FMenu"
        Text = "Fmenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnExit As Button

End Class
