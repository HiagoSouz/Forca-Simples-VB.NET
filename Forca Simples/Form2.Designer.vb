<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.imgbesq = New System.Windows.Forms.PictureBox()
        Me.imgbdir = New System.Windows.Forms.PictureBox()
        Me.imgpdir = New System.Windows.Forms.PictureBox()
        Me.imgpesq = New System.Windows.Forms.PictureBox()
        Me.imgtronco = New System.Windows.Forms.PictureBox()
        Me.imgcabeca = New System.Windows.Forms.PictureBox()
        Me.pbforca = New System.Windows.Forms.PictureBox()
        Me.lblerros = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpontuacao = New System.Windows.Forms.Label()
        Me.pbletra04 = New System.Windows.Forms.PictureBox()
        Me.pbletra03 = New System.Windows.Forms.PictureBox()
        Me.lbljogador = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbletra = New System.Windows.Forms.ComboBox()
        Me.lblletra = New System.Windows.Forms.Label()
        Me.pbletra02 = New System.Windows.Forms.PictureBox()
        Me.pbname01 = New System.Windows.Forms.PictureBox()
        Me.gbdados = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gbjogador = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpalavraescolhida = New System.Windows.Forms.Label()
        Me.txtdicas = New System.Windows.Forms.TextBox()
        Me.btntentar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblletra01 = New System.Windows.Forms.Label()
        Me.lblletra02 = New System.Windows.Forms.Label()
        Me.lblletra03 = New System.Windows.Forms.Label()
        Me.lblletra04 = New System.Windows.Forms.Label()
        Me.btnrevelar = New System.Windows.Forms.Button()
        CType(Me.imgbesq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbdir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgpdir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgpesq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgtronco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgcabeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbforca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbletra04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbletra03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbletra02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbname01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdados.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbjogador.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgbesq
        '
        Me.imgbesq.Image = Global.Forca_Simples.My.Resources.Resources.besq
        Me.imgbesq.Location = New System.Drawing.Point(147, 214)
        Me.imgbesq.Name = "imgbesq"
        Me.imgbesq.Size = New System.Drawing.Size(98, 38)
        Me.imgbesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbesq.TabIndex = 23
        Me.imgbesq.TabStop = False
        '
        'imgbdir
        '
        Me.imgbdir.Image = CType(resources.GetObject("imgbdir.Image"), System.Drawing.Image)
        Me.imgbdir.Location = New System.Drawing.Point(319, 214)
        Me.imgbdir.Name = "imgbdir"
        Me.imgbdir.Size = New System.Drawing.Size(98, 38)
        Me.imgbdir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbdir.TabIndex = 22
        Me.imgbdir.TabStop = False
        '
        'imgpdir
        '
        Me.imgpdir.Image = CType(resources.GetObject("imgpdir.Image"), System.Drawing.Image)
        Me.imgpdir.Location = New System.Drawing.Point(288, 316)
        Me.imgpdir.Name = "imgpdir"
        Me.imgpdir.Size = New System.Drawing.Size(48, 112)
        Me.imgpdir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpdir.TabIndex = 21
        Me.imgpdir.TabStop = False
        '
        'imgpesq
        '
        Me.imgpesq.Image = CType(resources.GetObject("imgpesq.Image"), System.Drawing.Image)
        Me.imgpesq.Location = New System.Drawing.Point(234, 316)
        Me.imgpesq.Name = "imgpesq"
        Me.imgpesq.Size = New System.Drawing.Size(48, 112)
        Me.imgpesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpesq.TabIndex = 20
        Me.imgpesq.TabStop = False
        '
        'imgtronco
        '
        Me.imgtronco.Image = CType(resources.GetObject("imgtronco.Image"), System.Drawing.Image)
        Me.imgtronco.Location = New System.Drawing.Point(251, 214)
        Me.imgtronco.Name = "imgtronco"
        Me.imgtronco.Size = New System.Drawing.Size(62, 96)
        Me.imgtronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgtronco.TabIndex = 19
        Me.imgtronco.TabStop = False
        '
        'imgcabeca
        '
        Me.imgcabeca.Image = CType(resources.GetObject("imgcabeca.Image"), System.Drawing.Image)
        Me.imgcabeca.Location = New System.Drawing.Point(242, 131)
        Me.imgcabeca.Name = "imgcabeca"
        Me.imgcabeca.Size = New System.Drawing.Size(71, 77)
        Me.imgcabeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgcabeca.TabIndex = 18
        Me.imgcabeca.TabStop = False
        '
        'pbforca
        '
        Me.pbforca.Image = CType(resources.GetObject("pbforca.Image"), System.Drawing.Image)
        Me.pbforca.Location = New System.Drawing.Point(67, 15)
        Me.pbforca.Name = "pbforca"
        Me.pbforca.Size = New System.Drawing.Size(359, 446)
        Me.pbforca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbforca.TabIndex = 17
        Me.pbforca.TabStop = False
        '
        'lblerros
        '
        Me.lblerros.AutoSize = True
        Me.lblerros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblerros.ForeColor = System.Drawing.Color.Red
        Me.lblerros.Location = New System.Drawing.Point(446, 59)
        Me.lblerros.Name = "lblerros"
        Me.lblerros.Size = New System.Drawing.Size(20, 24)
        Me.lblerros.TabIndex = 23
        Me.lblerros.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(411, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Erros"
        '
        'lblpontuacao
        '
        Me.lblpontuacao.AutoSize = True
        Me.lblpontuacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblpontuacao.ForeColor = System.Drawing.Color.Red
        Me.lblpontuacao.Location = New System.Drawing.Point(331, 62)
        Me.lblpontuacao.Name = "lblpontuacao"
        Me.lblpontuacao.Size = New System.Drawing.Size(40, 24)
        Me.lblpontuacao.TabIndex = 21
        Me.lblpontuacao.Text = "100"
        '
        'pbletra04
        '
        Me.pbletra04.Image = CType(resources.GetObject("pbletra04.Image"), System.Drawing.Image)
        Me.pbletra04.Location = New System.Drawing.Point(867, 368)
        Me.pbletra04.Name = "pbletra04"
        Me.pbletra04.Size = New System.Drawing.Size(101, 11)
        Me.pbletra04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbletra04.TabIndex = 28
        Me.pbletra04.TabStop = False
        '
        'pbletra03
        '
        Me.pbletra03.Image = CType(resources.GetObject("pbletra03.Image"), System.Drawing.Image)
        Me.pbletra03.Location = New System.Drawing.Point(760, 368)
        Me.pbletra03.Name = "pbletra03"
        Me.pbletra03.Size = New System.Drawing.Size(101, 11)
        Me.pbletra03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbletra03.TabIndex = 27
        Me.pbletra03.TabStop = False
        '
        'lbljogador
        '
        Me.lbljogador.AutoSize = True
        Me.lbljogador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbljogador.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbljogador.Location = New System.Drawing.Point(160, 59)
        Me.lbljogador.Name = "lbljogador"
        Me.lbljogador.Size = New System.Drawing.Size(60, 24)
        Me.lbljogador.TabIndex = 19
        Me.lbljogador.Text = "Hiago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(160, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Jogador"
        '
        'cbletra
        '
        Me.cbletra.FormattingEnabled = True
        Me.cbletra.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cbletra.Location = New System.Drawing.Point(10, 60)
        Me.cbletra.Name = "cbletra"
        Me.cbletra.Size = New System.Drawing.Size(121, 26)
        Me.cbletra.TabIndex = 17
        '
        'lblletra
        '
        Me.lblletra.AutoSize = True
        Me.lblletra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblletra.Location = New System.Drawing.Point(7, 29)
        Me.lblletra.Name = "lblletra"
        Me.lblletra.Size = New System.Drawing.Size(56, 24)
        Me.lblletra.TabIndex = 16
        Me.lblletra.Text = "Letra:"
        '
        'pbletra02
        '
        Me.pbletra02.Image = CType(resources.GetObject("pbletra02.Image"), System.Drawing.Image)
        Me.pbletra02.Location = New System.Drawing.Point(653, 368)
        Me.pbletra02.Name = "pbletra02"
        Me.pbletra02.Size = New System.Drawing.Size(101, 11)
        Me.pbletra02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbletra02.TabIndex = 26
        Me.pbletra02.TabStop = False
        '
        'pbname01
        '
        Me.pbname01.Image = CType(resources.GetObject("pbname01.Image"), System.Drawing.Image)
        Me.pbname01.Location = New System.Drawing.Point(546, 368)
        Me.pbname01.Name = "pbname01"
        Me.pbname01.Size = New System.Drawing.Size(101, 11)
        Me.pbname01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbname01.TabIndex = 25
        Me.pbname01.TabStop = False
        '
        'gbdados
        '
        Me.gbdados.Controls.Add(Me.TabControl1)
        Me.gbdados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbdados.Location = New System.Drawing.Point(546, 15)
        Me.gbdados.Name = "gbdados"
        Me.gbdados.Size = New System.Drawing.Size(633, 170)
        Me.gbdados.TabIndex = 24
        Me.gbdados.TabStop = False
        Me.gbdados.Text = "Informações"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 141)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtdicas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(613, 110)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dicas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnrevelar)
        Me.TabPage2.Controls.Add(Me.lblpalavraescolhida)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(613, 110)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Palavras"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(613, 110)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Letras"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gbjogador
        '
        Me.gbjogador.Controls.Add(Me.btntentar)
        Me.gbjogador.Controls.Add(Me.lblerros)
        Me.gbjogador.Controls.Add(Me.Label3)
        Me.gbjogador.Controls.Add(Me.lblpontuacao)
        Me.gbjogador.Controls.Add(Me.Label5)
        Me.gbjogador.Controls.Add(Me.lbljogador)
        Me.gbjogador.Controls.Add(Me.Label2)
        Me.gbjogador.Controls.Add(Me.cbletra)
        Me.gbjogador.Controls.Add(Me.lblletra)
        Me.gbjogador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbjogador.Location = New System.Drawing.Point(546, 439)
        Me.gbjogador.Name = "gbjogador"
        Me.gbjogador.Size = New System.Drawing.Size(499, 126)
        Me.gbjogador.TabIndex = 29
        Me.gbjogador.TabStop = False
        Me.gbjogador.Text = "Jogador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(271, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Pontuação"
        '
        'lblpalavraescolhida
        '
        Me.lblpalavraescolhida.AutoSize = True
        Me.lblpalavraescolhida.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblpalavraescolhida.ForeColor = System.Drawing.Color.Red
        Me.lblpalavraescolhida.Location = New System.Drawing.Point(7, 7)
        Me.lblpalavraescolhida.Name = "lblpalavraescolhida"
        Me.lblpalavraescolhida.Size = New System.Drawing.Size(167, 26)
        Me.lblpalavraescolhida.TabIndex = 0
        Me.lblpalavraescolhida.Text = "Palavra Secreta"
        '
        'txtdicas
        '
        Me.txtdicas.BackColor = System.Drawing.SystemColors.Info
        Me.txtdicas.Location = New System.Drawing.Point(7, 7)
        Me.txtdicas.Multiline = True
        Me.txtdicas.Name = "txtdicas"
        Me.txtdicas.Size = New System.Drawing.Size(590, 97)
        Me.txtdicas.TabIndex = 0
        '
        'btntentar
        '
        Me.btntentar.Location = New System.Drawing.Point(11, 92)
        Me.btntentar.Name = "btntentar"
        Me.btntentar.Size = New System.Drawing.Size(120, 23)
        Me.btntentar.TabIndex = 24
        Me.btntentar.Text = "Tentar!"
        Me.btntentar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(549, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Label6"
        '
        'lblletra01
        '
        Me.lblletra01.AutoSize = True
        Me.lblletra01.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblletra01.Location = New System.Drawing.Point(552, 327)
        Me.lblletra01.Name = "lblletra01"
        Me.lblletra01.Size = New System.Drawing.Size(79, 26)
        Me.lblletra01.TabIndex = 33
        Me.lblletra01.Text = "Letra 1"
        '
        'lblletra02
        '
        Me.lblletra02.AutoSize = True
        Me.lblletra02.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblletra02.Location = New System.Drawing.Point(663, 327)
        Me.lblletra02.Name = "lblletra02"
        Me.lblletra02.Size = New System.Drawing.Size(79, 26)
        Me.lblletra02.TabIndex = 34
        Me.lblletra02.Text = "Letra 2"
        '
        'lblletra03
        '
        Me.lblletra03.AutoSize = True
        Me.lblletra03.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblletra03.Location = New System.Drawing.Point(771, 327)
        Me.lblletra03.Name = "lblletra03"
        Me.lblletra03.Size = New System.Drawing.Size(79, 26)
        Me.lblletra03.TabIndex = 35
        Me.lblletra03.Text = "Letra 3"
        '
        'lblletra04
        '
        Me.lblletra04.AutoSize = True
        Me.lblletra04.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblletra04.Location = New System.Drawing.Point(876, 327)
        Me.lblletra04.Name = "lblletra04"
        Me.lblletra04.Size = New System.Drawing.Size(79, 26)
        Me.lblletra04.TabIndex = 36
        Me.lblletra04.Text = "Letra 4"
        '
        'btnrevelar
        '
        Me.btnrevelar.Location = New System.Drawing.Point(12, 66)
        Me.btnrevelar.Name = "btnrevelar"
        Me.btnrevelar.Size = New System.Drawing.Size(129, 38)
        Me.btnrevelar.TabIndex = 1
        Me.btnrevelar.Text = "Revelar"
        Me.btnrevelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1282, 635)
        Me.Controls.Add(Me.lblletra04)
        Me.Controls.Add(Me.lblletra03)
        Me.Controls.Add(Me.lblletra02)
        Me.Controls.Add(Me.lblletra01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.imgbesq)
        Me.Controls.Add(Me.imgbdir)
        Me.Controls.Add(Me.imgpdir)
        Me.Controls.Add(Me.imgpesq)
        Me.Controls.Add(Me.imgtronco)
        Me.Controls.Add(Me.imgcabeca)
        Me.Controls.Add(Me.pbforca)
        Me.Controls.Add(Me.pbletra04)
        Me.Controls.Add(Me.pbletra03)
        Me.Controls.Add(Me.pbletra02)
        Me.Controls.Add(Me.pbname01)
        Me.Controls.Add(Me.gbdados)
        Me.Controls.Add(Me.gbjogador)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.imgbesq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbdir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgpdir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgpesq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgtronco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgcabeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbforca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbletra04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbletra03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbletra02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbname01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdados.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbjogador.ResumeLayout(False)
        Me.gbjogador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgbesq As PictureBox
    Friend WithEvents imgbdir As PictureBox
    Friend WithEvents imgpdir As PictureBox
    Friend WithEvents imgpesq As PictureBox
    Friend WithEvents imgtronco As PictureBox
    Friend WithEvents imgcabeca As PictureBox
    Friend WithEvents pbforca As PictureBox
    Friend WithEvents lblerros As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpontuacao As Label
    Friend WithEvents pbletra04 As PictureBox
    Friend WithEvents pbletra03 As PictureBox
    Friend WithEvents lbljogador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbletra As ComboBox
    Friend WithEvents lblletra As Label
    Friend WithEvents pbletra02 As PictureBox
    Friend WithEvents pbname01 As PictureBox
    Friend WithEvents gbdados As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents gbjogador As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblpalavraescolhida As Label
    Friend WithEvents txtdicas As TextBox
    Friend WithEvents btntentar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblletra01 As Label
    Friend WithEvents lblletra02 As Label
    Friend WithEvents lblletra03 As Label
    Friend WithEvents lblletra04 As Label
    Friend WithEvents btnrevelar As Button
End Class
