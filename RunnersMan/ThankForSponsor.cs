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
    public partial class ThankForSponsor : Form
    {
        DateTime needT;
        string[] tmp;
        int amount1;
        string marathon1;
        string charity1;
        public ThankForSponsor(int amount,string marathon,string charity,DateTime time, string Runner)
        {
            tmp =  Runner.Split(' ');
            amount1=amount;
            marathon1=marathon;
            charity1=charity;
            needT = time;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var z = needT - DateTime.Now;
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void ThankForSponsor_Load(object sender, EventArgs e)
        {
            label6.Text = $"$ {amount1.ToString()}";
            label1.Text = marathon1;
            label3.Text = $"Спасибо за поддержку бегуна в {marathon1}!\nВаше пожертвование пойдёт в его благотворительную организацию.";
            label5.Text = charity1;
            label4.Text = tmp[0]+" " + tmp[1] + " " + tmp[2] + " из " + tmp[3];

            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();

            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(80, 80, 80);
            labelTime.BackColor = Color.FromArgb(80, 80, 80);
            label1.ForeColor = Color.White;
            label6.ForeColor = Color.FromArgb(180, 180, 180);
            label5.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThankForSponsor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
