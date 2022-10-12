using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gaussian_probability.Form1;

namespace gaussian_probability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Gaussian
        {
            private static bool uselast = true;
            private static double next_gaussian = 0.0;
            private static Random random = new Random();

            public static double BoxMuller()
            {
                if (uselast)
                {
                    uselast = false;
                    return next_gaussian;
                }
                else
                {
                    double v1, v2, s;
                    do
                    {
                        v1 = 2.0 * random.NextDouble() - 1.0;
                        v2 = 2.0 * random.NextDouble() - 1.0;
                        s = v1 * v1 + v2 * v2;
                    } while (s >= 1.0 || s == 0);

                    s = System.Math.Sqrt((-2.0 * System.Math.Log(s)) / s);

                    next_gaussian = v2 * s;
                    uselast = true;
                    return v1 * s;
                }
            }

            public static double BoxMuller(double mean, double standard_deviation)
            {
                return mean + BoxMuller() * standard_deviation;
            }

            public static int Next(int min, int max)
            {
                double deviations = 3.5;
                int r;
                while ((r = (int)BoxMuller(min + (max - min) / 2.0, (max - min) / 2.0 / deviations)) > max || r < min)
                {
                }

                return r;
            }

        }
        public static double SampleGaussian(Random random, double mean, double stddev)
        {
            // The method requires sampling from a uniform random of (0,1]
            // but Random.NextDouble() returns a sample of [0,1).
            double x1 = 1 - random.NextDouble();
            double x2 = 1 - random.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);
            return y1 * stddev + mean;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
