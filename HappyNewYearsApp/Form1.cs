using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyNewYearsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            // bu kod ilgili label ın arka planla uyumlu olmasını sağlıyor...
            t1.Parent = pictureBox1;
            t1.BackColor = Color.Transparent;

            t2.Parent = pictureBox1;
            t2.BackColor = Color.Transparent;

            t3.Parent = pictureBox1;
            t3.BackColor = Color.Transparent;

            t4.Parent = pictureBox1;
            t4.BackColor = Color.Transparent;

            t5.Parent = pictureBox1;
            t5.BackColor = Color.Transparent;

            t6.Parent = pictureBox1;
            t6.BackColor = Color.Transparent;

            t7.Parent = pictureBox1;
            t7.BackColor = Color.Transparent;

            t8.Parent = pictureBox1;
            t8.BackColor = Color.Transparent;

            t9.Parent = pictureBox1;
            t9.BackColor = Color.Transparent;

            t10.Parent = pictureBox1;
            t10.BackColor = Color.Transparent;

            t11.Parent = pictureBox1;
            t11.BackColor = Color.Transparent;

            t12.Parent = pictureBox1;
            t12.BackColor = Color.Transparent;

            t13.Parent = pictureBox1;
            t13.BackColor = Color.Transparent;

            t14.Parent = pictureBox1;
            t14.BackColor = Color.Transparent;

            t15.Parent = pictureBox1;
            t15.BackColor = Color.Transparent;

            t16.Parent = pictureBox1;
            t16.BackColor = Color.Transparent;

            t17.Parent = pictureBox1;
            t17.BackColor = Color.Transparent;

            t18.Parent = pictureBox1;
            t18.BackColor = Color.Transparent;

            t19.Parent = pictureBox1;
            t19.BackColor = Color.Transparent;

            t20.Parent = pictureBox1;
            t20.BackColor = Color.Transparent;

            t21.Parent = pictureBox1;
            t21.BackColor = Color.Transparent;

            t22.Parent = pictureBox1;
            t22.BackColor = Color.Transparent;

            t23.Parent = pictureBox1;
            t23.BackColor = Color.Transparent;

            t24.Parent = pictureBox1;
            t24.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==1)
            {
                t1.Visible = true;
            }
            else if (i==2)
            {
                t2.Visible = true;
            }
            else if (i ==3)
            {
                t3.Visible = true;
            }
            else if (i ==4)
            {
                t4.Visible = true;
            }
            else if (i ==5)
            {
                t5.Visible = true;
            }
            else if (i ==6)
            {
                t6.Visible = true;
            }
            else if (i ==7)
            {
                t7.Visible = true;
            }
            else if (i ==8)
            {
                t8.Visible = true;
            }
            else if (i ==9)
            {
                t9.Visible = true;
            }
            else if (i ==10)
            {
                t10.Visible = true;
            }
            else if (i ==11)
            {
                t11.Visible = true;

            }
            else if (i ==12)
            {
                t12.Visible = true;
            }
            else if (i ==13)
            {
                t13.Visible = true;
            }
            else if (i ==14)
            {
                t14.Visible = true;
            }
            else if (i ==15)
            {
                t15.Visible = true;
            }
            else if (i ==16)
            {
                t16.Visible = true;

            }
            else if (i ==17)
            {
                t17.Visible = true;
            }
            else if (i ==18)
            {
                t18.Visible = true;

            }
            else if (i ==19)
            {
                t19.Visible = true;
            }
            else if (i ==20)
            {
                t20.Visible = true;
            }
            else if (i ==21)
            {
                t21.Visible = true;
            }
            else if (i ==22)
            {
                t22.Visible = true;
            }
            else if (i ==23)
            {
                t23.Visible = true;
            }
            else if (i ==24)
            {
                t24.Visible = true;

                timer1.Stop();
                timer2.Start();
            }
        }
        int zaman = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            zaman++;
            if (zaman==1)
            {
                
                t1.ForeColor = Color.Green;
                t2.ForeColor = Color.Green;
                t3.ForeColor = Color.Green;
                t4.ForeColor = Color.Green;
                t5.ForeColor = Color.Green;
                t6.ForeColor = Color.Green;
                t7.ForeColor = Color.Green;
                t8.ForeColor = Color.Green;
                t9.ForeColor = Color.Green;
                t10.ForeColor = Color.Green;
                t11.ForeColor = Color.Green;
                t12.ForeColor = Color.Green;
                t13.ForeColor = Color.Green;
                t14.ForeColor = Color.Green;
                t15.ForeColor = Color.Green;
                t16.ForeColor = Color.Green;              
                t17.ForeColor = Color.Green;
                t18.ForeColor = Color.Green;
                t19.ForeColor = Color.Green;
                t20.ForeColor = Color.Green;
                t21.ForeColor = Color.Green;
                t22.ForeColor = Color.Green;
                t23.ForeColor = Color.Green;
                t24.ForeColor = Color.Green;
            }
            else if (zaman==2)
            {
                t1.ForeColor = Color.Orange;
                t2.ForeColor = Color.Orange;
                t3.ForeColor = Color.Orange;
                t4.ForeColor = Color.Orange;
                t5.ForeColor = Color.Orange;
                t6.ForeColor = Color.Orange;
                t7.ForeColor = Color.Orange;
                t8.ForeColor = Color.Orange;
                t9.ForeColor = Color.Orange;
                t10.ForeColor = Color.Orange;
                t11.ForeColor = Color.Orange;
                t12.ForeColor = Color.Orange;
                t13.ForeColor = Color.Orange;
                t14.ForeColor = Color.Orange;
                t15.ForeColor = Color.Orange;
                t16.ForeColor = Color.Orange;
                t17.ForeColor = Color.Orange;
                t18.ForeColor = Color.Orange;
                t19.ForeColor = Color.Orange;
                t20.ForeColor = Color.Orange;
                t21.ForeColor = Color.Orange;
                t22.ForeColor = Color.Orange;
                t23.ForeColor = Color.Orange;
                t24.ForeColor = Color.Orange;
            }
            else if (zaman==3)
            {
                t1.ForeColor = Color.Turquoise;
                t2.ForeColor = Color.Turquoise;
                t3.ForeColor = Color.Turquoise;
                t4.ForeColor = Color.Turquoise;
                t5.ForeColor = Color.Turquoise;
                t6.ForeColor = Color.Turquoise;
                t7.ForeColor = Color.Turquoise;
                t8.ForeColor = Color.Turquoise;
                t9.ForeColor = Color.Turquoise;
                t10.ForeColor = Color.Turquoise;
                t11.ForeColor = Color.Turquoise;
                t12.ForeColor = Color.Turquoise;
                t13.ForeColor = Color.Turquoise;
                t14.ForeColor = Color.Turquoise;
                t15.ForeColor = Color.Turquoise;
                t16.ForeColor = Color.Turquoise;
                t17.ForeColor = Color.Turquoise;
                t18.ForeColor = Color.Turquoise;
                t19.ForeColor = Color.Turquoise;
                t20.ForeColor = Color.Turquoise;
                t21.ForeColor = Color.Turquoise;
                t22.ForeColor = Color.Turquoise;
                t23.ForeColor = Color.Turquoise;
                t24.ForeColor = Color.Turquoise;
            }
            else if (zaman==4)
            {
                t1.ForeColor = Color.Purple;
                t2.ForeColor = Color.Purple;
                t3.ForeColor = Color.Purple;
                t4.ForeColor = Color.Purple;
                t5.ForeColor = Color.Purple;
                t6.ForeColor = Color.Purple;
                t7.ForeColor = Color.Purple;
                t8.ForeColor = Color.Purple;
                t9.ForeColor = Color.Purple;
                t10.ForeColor = Color.Purple;
                t11.ForeColor = Color.Purple;
                t12.ForeColor = Color.Purple;
                t13.ForeColor = Color.Purple;
                t14.ForeColor = Color.Purple;
                t15.ForeColor = Color.Purple;
                t16.ForeColor = Color.Purple;
                t17.ForeColor = Color.Purple;
                t18.ForeColor = Color.Purple;
                t19.ForeColor = Color.Purple;
                t20.ForeColor = Color.Purple;
                t21.ForeColor = Color.Purple;
                t22.ForeColor = Color.Purple;
                t23.ForeColor = Color.Purple;
                t24.ForeColor = Color.Purple;

                zaman = 0;
            }
        }
    }
}
