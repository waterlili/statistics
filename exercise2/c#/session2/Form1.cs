using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Collections;
using System.Diagnostics;

namespace session2
{
    public partial class Form1 : Form
    {
        public Random random = new System.Random();
        Dictionary<double, int> counts = new Dictionary<double, int>();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int sum = 0;
            Dictionary<double, double> prob = new Dictionary<double, double>();
            //make sum of all values in dictionary
            //probability for each double number
            foreach (KeyValuePair<double, int> kvp in counts)
            {
                sum += kvp.Value;
                
            }
            
            foreach (KeyValuePair<double, int> kvp in counts)
            {
                double probability = (double)kvp.Value / sum;
                var x = Math.Round(probability, 2);
                prob.Add(kvp.Key, x);
            }
            

            // print the dictionary to console
            string output = "";
            foreach (KeyValuePair<double, double> kvp in prob)
            {
               output += string.Format("Number = {0}, probability = {1}", kvp.Key, kvp.Value);
               output += "\n";
            }
            MessageBox.Show(output.ToString());





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            var i = 1;
            
            var random = new Random();
            var rDouble = random.NextDouble();
           
            var r = random.NextDouble();
            var d = Math.Round(r, 2);

            bool keyExists = counts.ContainsKey(d);
            if (keyExists)
            {
                counts[d] += 1;

            }
            else
            {
                counts.Add(d, i);
            }

            //counts.Add(d, 0);
            richTextBox1.Text += Environment.NewLine + d;

           


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            timer1.Interval = 2000;
            timer1.Start();
           
        }
        public static double SampleGaussian(Random random, double mean, double stddev)
        {
            double x1 = 1 - random.NextDouble();
            double x2 = 1 - random.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);
            return y1 * stddev + mean;
        }

    }
}
