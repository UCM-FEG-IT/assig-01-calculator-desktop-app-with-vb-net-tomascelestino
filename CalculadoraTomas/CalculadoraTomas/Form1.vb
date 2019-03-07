Public Class Form1

    Private Sub botao4_Click(sender As Object, e As EventArgs) Handles botao4.Click
        Dim botao4 As Button = CType(sender, Button)
        If botao4.Name = "botao4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub botao2_Click(sender As Object, e As EventArgs) Handles botao2.Click
        Dim botao2 As Button = CType(sender, Button)
        If botao2.Name = "botao2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub botao3_Click(sender As Object, e As EventArgs) Handles botao3.Click
        Dim botao3 As Button = CType(sender, Button)
        If botao3.Name = "botao3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub botao6_Click(sender As Object, e As EventArgs) Handles botao6.Click
        Dim botao6 As Button = CType(sender, Button)
        If botao6.Name = "botao6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub botao5_Click(sender As Object, e As EventArgs) Handles botao5.Click
        Dim botao5 As Button = CType(sender, Button)
        If botao5.Name = "botao5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub botao9_Click(sender As Object, e As EventArgs) Handles botao9.Click
        Dim botao9 As Button = CType(sender, Button)
        If botao9.Name = "botao9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub botao8_Click(sender As Object, e As EventArgs) Handles botao8.Click
        Dim botao8 As Button = CType(sender, Button)
        If botao8.Name = "botao8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub botao7_Click(sender As Object, e As EventArgs) Handles botao7.Click
        Dim botao7 As Button = CType(sender, Button)
        If botao7.Name = "botao7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub botao0_Click(sender As Object, e As EventArgs) Handles botao0.Click
        Dim botao0 As Button = CType(sender, Button)
        If botao0.Name = "botao0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub botao1_Click(sender As Object, e As EventArgs) Handles botao1.Click
        Dim botao1 As Button = CType(sender, Button)
        If botao1.Name = "botao1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub btnMais_Click(sender As Object, e As EventArgs) Handles btnMais.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnMais" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnMenos" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
    End Sub

    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnDivisao" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnMulti" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
    End Sub

    Private Sub botaoDot_Click(sender As Object, e As EventArgs) Handles botaoDot.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnDot" Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnIgual" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If

        If button.Name = "btnDivisao" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "btnMais" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
        If button.Name = "btnMenos" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
        If button.Name = "ButtonCLR" Then
            TextBox1.Text = ""
        End If
    End Sub
End Class