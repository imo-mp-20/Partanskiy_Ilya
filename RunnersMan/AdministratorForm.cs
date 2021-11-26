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
    public partial class AdministratorForm : Form
    {
        Form1 main;
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            label1.Text = main.getNameMarathon();
            labelTime.BackColor = Color.FromArgb(80, 80, 80);
            panel1.BackColor = Color.FromArgb(80, 80, 80);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            var z = (main.getTime() - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }
    }
}
