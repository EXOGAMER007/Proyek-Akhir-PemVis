﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjukanPijaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjukanPijaman))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lbNama_Pengajuan = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lbNomor = New TextBox()
        txtAlamat = New TextBox()
        txtNominal = New TextBox()
        gbCicilan = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        BtnAjukan = New Button()
        BtnBatal = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        gbCicilan.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(725, 605)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 42)
        Label1.TabIndex = 1
        Label1.Text = "SihCepat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(231, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(399, 46)
        Label2.TabIndex = 2
        Label2.Text = "Formulir Peminjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(119, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 36)
        Label3.TabIndex = 19
        Label3.Text = "Nama"
        ' 
        ' lbNama_Pengajuan
        ' 
        lbNama_Pengajuan.Cursor = Cursors.IBeam
        lbNama_Pengajuan.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        lbNama_Pengajuan.ForeColor = Color.SaddleBrown
        lbNama_Pengajuan.Location = New Point(366, 175)
        lbNama_Pengajuan.Margin = New Padding(3, 4, 3, 4)
        lbNama_Pengajuan.Name = "lbNama_Pengajuan"
        lbNama_Pengajuan.Size = New Size(121, 41)
        lbNama_Pengajuan.TabIndex = 35
        lbNama_Pengajuan.Text = "Label11"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(119, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 36)
        Label4.TabIndex = 22
        Label4.Text = "Nomor HP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(119, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 36)
        Label5.TabIndex = 23
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(119, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(271, 36)
        Label6.TabIndex = 24
        Label6.Text = "Nominal Pinjaman"
        ' 
        ' lbNomor
        ' 
        lbNomor.Cursor = Cursors.IBeam
        lbNomor.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        lbNomor.ForeColor = Color.SaddleBrown
        lbNomor.Location = New Point(366, 223)
        lbNomor.Margin = New Padding(3, 4, 3, 4)
        lbNomor.Name = "lbNomor"
        lbNomor.Size = New Size(105, 41)
        lbNomor.TabIndex = 36
        lbNomor.Text = "Nomor"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Cursor = Cursors.IBeam
        txtAlamat.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(359, 308)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(390, 30)
        txtAlamat.TabIndex = 26
        ' 
        ' txtNominal
        ' 
        txtNominal.Cursor = Cursors.IBeam
        txtNominal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNominal.Location = New Point(359, 365)
        txtNominal.Margin = New Padding(3, 4, 3, 4)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(390, 30)
        txtNominal.TabIndex = 27
        ' 
        ' gbCicilan
        ' 
        gbCicilan.BackColor = Color.White
        gbCicilan.Controls.Add(RadioButton3)
        gbCicilan.Controls.Add(RadioButton2)
        gbCicilan.Controls.Add(RadioButton1)
        gbCicilan.Cursor = Cursors.Hand
        gbCicilan.FlatStyle = FlatStyle.Flat
        gbCicilan.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbCicilan.ForeColor = Color.SaddleBrown
        gbCicilan.Location = New Point(359, 432)
        gbCicilan.Margin = New Padding(3, 4, 3, 4)
        gbCicilan.Name = "gbCicilan"
        gbCicilan.Padding = New Padding(3, 4, 3, 4)
        gbCicilan.Size = New Size(391, 200)
        gbCicilan.TabIndex = 28
        gbCicilan.TabStop = False
        gbCicilan.Text = "Cicilan"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(17, 139)
        RadioButton3.Margin = New Padding(3, 4, 3, 4)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(334, 35)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "12 Bulan (Bunga 2,5%)"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(17, 92)
        RadioButton2.Margin = New Padding(3, 4, 3, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(293, 35)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "6 Bulan (Bunga 5%)"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(17, 45)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(309, 35)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "3 Bulan (Bunga 10%)"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' BtnAjukan
        ' 
        BtnAjukan.BackColor = Color.LimeGreen
        BtnAjukan.Cursor = Cursors.Hand
        BtnAjukan.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnAjukan.FlatAppearance.BorderSize = 0
        BtnAjukan.FlatAppearance.MouseDownBackColor = Color.Green
        BtnAjukan.FlatAppearance.MouseOverBackColor = Color.Green
        BtnAjukan.FlatStyle = FlatStyle.Flat
        BtnAjukan.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAjukan.ForeColor = SystemColors.ControlLightLight
        BtnAjukan.Location = New Point(119, 432)
        BtnAjukan.Margin = New Padding(3, 4, 3, 4)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(216, 91)
        BtnAjukan.TabIndex = 29
        BtnAjukan.Text = "Ajukan"
        BtnAjukan.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.Red
        BtnBatal.Cursor = Cursors.Hand
        BtnBatal.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatAppearance.MouseDownBackColor = Color.Firebrick
        BtnBatal.FlatAppearance.MouseOverBackColor = Color.Firebrick
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBatal.ForeColor = SystemColors.ControlLightLight
        BtnBatal.Location = New Point(119, 541)
        BtnBatal.Margin = New Padding(3, 4, 3, 4)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(216, 91)
        BtnBatal.TabIndex = 30
        BtnBatal.Text = "Batalkan"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SaddleBrown
        Label7.Location = New Point(329, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(24, 36)
        Label7.TabIndex = 31
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(329, 244)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 36)
        Label8.TabIndex = 32
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(329, 300)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 36)
        Label9.TabIndex = 33
        Label9.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(329, 357)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 36)
        Label10.TabIndex = 34
        Label10.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 0
        ' 
        ' AjukanPijaman
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(BtnBatal)
        Controls.Add(BtnAjukan)
        Controls.Add(gbCicilan)
        Controls.Add(txtNominal)
        Controls.Add(txtAlamat)
        Controls.Add(lbNomor)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lbNama_Pengajuan)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "AjukanPijaman"
        Text = "AjukanPeminjaman"
        gbCicilan.ResumeLayout(False)
        gbCicilan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbNama_Pengajuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbNomor As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents gbCicilan As GroupBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label11 As Label
End Class
