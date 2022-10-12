Imports System
Imports System.Timers
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Collections
Imports System.Diagnostics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Namespace session2
    Partial Public Class Form1
        Inherits Form

        Public random As Random = New System.Random()
        Private counts As Dictionary(Of Double, Integer) = New Dictionary(Of Double, Integer)()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            timer1.[Stop]()
            Dim sum As Integer = 0
            Dim prob As Dictionary(Of Double, Double) = New Dictionary(Of Double, Double)()

            For Each kvp As KeyValuePair(Of Double, Integer) In counts
                sum += kvp.Value
            Next

            For Each kvp As KeyValuePair(Of Double, Integer) In counts
                Dim probability As Double = CDbl(kvp.Value) / sum
                Dim x = Math.Round(probability, 2)
                prob.Add(kvp.Key, x)
            Next

            Dim output As String = ""

            For Each kvp As KeyValuePair(Of Double, Double) In prob
                output += String.Format("Number = {0}, probability = {1}", kvp.Key, kvp.Value)
                output += vbLf
            Next

            MessageBox.Show(output.ToString())
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim i = 1
            Dim random = New Random()
            Dim rDouble = random.NextDouble()
            Dim r = random.NextDouble()
            Dim d = Math.Round(r, 2)
            Dim keyExists As Boolean = counts.ContainsKey(d)

            If keyExists Then
                counts(d) += 1
            Else
                counts.Add(d, i)
            End If

            richTextBox1.Text += Environment.NewLine & d
        End Sub

        Private Sub richTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            timer1.Interval = 2000
            timer1.Start()
        End Sub

        Public Shared Function SampleGaussian(ByVal random As Random, ByVal mean As Double, ByVal stddev As Double) As Double
            Dim x1 As Double = 1 - random.NextDouble()
            Dim x2 As Double = 1 - random.NextDouble()
            Dim y1 As Double = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2)
            Return y1 * stddev + mean
        End Function

        Friend WithEvents Timer1 As Windows.Forms.Timer
        Private components As IContainer

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            '
            'RichTextBox1
            '
            Me.RichTextBox1.Location = New System.Drawing.Point(157, 127)
            Me.RichTextBox1.Name = "RichTextBox1"
            Me.RichTextBox1.Size = New System.Drawing.Size(314, 96)
            Me.RichTextBox1.TabIndex = 0
            Me.RichTextBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.RichTextBox1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RichTextBox1 As RichTextBox
    End Class
End Namespace
