Public Class TextToSpeech
    Dim Voice = CreateObject("SAPI.SpVoice")
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Voice.Speak(TextBox1.Text)
    End Sub

    Private Sub TextToSpeech_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Keys.Enter Then
            Voice.Speak(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        If Keys.Enter Then
            Voice.Speak(TextBox1.Text)
        End If
    End Sub
End Class
