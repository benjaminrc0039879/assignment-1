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
           
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // this is the try/catch for the code to stop it crashing
            try
            {
                //read from textbox width
                double width = double.Parse(textBox3.Text);
                //read from textbox length
                double length = double.Parse(textBox1.Text);
                //read from textbox hight
                double hight = double.Parse(textBox2.Text);
                //this is the calculation for the volume of a cuboid
                double volume = width * length * hight;
                //this is the calculation for the area of a cuboid
                double area = 2.0 * (length * hight + length * width + width * hight);
                //diplay answer to volume
                label1.Text = "volume = " + volume;
                //desplay answer to area of cuboid
                label2.Text = "area = " + area;
            }
            catch
            {
                // error message desplayed when wrong input is given
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            // this is the try/catch so stop code from crashing
            try
            {
                double radius = double.Parse(r.Text);
                // this is the calculation for the sphere volume
                double svolume = 4 * radius * radius * radius * 3.14159 / 3;
                //this is the calculation for the sphere area
                double sarea = 4 * 3.14159 * radius * radius;
                // the volume is calculated and shown here in the volume box
                label3.Text = "volume = " + svolume;
                //the area is calculated and shown here in the area box
                label4.Text = "area = " + sarea;
            }
            catch
            {
                //the error message desplayed when incorrect code is inputed
                MessageBox.Show("An error has occoured");
            }
        
        }

        private void Volume_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //this is the try/catch to make sure the code doesnt crash 
            try
            {
                double radius = double.Parse(textBox5.Text);
                double hight = double.Parse(textBox4.Text);
                //this is the calculation for the volume of the cone 
                double cvolume = 3.14159 * radius * radius * hight / 3;
                //this is the calculation for the area of the cone
                double carea = 3.14159 * radius * (radius + Math.Sqrt(hight * hight + radius * radius));
                //the output for the volume of the cone is shown here
                label5.Text = "volume = " + cvolume;
                //the output for the area of the cone is here 
                label6.Text = "area = " + carea;
            }
            catch
            {
                //the error message desplayed when incorrect code is inputed
                MessageBox.Show("an error has occoured");
            }

        }

        private void Area_Click(object sender, EventArgs e)
        {

        }
    }
}
