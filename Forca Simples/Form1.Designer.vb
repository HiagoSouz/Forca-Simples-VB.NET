<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnexcluiruser = New System.Windows.Forms.Button()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.btnlimparpalavra = New System.Windows.Forms.Button()
        Me.btnaddpalavra = New System.Windows.Forms.Button()
        Me.gbuser = New System.Windows.Forms.GroupBox()
        Me.lstuser = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.btnlimparuser = New System.Windows.Forms.Button()
        Me.btnexcluirpalavra = New System.Windows.Forms.Button()
        Me.lstpalavra = New System.Windows.Forms.ListBox()
        Me.txtpalavra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbpalavras = New System.Windows.Forms.GroupBox()
        Me.txtdicas = New System.Windows.Forms.TextBox()
        Me.gbdicas = New System.Windows.Forms.GroupBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.gbuser.SuspendLayout()
        Me.gbpalavras.SuspendLayout()
        Me.gbdicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexcluiruser
        '
        Me.btnexcluiruser.Location = New System.Drawing.Point(546, 89)
        Me.btnexcluiruser.Name = "btnexcluiruser"
        Me.btnexcluiruser.Size = New System.Drawing.Size(117, 38)
        Me.btnexcluiruser.TabIndex = 19
        Me.btnexcluiruser.Text = "Excluir"
        Me.btnexcluiruser.UseVisualStyleBackColor = True
        '
        'btnadduser
        '
        Me.btnadduser.Location = New System.Drawing.Point(169, 89)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(87, 23)
        Me.btnadduser.TabIndex = 18
        Me.btnadduser.Text = "Adicionar"
        Me.btnadduser.UseVisualStyleBackColor = True
        '
        'btnlimparpalavra
        '
        Me.btnlimparpalavra.Location = New System.Drawing.Point(76, 101)
        Me.btnlimparpalavra.Name = "btnlimparpalavra"
        Me.btnlimparpalavra.Size = New System.Drawing.Size(79, 23)
        Me.btnlimparpalavra.TabIndex = 16
        Me.btnlimparpalavra.Text = "Limpar"
        Me.btnlimparpalavra.UseVisualStyleBackColor = True
        '
        'btnaddpalavra
        '
        Me.btnaddpalavra.Location = New System.Drawing.Point(169, 101)
        Me.btnaddpalavra.Name = "btnaddpalavra"
        Me.btnaddpalavra.Size = New System.Drawing.Size(87, 23)
        Me.btnaddpalavra.TabIndex = 19
        Me.btnaddpalavra.Text = "Adicionar"
        Me.btnaddpalavra.UseVisualStyleBackColor = True
        '
        'gbuser
        '
        Me.gbuser.Controls.Add(Me.btnexcluiruser)
        Me.gbuser.Controls.Add(Me.lstuser)
        Me.gbuser.Controls.Add(Me.Label2)
        Me.gbuser.Controls.Add(Me.btnadduser)
        Me.gbuser.Controls.Add(Me.txtuser)
        Me.gbuser.Controls.Add(Me.btnlimparuser)
        Me.gbuser.Location = New System.Drawing.Point(12, 13)
        Me.gbuser.Name = "gbuser"
        Me.gbuser.Size = New System.Drawing.Size(705, 157)
        Me.gbuser.TabIndex = 23
        Me.gbuser.TabStop = False
        Me.gbuser.Text = "Dados do jogador"
        '
        'lstuser
        '
        Me.lstuser.FormattingEnabled = True
        Me.lstuser.Location = New System.Drawing.Point(301, 19)
        Me.lstuser.Name = "lstuser"
        Me.lstuser.Size = New System.Drawing.Size(228, 108)
        Me.lstuser.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Login:"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(76, 46)
        Me.txtuser.MaxLength = 12
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(180, 20)
        Me.txtuser.TabIndex = 15
        '
        'btnlimparuser
        '
        Me.btnlimparuser.Location = New System.Drawing.Point(76, 89)
        Me.btnlimparuser.Name = "btnlimparuser"
        Me.btnlimparuser.Size = New System.Drawing.Size(79, 23)
        Me.btnlimparuser.TabIndex = 17
        Me.btnlimparuser.Text = "Limpar"
        Me.btnlimparuser.UseVisualStyleBackColor = True
        '
        'btnexcluirpalavra
        '
        Me.btnexcluirpalavra.Location = New System.Drawing.Point(546, 94)
        Me.btnexcluirpalavra.Name = "btnexcluirpalavra"
        Me.btnexcluirpalavra.Size = New System.Drawing.Size(117, 37)
        Me.btnexcluirpalavra.TabIndex = 20
        Me.btnexcluirpalavra.Text = "Excluir"
        Me.btnexcluirpalavra.UseVisualStyleBackColor = True
        '
        'lstpalavra
        '
        Me.lstpalavra.FormattingEnabled = True
        Me.lstpalavra.Location = New System.Drawing.Point(301, 23)
        Me.lstpalavra.Name = "lstpalavra"
        Me.lstpalavra.Size = New System.Drawing.Size(228, 108)
        Me.lstpalavra.TabIndex = 18
        '
        'txtpalavra
        '
        Me.txtpalavra.Location = New System.Drawing.Point(76, 62)
        Me.txtpalavra.MaxLength = 4
        Me.txtpalavra.Name = "txtpalavra"
        Me.txtpalavra.Size = New System.Drawing.Size(180, 20)
        Me.txtpalavra.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Digite uma palavra (max 4 letras)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Palavra:"
        '
        'gbpalavras
        '
        Me.gbpalavras.Controls.Add(Me.btnlimparpalavra)
        Me.gbpalavras.Controls.Add(Me.btnexcluirpalavra)
        Me.gbpalavras.Controls.Add(Me.lstpalavra)
        Me.gbpalavras.Controls.Add(Me.btnaddpalavra)
        Me.gbpalavras.Controls.Add(Me.txtpalavra)
        Me.gbpalavras.Controls.Add(Me.Label3)
        Me.gbpalavras.Controls.Add(Me.Label1)
        Me.gbpalavras.Location = New System.Drawing.Point(12, 180)
        Me.gbpalavras.Name = "gbpalavras"
        Me.gbpalavras.Size = New System.Drawing.Size(705, 151)
        Me.gbpalavras.TabIndex = 24
        Me.gbpalavras.TabStop = False
        Me.gbpalavras.Text = "Cadastro de palavras"
        '
        'txtdicas
        '
        Me.txtdicas.Location = New System.Drawing.Point(23, 19)
        Me.txtdicas.MaxLength = 20
        Me.txtdicas.Multiline = True
        Me.txtdicas.Name = "txtdicas"
        Me.txtdicas.Size = New System.Drawing.Size(640, 103)
        Me.txtdicas.TabIndex = 17
        '
        'gbdicas
        '
        Me.gbdicas.Controls.Add(Me.txtdicas)
        Me.gbdicas.Location = New System.Drawing.Point(12, 357)
        Me.gbdicas.Name = "gbdicas"
        Me.gbdicas.Size = New System.Drawing.Size(705, 138)
        Me.gbdicas.TabIndex = 25
        Me.gbdicas.TabStop = False
        Me.gbdicas.Text = "Cadastro de dicas"
        '
        'btniniciar
        '
        Me.btniniciar.Location = New System.Drawing.Point(193, 514)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(348, 37)
        Me.btniniciar.TabIndex = 21
        Me.btniniciar.Text = "Iniciar"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 572)
        Me.Controls.Add(Me.btniniciar)
        Me.Controls.Add(Me.gbuser)
        Me.Controls.Add(Me.gbpalavras)
        Me.Controls.Add(Me.gbdicas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbuser.ResumeLayout(False)
        Me.gbuser.PerformLayout()
        Me.gbpalavras.ResumeLayout(False)
        Me.gbpalavras.PerformLayout()
        Me.gbdicas.ResumeLayout(False)
        Me.gbdicas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexcluiruser As Button
    Friend WithEvents btnadduser As Button
    Friend WithEvents btnlimparpalavra As Button
    Friend WithEvents btnaddpalavra As Button
    Friend WithEvents gbuser As GroupBox
    Friend WithEvents lstuser As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents btnlimparuser As Button
    Friend WithEvents btnexcluirpalavra As Button
    Friend WithEvents lstpalavra As ListBox
    Friend WithEvents txtpalavra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbpalavras As GroupBox
    Friend WithEvents txtdicas As TextBox
    Friend WithEvents gbdicas As GroupBox
    Friend WithEvents btniniciar As Button
End Class
