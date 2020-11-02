using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //hight calculation
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //width calculation
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //length calculation
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            //answer box
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read from textbox
                double width = double.Parse(textBox3.Text);
                double length = double.Parse(textBox1.Text);
                double hight = double.Parse(textBox2.Text);
                //calculate volume
                double volume = width * length * hight;
                double area = 2.0 * (length * hight + length * width + width * hight);
                //diplay answer to volume
                label1.Text = "volume = " + volume;
                label2.Text = "area = " + area;
            }
            catch
            {
                MessageBox.Show("an error has occoured");
            }
           
        }
            
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
