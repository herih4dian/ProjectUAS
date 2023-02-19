Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim elor_gitu As Boolean

        elor_gitu = Validasi_Yook()

        If (elor_gitu) Then

        Else
            DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
            ClearText()
        End If

    End Sub

    Private Sub ClearText()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Function Validasi_Yook() As Boolean
        Dim elor As Boolean
        Dim elor_text As String

        elor = False
        elor_text = ""

        If TextBox1.Text = "" Then
            elor = True
            elor_text = "Nama,"
        End If

        If TextBox2.Text = "" Then
            elor = True
            elor_text = elor_text & " NIM,"
        End If

        If TextBox3.Text = "" Then
            elor = True
            elor_text = elor_text & " Program Studi,"
        End If

        If (elor = True) Then
            MessageBox.Show("" & elor_text & " Wajib di isi.", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return elor

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class