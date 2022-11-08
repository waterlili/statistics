using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Nile\Downloads\statistics3.csv");
            string line;
            string[] read;
            char[] seperators = { ',' };
            int sum = 0;

            //Number Of Samples
            int n = 25;


            //dictionary of protocols 
            Dictionary<string, int> protocols = new Dictionary<string, int>();

            while ((line = streamReader.ReadLine()) != null)
            {


                read = line.Split(seperators, StringSplitOptions.None);
                string protocol_title = read[4];


                //add item to the dictionary
                bool keyExists = protocols.ContainsKey(protocol_title);
                if (keyExists)
                    protocols[protocol_title] += 1;

                else
                    protocols.Add(protocol_title, 1);


                sum+= protocols[protocol_title];
            }
            double average = sum/n;


            int[] nums = new int[25];
            double precomputation = 0.0;
            int i = 0;
            foreach (var title in protocols)
            {
                nums[i]=title.Value;
                i++;

            }
            //Mean
            richTextBox1.AppendText("\r\n" + "average=" + getAverage(nums));
            // Get the variance of our values
            double varianceValue = variance(nums);
            richTextBox1.AppendText("\r\n" + "variance=" + varianceValue);
            double stndDeviation = standardDeviation(varianceValue);
            //standard deviation
            richTextBox1.AppendText("\r\n" + "deviation=" + varianceValue);



        }
        private double variance(int[] nums)
        {
            if (nums.Length > 1)
            {
                // Get the average of the values
                double avg = getAverage(nums);

                double sumOfSquares = 0.0;
                foreach (int num in nums)
                {
                    sumOfSquares += Math.Pow((num - avg), 2.0);

                }
                return sumOfSquares / (double)(nums.Length - 1);
            }
            else { return 0.0; }

        }
        private double standardDeviation(double variance)
        {
            return Math.Sqrt(variance);
        }
        private double getAverage(int[] nums)
        {
            int sum = 0;

            if (nums.Length > 1)
            {
                foreach (int num in nums)
                {
                    sum += num;
                }
                return sum / (double)nums.Length;
            }
            else { return (double)nums[0]; }

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
