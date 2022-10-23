Imports System.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using MyReader As New Microsoft.VisualBasic.
                   FileIO.TextFieldParser(
                     "C:\Users\Nile\Downloads\statistics3.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            Dim protocol As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
            Dim probability As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
            Dim sb As New StringBuilder
            Dim trueCount As Integer
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim protocol_titile As String = currentRow(4).Trim
                    If protocol.ContainsKey(protocol_titile) Then
                        protocol(protocol_titile) += 1
                    Else
                        protocol.Add(protocol_titile, 1)
                    End If
                    trueCount += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
            For Each kvp As KeyValuePair(Of String, Integer) In protocol
                sb.AppendLine(kvp.Key & ") " & (Math.Round(100 * (kvp.Value / trueCount), 2)).ToString)
            Next
            RichTextBox1.Text = sb.ToString()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
