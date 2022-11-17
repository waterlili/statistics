using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal[] points = { };
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Nile\Downloads\statistics3.csv");
            string line;
            string[] read;
            char[] seperators = { ',' };
            int sum = 0;
            
            int i = 0;
            int j = 0;
            //Number Of Samples
            int n = 25;


            //dictionary of protocols 
            Dictionary<string, int> protocols = new Dictionary<string, int>();
            
            while ((line = streamReader.ReadLine()) != null)
            {


                read = line.Split(seperators, StringSplitOptions.None);
                string protocol_title = read[4];
                decimal protocol_time = Convert.ToDecimal(read[1]);


                //add item to the dictionary
                bool keyExists = protocols.ContainsKey(protocol_title);
                if (keyExists)
                    protocols[protocol_title] += 1;

                else
                    protocols.Add(protocol_title, 1);

                
                
               
                sum+= protocols[protocol_title];
                points[j] = protocol_time;
                j++;
            }
            double average = sum/n;


            int[] nums = new int[25];
            
            
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
            double box = 0;
            foreach (var title in protocols)
            {
                richTextBox1.AppendText("\r\n" + "Xi: "+ (double)title.Value / sum);
                box+= (double)title.Value / sum;
                
            }
            richTextBox1.AppendText("\r\n" + "Probability: " + (double)box);
            
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void SplineChartExample()
        {
            decimal[] points_plot = { };
            foreach (decimal pnt in points) { 
                
            }
            
            this.chart1.Series.Clear();

            this.chart1.Titles.Add("Interarrival");

            Series series = this.chart1.Series.Add("Interarrival");
            series.ChartType = SeriesChartType.Spline;
            series.Points.AddXY("10", 100);
            series.Points.AddXY("20", 300);
            series.Points.AddXY("30", 800);
            series.Points.AddXY("40", 200);
            series.Points.AddXY("50", 600);
            series.Points.AddXY("60", 400);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SplineChartExample();
        }
    }
}
