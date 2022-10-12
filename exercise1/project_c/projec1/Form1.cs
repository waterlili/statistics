using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace projec1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("successfull");
            }else
            {
                textBox1.BackColor = Color.Red;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}