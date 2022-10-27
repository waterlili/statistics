namespace Bionomial_probability
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrials = new System.Windows.Forms.TextBox();
            this.txtSuccesses = new System.Windows.Forms.TextBox();
            this.txtProbabilitySuccess = new System.Windows.Forms.TextBox();
            this.txtBinomialProbability = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox1_src = new System.Windows.Forms.TextBox();
            this.textBox2_dst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Trial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of success";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "probability of success";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Binomial Probability";
            // 
            // txtTrials
            // 
            this.txtTrials.Location = new System.Drawing.Point(183, 22);
            this.txtTrials.Name = "txtTrials";
            this.txtTrials.Size = new System.Drawing.Size(100, 23);
            this.txtTrials.TabIndex = 4;
            this.txtTrials.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTrials.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSuccesses
            // 
            this.txtSuccesses.Location = new System.Drawing.Point(183, 55);
            this.txtSuccesses.Name = "txtSuccesses";
            this.txtSuccesses.Size = new System.Drawing.Size(100, 23);
            this.txtSuccesses.TabIndex = 5;
            this.txtSuccesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSuccesses.TextChanged += new System.EventHandler(this.txtSuccesses_TextChanged);
            // 
            // txtProbabilitySuccess
            // 
            this.txtProbabilitySuccess.Location = new System.Drawing.Point(183, 82);
            this.txtProbabilitySuccess.Name = "txtProbabilitySuccess";
            this.txtProbabilitySuccess.Size = new System.Drawing.Size(100, 23);
            this.txtProbabilitySuccess.TabIndex = 6;
            this.txtProbabilitySuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBinomialProbability
            // 
            this.txtBinomialProbability.Location = new System.Drawing.Point(183, 109);
            this.txtBinomialProbability.Name = "txtBinomialProbability";
            this.txtBinomialProbability.Size = new System.Drawing.Size(100, 23);
            this.txtBinomialProbability.TabIndex = 7;
            this.txtBinomialProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 108);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 81);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1_src
            // 
            this.textBox1_src.Location = new System.Drawing.Point(344, 55);
            this.textBox1_src.Name = "textBox1_src";
            this.textBox1_src.Size = new System.Drawing.Size(28, 23);
            this.textBox1_src.TabIndex = 10;
            // 
            // textBox2_dst
            // 
            this.textBox2_dst.Location = new System.Drawing.Point(406, 55);
            this.textBox2_dst.Name = "textBox2_dst";
            this.textBox2_dst.Size = new System.Drawing.Size(28, 23);
            this.textBox2_dst.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 170);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2_dst);
            this.Controls.Add(this.textBox1_src);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBinomialProbability);
            this.Controls.Add(this.txtProbabilitySuccess);
            this.Controls.Add(this.txtSuccesses);
            this.Controls.Add(this.txtTrials);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTrials;
        private TextBox txtSuccesses;
        private TextBox txtProbabilitySuccess;
        private TextBox txtBinomialProbability;
        private Button btnClose;
        private Button btnCalculate;
        private TextBox textBox1_src;
        private TextBox textBox2_dst;
        private Label label5;
        private Label label6;
    }
}