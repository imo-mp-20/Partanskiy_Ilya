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
    public partial class Form1 : Form
    {
        DateTime needTime;
        SqlConnection conn;
        string nowEvent="";
        public Form1()
        {
            InitializeComponent();
        }
        public bool Connect_to_DB(string nameDB)
        {
            conn = new SqlConnection(nameDB);
            conn.Open();
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(235, 235, 235);
            label3.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(80, 80, 80);
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(80, 80, 80);
            label2.BackColor = Color.FromArgb(80, 80, 80);
            button2.BackColor = Color.FromArgb(235, 235, 235);
            button3.BackColor = Color.FromArgb(235, 235, 235);
            button4.BackColor = Color.FromArgb(235, 235, 235);

            string marID="0";
            Connect_to_DB(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
            SqlCommand comm = new SqlCommand("SELECT Max(StartDateTime) FROM Event", conn);
            SqlDataReader reader = comm.ExecuteReader();
            
            reader.Read();
            DateTime curDate = DateTime.Now;
            needTime = Convert.ToDateTime(reader[0]);
            reader.Close();
            
            comm = new SqlCommand("SELECT StartDateTime,MarathonId,EventId FROM Event", conn);
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                DateTime tmpDate = Convert.ToDateTime(reader[0]);
                    if (tmpDate > curDate)
                    { 
                        if (tmpDate<needTime)
                        {
                        needTime = tmpDate;
                        marID = reader[1].ToString();
                        string tmp = "";
                        for (int i=0; i< tmpDate.ToLongDateString().Length-2;i++)
                        {
                            tmp += tmpDate.ToLongDateString()[i];
                        }
                        nowEvent= reader[2].ToString();
                        label2.Text = $"{tmpDate.ToString("dddd")} {tmp}";
                        }
                       
                    }
                
            }
            reader.Close();
            comm = new SqlCommand($"SELECT MarathonName,CityName,CountryCode FROM Marathon WHERE MarathonId={marID}", conn);
            reader = comm.ExecuteReader();
            reader.Read();
            string tmpCity = reader[1].ToString();
            var Code = reader[2];
            label3.Text = reader[0].ToString();
            reader.Close();
            comm = new SqlCommand($"SELECT CountryName FROM Country WHERE CountryCode='{Code}'", conn);
            reader = comm.ExecuteReader();
            reader.Read();
            label2.Text += tmpCity + ", " + reader[0].ToString() + '\n' + label2.Text;
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            var z = (needTime - curDate);
            label1.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelperOfRunner wr = new HelperOfRunner(nowEvent);
            wr.Owner = this;
            this.Hide();
            wr.Show();
        }
        public DateTime getTime()
        {
            return needTime;
        }
        public string getNameMarathon()
        {
            return label3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllInfo wr = new AllInfo(nowEvent);
            wr.Owner = this;
            this.Hide();
            wr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm wr = new LoginForm();
            wr.Owner = this;
            this.Hide();
            wr.Show();
        }
    }
}
