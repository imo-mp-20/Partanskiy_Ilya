using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunnersMan
{
    public partial class BMIcalculate : Form
    {
        bool isMale = true;
        string ev;
        DateTime tim;
        public BMIcalculate(string ex, DateTime time)
        {
            ev = ex;
            tim = time;
            InitializeComponent();
        }

        private void BMIcalculate_Load(object sender, EventArgs e)
        {
            label1.Text = ev;
            panel3.BackColor = Color.FromArgb(80,80,80);
            labelTime.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel2.BorderStyle = BorderStyle.None;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel1.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmi = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text)/100 * Convert.ToDouble(textBox2.Text)/100);
            label5.Text = bmi.ToString();
            if (bmi< 18.5)
            {
                label6.Text = "Недостаточный вес";
            }
            else if (bmi < 24.9)
            {
                label6.Text = "Здоровый вес";
            }
            else if (bmi <= 29.9)
            {
                label6.Text = "Избыточный вес";
            }
            else if (bmi > 29.9)
            {
                label6.Text = "Ожирение";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";
            label6.Text = "Статус";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            var z = (tim - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void BMIcalculate_FormClosed(object sender, FormClosedEventArgs e)
        {
            AllInfo wr = this.Owner as AllInfo;
            wr.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel1.BorderStyle = BorderStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel2.BorderStyle = BorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel1.BorderStyle = BorderStyle.None;
        }
    }
}
