Public Class Form1
    Private Sub lstuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstuser.SelectedIndexChanged

    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        'Adicionando Palavra'
        lstuser.Items.Add(txtuser.Text)
        txtuser.Clear()
    End Sub

    Private Sub btnlimparuser_Click(sender As Object, e As EventArgs) Handles btnlimparuser.Click
        txtuser.Clear()
    End Sub

    Private Sub btnaddpalavra_Click(sender As Object, e As EventArgs) Handles btnaddpalavra.Click
        'Adicionando Palavra'
        lstpalavra.Items.Add(txtpalavra.Text)
        txtuser.Clear()
    End Sub

    Private Sub btnlimparpalavra_Click(sender As Object, e As EventArgs) Handles btnlimparpalavra.Click
        txtpalavra.Clear()
        'limpando'
    End Sub

    Private Sub btnexcluiruser_Click(sender As Object, e As EventArgs) Handles btnexcluiruser.Click
        'Excluir Jogador'
        lstuser.Items.RemoveAt(lstuser.SelectedIndex)
    End Sub

    Private Sub btnexcluirpalavra_Click(sender As Object, e As EventArgs) Handles btnexcluirpalavra.Click
        'Excluir Palavra'
        lstpalavra.Items.RemoveAt(lstpalavra.SelectedIndex)
    End Sub


    Private Sub TelaADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstpalavra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstpalavra.SelectedIndexChanged

    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        Dim telajogo As New Form2(lstpalavra.SelectedItem.ToString(), lstuser.SelectedItem.ToString(), txtdicas.Text)
        telajogo.Show()
        Me.Hide()


    End Sub
End Class