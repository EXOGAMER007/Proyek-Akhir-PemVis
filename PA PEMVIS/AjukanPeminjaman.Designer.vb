<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtAlamat = New TextBox()
        txtNominal = New TextBox()
        gbCicilan = New GroupBox()
        BtnAjukan = New Button()
        BtnBatal = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        lbNama_pengajuan = New Label()
        lbNomor = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        gbCicilan.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(634, 454)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 33)
        Label1.TabIndex = 1
        Label1.Text = "SihCepat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(202, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(323, 37)
        Label2.TabIndex = 2
        Label2.Text = "Formulir Peminjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(104, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 29)
        Label3.TabIndex = 19
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(104, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 29)
        Label4.TabIndex = 22
        Label4.Text = "Nomor HP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(104, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 29)
        Label5.TabIndex = 23
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(104, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 29)
        Label6.TabIndex = 24
        Label6.Text = "Nominal"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(314, 204)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(342, 23)
        txtAlamat.TabIndex = 26
        ' 
        ' txtNominal
        ' 
        txtNominal.Location = New Point(314, 242)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(342, 23)
        txtNominal.TabIndex = 27
        ' 
        ' gbCicilan
        ' 
        gbCicilan.BackColor = Color.White
        gbCicilan.Controls.Add(RadioButton3)
        gbCicilan.Controls.Add(RadioButton2)
        gbCicilan.Controls.Add(RadioButton1)
        gbCicilan.FlatStyle = FlatStyle.Flat
        gbCicilan.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbCicilan.ForeColor = Color.SaddleBrown
        gbCicilan.Location = New Point(314, 286)
        gbCicilan.Name = "gbCicilan"
        gbCicilan.Size = New Size(342, 132)
        gbCicilan.TabIndex = 28
        gbCicilan.TabStop = False
        gbCicilan.Text = "Cicilan"
        ' 
        ' BtnAjukan
        ' 
        BtnAjukan.BackColor = Color.LimeGreen
        BtnAjukan.Cursor = Cursors.Hand
        BtnAjukan.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnAjukan.FlatAppearance.BorderSize = 0
        BtnAjukan.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnAjukan.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnAjukan.FlatStyle = FlatStyle.Flat
        BtnAjukan.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAjukan.ForeColor = SystemColors.ControlLightLight
        BtnAjukan.Location = New Point(104, 286)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(189, 60)
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
        BtnBatal.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBatal.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBatal.ForeColor = SystemColors.ControlLightLight
        BtnBatal.Location = New Point(104, 358)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(189, 60)
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
        Label7.Location = New Point(288, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 29)
        Label7.TabIndex = 31
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(288, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(20, 29)
        Label8.TabIndex = 32
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(288, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(20, 29)
        Label9.TabIndex = 33
        Label9.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SaddleBrown
        Label10.Location = New Point(288, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 29)
        Label10.TabIndex = 34
        Label10.Text = ":"
        ' 
        ' lbNama_pengajuan
        ' 
        lbNama_pengajuan.AutoSize = True
        lbNama_pengajuan.Location = New Point(314, 138)
        lbNama_pengajuan.Name = "lbNama_pengajuan"
        lbNama_pengajuan.Size = New Size(47, 15)
        lbNama_pengajuan.TabIndex = 35
        lbNama_pengajuan.Text = "Label11"
        ' 
        ' lbNomor
        ' 
        lbNomor.AutoSize = True
        lbNomor.Location = New Point(316, 172)
        lbNomor.Name = "lbNomor"
        lbNomor.Size = New Size(45, 15)
        lbNomor.TabIndex = 36
        lbNomor.Text = "Nomor"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 28)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(237, 29)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "3 Bulan Bunga 15%"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 62)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(237, 29)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "6 Bulan Bunga 20%"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 93)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(250, 29)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "12 Bulan Bunga 25%"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' AjukanPijaman
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 494)
        Controls.Add(lbNomor)
        Controls.Add(lbNama_pengajuan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(BtnBatal)
        Controls.Add(BtnAjukan)
        Controls.Add(gbCicilan)
        Controls.Add(txtNominal)
        Controls.Add(txtAlamat)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents gbCicilan As GroupBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbNama_pengajuan As Label
    Friend WithEvents lbNomor As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
