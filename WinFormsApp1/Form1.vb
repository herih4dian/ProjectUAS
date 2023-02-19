
Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.Intrinsics.X86

Public Class Form1

    Dim sFileName As String = ""

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "INI File to Edit"
            .FileName = ""
            .Filter = "INI File|*.ini;"

            If .ShowDialog() = DialogResult.OK Then
                sFileName = .FileName

                If Trim(sFileName) <> "" Then
                    TextBox1.Text = sFileName
                    LoadConfig(sFileName)
                End If
            End If
        End With
    End Sub

    Private Sub LoadConfig(ByVal sFile As String)
        Dim Read() As String = System.IO.File.ReadAllLines(sFile)
        Dim config_name As String = ""
        Dim config_value As String = ""
        Dim masuk As Boolean

        For Each line As String In Read
            Dim arr As String() = line.Split("=")


            config_name = arr(0)
            config_value = arr(1)
            masuk = False

            Select Case config_name
                Case "background"
                    If config_value = "yellow" Then Me.BackColor = Color.Yellow
                    If config_value = "red" Then Me.BackColor = Color.Red
                    If config_value = "black" Then Me.BackColor = Color.Black
                Case "opacity"
                    If config_value = "100" Then Me.Opacity = 1
                    If config_value = "90" Then Me.Opacity = 0.9
                    If config_value = "80" Then Me.Opacity = 0.8
                    If config_value = "70" Then Me.Opacity = 0.7
                    If config_value = "60" Then Me.Opacity = 0.6
                    If config_value = "50" Then Me.Opacity = 0.5
                    If config_value = "40" Then Me.Opacity = 0.4
                    If config_value = "30" Then Me.Opacity = 0.3
                    If config_value = "20" Then Me.Opacity = 0.2
                    If config_value = "10" Then Me.Opacity = 0.1
                Case "serial_key"
                    If config_value = "HeriHadianUnsia" Then masuk = True
            End Select

        Next

        If (masuk = True) Then
            Label2.Show()
            Button2.Show()
        Else
            MessageBox.Show("Config di terima, tapi Maaf anda belum berhak masuk aplikasi, silahkan cek serial_keynya yaaa..", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Opacity = 1
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Hide()
        Button2.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
