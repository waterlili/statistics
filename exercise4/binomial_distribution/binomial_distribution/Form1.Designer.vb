<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrials = New System.Windows.Forms.TextBox()
        Me.txtProbabilitySuccess = New System.Windows.Forms.TextBox()
        Me.txtBinomialProbability = New System.Windows.Forms.TextBox()
        Me.txtSuccesses = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number of Trials:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of &Successes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Probability of Success:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Binomial Probability:"
        '
        'txtTrials
        '
        Me.txtTrials.Location = New System.Drawing.Point(165, 17)
        Me.txtTrials.Name = "txtTrials"
        Me.txtTrials.Size = New System.Drawing.Size(100, 23)
        Me.txtTrials.TabIndex = 4
        Me.txtTrials.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProbabilitySuccess
        '
        Me.txtProbabilitySuccess.Location = New System.Drawing.Point(165, 89)
        Me.txtProbabilitySuccess.Name = "txtProbabilitySuccess"
        Me.txtProbabilitySuccess.Size = New System.Drawing.Size(100, 23)
        Me.txtProbabilitySuccess.TabIndex = 5
        Me.txtProbabilitySuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBinomialProbability
        '
        Me.txtBinomialProbability.Location = New System.Drawing.Point(165, 131)
        Me.txtBinomialProbability.Name = "txtBinomialProbability"
        Me.txtBinomialProbability.Size = New System.Drawing.Size(100, 23)
        Me.txtBinomialProbability.TabIndex = 6
        Me.txtBinomialProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSuccesses
        '
        Me.txtSuccesses.Location = New System.Drawing.Point(165, 51)
        Me.txtSuccesses.Name = "txtSuccesses"
        Me.txtSuccesses.Size = New System.Drawing.Size(100, 23)
        Me.txtSuccesses.TabIndex = 7
        Me.txtSuccesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(298, 97)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(298, 131)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 202)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSuccesses)
        Me.Controls.Add(Me.txtBinomialProbability)
        Me.Controls.Add(Me.txtProbabilitySuccess)
        Me.Controls.Add(Me.txtTrials)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTrials As TextBox
    Friend WithEvents txtProbabilitySuccess As TextBox
    Friend WithEvents txtBinomialProbability As TextBox
    Friend WithEvents txtSuccesses As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
End Class
