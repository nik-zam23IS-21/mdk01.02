using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void qqq(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void qq(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights),1);
            shkal.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            trackBar1.Visible= true;

            if (BMI < 18.5)
            {
                picture.Image = Properties.Resources.bmi_underweight_icon;
                BMItext.Text = "Недовес";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI < 25)
            {
                picture.Image = Properties.Resources.bmi_healthy_icon;
                BMItext.Text = "здоровый";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI < 30)
            {
                picture.Image = Properties.Resources.bmi_overweight_icon;
                BMItext.Text = "Перевес";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI > 30)
            {
                picture.Image = Properties.Resources.bmi_obese_icon;
                BMItext.Text = "Ожирение";
                trackBar1.Value = Convert.ToInt32(BMI);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strel_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void shkal_Click(object sender, EventArgs e)
        {

        }
    }
}
