Imports System.Text
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
            Dim sb As New StringBuilder
            Dim trueCount As Integer
            While Not MyReader.EndOfData
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Try
                    currentRow = MyReader.ReadFields()

                    Dim protocol_titile As String = currentRow(4).Trim
                    If protocols.ContainsKey(protocol_titile) Then
                        protocols(protocol_titile) += 1
                    Else
                        protocols.Add(protocol_titile, 1)
                    End If
                    trueCount += 1





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


            Dim box As Double = 0
            For Each kvp As KeyValuePair(Of String, Integer) In protocols
                'sb.AppendLine(kvp.Key & ") " & (Math.Round(100 * (kvp.Value / trueCount), 2)).ToString)
                Dim xi As Integer = Math.Round(100 * (kvp.Value / trueCount), 2)
                box += xi
                sb.AppendLine("Xi: " & (xi).ToString)
            Next
            sb.AppendLine("Probability: " & (box).ToString)
            RichTextBox1.Text = sb.ToString()

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
    Private Sub SplineChartExample()
        Dim points_plot As Decimal() = {}

        For Each pnt As Decimal In points
        Next

        Me.chart1.Series.Clear()
        Me.chart1.Titles.Add("Interarrival")
        Dim series As Series = Me.chart1.Series.Add("Interarrival")
        series.ChartType = SeriesChartType.Spline
        series.Points.AddXY("10", 100)
        series.Points.AddXY("20", 300)
        series.Points.AddXY("30", 800)
        series.Points.AddXY("40", 200)
        series.Points.AddXY("50", 600)
        series.Points.AddXY("60", 400)
    End Sub
End Class
