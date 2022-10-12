Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Namespace projec1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not String.IsNullOrEmpty(textBox1.Text) Then
                MessageBox.Show("successfull")
            Else
                textBox1.BackColor = Color.Red
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
