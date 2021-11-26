using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RunnersMan
{
    public partial class AllInfo : Form
    {
        bool isNext = false;
        SqlConnection conn = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
        DateTime needT;
        string nowMarathon;
        public AllInfo(string marathon)
        {
            nowMarathon = marathon;
            InitializeComponent();
        }

        private void AllInfo_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand($"SELECT MarathonName FROM Marathon WHERE MarathonId=(SELECT MarathonId FROM [Event] WHERE EventId='{nowMarathon}');", conn);
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            label1.Text = reader[0].ToString();
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(80,80,80);
            label1.ForeColor = Color.White;
            labelTime.BackColor= Color.FromArgb(80, 80, 80);
            reader.Close();
            conn.Close();

        }
        public DateTime GetTime()
        {
            return needT;
        }
        public string GetNameMarathon()
        {
            return label1.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            Form1 mainF = this.Owner as Form1;
            needT = mainF.getTime();
            var z = (mainF.getTime() - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isNext = true;
            AllCharity wr = new AllCharity(nowMarathon);
            wr.Owner = this;
            this.Hide();
            wr.Show();
        }
        public void backSignal()
        {
            isNext = false;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNext) 
            {
                Form1 wr = this.Owner as Form1;
                wr.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 mainF = this.Owner as Form1;
            BMIcalculate wr = new BMIcalculate(label1.Text, mainF.getTime());
            wr.Show();
            wr.Owner = this;
            this.Hide();

        }
    }
}
