Imports Microsoft.VisualBasic.FileIO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(
                        "C:\Users\Nile\Downloads\statistics3.csv")




            Dim seperators As Char() = {","c}
            Dim sum As Integer = 0

            Dim n As Integer = 25
            Dim protocols As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
            Dim currentRow As String()
            While Not MyReader.EndOfData
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Try
                    currentRow = MyReader.ReadFields()

                    Dim protocol_title = currentRow(4)
                    'add item to the dictionary
                    Dim keyExists As Boolean = protocols.ContainsKey(protocol_title)
                    If keyExists Then
                        protocols(protocol_title) += 1
                    Else
                        protocols.Add(protocol_title, 1)
                    End If

                    sum += protocols(protocol_title)



                Catch ex As Microsoft.VisualBasic.
                    FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
            "is not valid and will be skipped.")
                End Try
            End While
            Dim average As Double = sum / n
            Dim nums As Integer() = New Integer(24) {}
            Dim i As Integer = 0

            For Each title In protocols
                nums(i) = title.Value
                i += 1
            Next
            RichTextBox1.AppendText("average=" & getAverage(nums))

            Dim varianceValue As Double = variance(nums)
            RichTextBox1.AppendText(vbCrLf & "variance=" & varianceValue)

            Dim stndDeviation As Double = standardDeviation(varianceValue)
            RichTextBox1.AppendText(vbCrLf & "deviation=" & varianceValue)

        End Using
    End Sub
    Private Function variance(ByVal nums As Integer()) As Double
        If nums.Length > 1 Then
            Dim avg As Double = getAverage(nums)
            Dim sumOfSquares As Double = 0.0

            For Each num As Integer In nums
                sumOfSquares += Math.Pow((num - avg), 2.0)
            Next

            Return sumOfSquares / CDbl((nums.Length - 1))
        Else
            Return 0.0
        End If
    End Function
    Private Function standardDeviation(ByVal variance As Double) As Double
        Return Math.Sqrt(variance)
    End Function
    Private Function getAverage(ByVal nums As Integer()) As Double
        Dim sum As Integer = 0

        If nums.Length > 1 Then

            For Each num As Integer In nums
                sum += num
            Next

            Return sum / CDbl(nums.Length)
        Else
            Return CDbl(nums(0))
        End If
    End Function
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
