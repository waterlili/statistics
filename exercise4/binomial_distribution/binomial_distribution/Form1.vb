Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Public Class Form1
    Private Shared Function Factorial(ByVal x As Long) As Long
        If x <= 1 Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function
    Private Shared Function Combination(ByVal a As Long, ByVal b As Long) As Long
        If a <= 1 Then Return 1
        Return Factorial(a) / (Factorial(b) * Factorial(a - b))
    End Function
    Private Function BinomialProbability(ByVal trials As Integer, ByVal successes As Integer, ByVal probabilityOfSuccess As Double) As Double
        Dim probOfFailures As Double = 1 - probabilityOfSuccess
        Dim c As Double = Combination(trials, successes)
        Dim px As Double = Math.Pow(probabilityOfSuccess, successes)
        Dim qnx As Double = Math.Pow(probOfFailures, trials - successes)
        Return c * px * qnx
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim nbrOfTrials As Integer = 0, nbrOfSuccesses As Integer = 0
        Dim probOfSuccesses As Double = 0.00
        Dim binomial As Double = 0.00

        Try
            nbrOfTrials = Integer.Parse(txtTrials.Text)
        Catch __unusedFormatException1__ As FormatException
            MessageBox.Show("The number of trials is not valid", "Binomial Probability")
        End Try

        Try
            nbrOfSuccesses = Integer.Parse(txtSuccesses.Text)
        Catch __unusedFormatException1__ As FormatException
            MessageBox.Show("The number of successes is not valid", "Binomial Probability")
        End Try

        Try
            probOfSuccesses = Double.Parse(txtProbabilitySuccess.Text)
            binomial = BinomialProbability(nbrOfTrials, nbrOfSuccesses, probOfSuccesses)
            txtBinomialProbability.Text = binomial.ToString()
        Catch __unusedFormatException1__ As FormatException
            MessageBox.Show("The number of trials is not valid", "Binomial Probability")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
