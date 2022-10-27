using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Bionomial_probability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static long Factorial(long x)
        {
            if (x <= 1)
                return 1;
            else
                return x * Factorial(x - 1);
        }
        private static long Combination(long a, long b)
        {
            if (a <= 1)
                return 1;

            return Factorial(a) / (Factorial(b) * Factorial(a - b));
        }
        //Relative frequency of success
        //n-p-x
        public double BinomialProbability(int trials, int successes, double probabilityOfSuccess)
        {
            double probOfFailures = 1 - probabilityOfSuccess;

            
            Dictionary<int, double> probability_binomial = new Dictionary<int, double>();
            for (int i = 0; i <= successes; i++)
            {
                double c = Combination(trials, i);
                double px = Math.Pow(probabilityOfSuccess, i);
                double qnx = Math.Pow(probOfFailures, trials - i);
                probability_binomial.Add(i, (c * px * qnx));

                //plot
                

            }
            Plot_binomial();
            return probability_binomial.Values.Last();
        }
        public void Plot_binomial()
        {
            Chart chart = this.FindName("Chart") as Chart;
            if (chart != null)
            {
                chart.DataSource = probability_binomial;
                chart.Series["series"].XValueMember = "Key";
                chart.Series["series"].YValueMembers = "Value";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int nbrOfTrials = 0, nbrOfSuccesses = 0, nbrOfDomain=0;
            double probOfSuccesses = 0.00;
            double binomial = 0.00;
            try
            {
                nbrOfDomain = int.Parse(textBox1_src.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of domain is not valid", "Binomial Probability");
            }
            try
            {
                nbrOfTrials = int.Parse(txtTrials.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of trials is not valid","Binomial Probability");
            }

            try
            {
                nbrOfSuccesses = int.Parse(txtSuccesses.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of successes is not valid","Binomial Probability");
            }

            try
            {
                
               
                    probOfSuccesses = double.Parse(txtProbabilitySuccess.Text);

                    binomial = BinomialProbability(nbrOfTrials,
                                        nbrOfSuccesses,
                                        probOfSuccesses);
                    txtBinomialProbability.Text = binomial.ToString();

               
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of trials is not valid","Binomial Probability");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSuccesses_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void textBox2_To(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}