Public Class Form2

    Dim palavraEscolhida() As Char

    Dim letrasEscolhidas() As Char

    Dim erros, pontos As Integer

    Dim cont As Integer = 0


    'Construtor para chamar parametros'
    Public Sub New(ByVal palavras As String, ByVal jogador As String, ByVal dicas As String)


        InitializeComponent()

        lblpalavraescolhida.Text = palavras
        lbljogador.Text = jogador
        txtdicas.Text = dicas
        palavraEscolhida = palavras.ToCharArray()



        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'configurando inicio'
        imgcabeca.Visible = False
        imgtronco.Visible = False
        imgbdir.Visible = False
        imgbesq.Visible = False
        imgpdir.Visible = False
        imgpesq.Visible = False

        lblpontuacao.Text = 0
        lblerros.Text = 0

        lblletra01.Visible = False
        lblletra02.Visible = False
        lblletra03.Visible = False
        lblletra04.Visible = False

        cont = 0





    End Sub

    Private Sub lbljogador_Click(sender As Object, e As EventArgs) Handles lbljogador.Click

    End Sub

    Private Sub btnrevelar_Click(sender As Object, e As EventArgs) Handles btnrevelar.Click
        lblpalavraescolhida.Visible = True

    End Sub

    Private Sub btntentar_Click(sender As Object, e As EventArgs) Handles btntentar.Click
        If (cont <= 3) Then
            If (cbletra.SelectedItem() = palavraEscolhida(0) Or cbletra.SelectedItem() = palavraEscolhida(1) Or cbletra.SelectedItem() = palavraEscolhida(2) Or cbletra.SelectedItem() = palavraEscolhida(3)) Then

                MsgBox("Você acertou uma letra!")

                pontos += 1

                lblpontuacao.Text = pontos.ToString

                letrasEscolhidas(cont) = Convert.ToChar(cbletra.SelectedItem)

                cont = cont + 1

            Else
                MsgBox("Errou")
                erros = erros + 1

            End If

            If (pontos >= 4 Or erros >= 6) Then

                btntentar.Enabled = False

                MsgBox("Fim de jogo!")

                MsgBox("Pressione OK para continuar")

                lblletra01.Text = letrasEscolhidas(0).ToString
                lblletra02.Text = letrasEscolhidas(1).ToString
                lblletra03.Text = letrasEscolhidas(2).ToString
                lblletra04.Text = letrasEscolhidas(3).ToString


            End If

        End If
    End Sub

    Private Sub cbletra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbletra.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdicas.TextChanged

    End Sub
End Class