using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace wireshark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Nile\Downloads\statistics3.txt");
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Nile\Downloads\statistics3.csv");

            string line;
            string[] read;
            char[] seperators = { ',' };

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

               

            }
            foreach(var title in protocols)
            {
                richTextBox1.AppendText("\r\n" + title);
            }
            

        }
    }
}
