using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AtomicDictionary
{
    // Define Element class


    // Define Form2 class
    public partial class Form2 : Form
    {
        public Form2(string elementInfo)
        {
            InitializeComponent();
            label3.Text = elementInfo;
            // this.AcceptButton = button1;  // Trigger button1 with Enter
            this.CancelButton = button1;  // Trigger button1 with Esc
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler code here
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Form1 temp6 = new Form1();
            // temp6.Show();
            this.Close();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
    
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }
    }
}
