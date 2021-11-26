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
    public partial class AllCharity : Form
    {
        string nowMarathon;
        SqlConnection conn = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
        public AllCharity(string marathon)
        {
            nowMarathon = marathon;
            InitializeComponent();
        }

        private void AllCharity_Load(object sender, EventArgs e)
        {
            panel1.BackColor= Color.FromArgb(80, 80, 80);
            label1.ForeColor = Color.White;
            AllInfo mainF = this.Owner as AllInfo;
            label1.Text = mainF.GetNameMarathon();
            labelTime.BackColor = Color.FromArgb(80, 80, 80);
            this.BackColor = Color.White;
            conn.Open();
            SqlCommand comm = new SqlCommand($"SELECT CharityId FROM Registration,Runner WHERE   Registration.RegistrationId in (SELECT RegistrationId FROM RegistrationEvent WHERE EventId='{nowMarathon}') AND Registration.RunnerId =Runner.RunnerId AND Registration.RegistrationStatusId=3 GROUP BY CharityId;", conn);
            SqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read()) {
                SqlConnection conn1 = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
                conn1.Open();
                SqlCommand comm1 = new SqlCommand($"SELECT CharityName,CharityDescription, CharityLogo FROM Charity WHERE  CharityId={reader[0].ToString()};", conn1);
                SqlDataReader reader1 = comm1.ExecuteReader();
                reader1.Read();
                PictureBox box = new PictureBox();
                box.Size=new Size(150, 100);
                box.Image = Image.FromFile("marathon-skills-2016-charity-data\\" + @reader1[2].ToString());
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Dock=new DockStyle();
                Label info = new Label();
                info.Font = new Font("Arial", 14);
                info.AutoSize = true;
                info.Text = reader1[1].ToString();
                tableLayoutPanel1.Controls.Add(info, 1, i);
                tableLayoutPanel1.Controls.Add(box, 0, i);

                Console.WriteLine(i.ToString());
                
                ++i;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            AllInfo mainF = this.Owner as AllInfo;
            var z = (mainF.GetTime() - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllCharity_FormClosed(object sender, FormClosedEventArgs e)
        {
            AllInfo mainF = this.Owner as AllInfo;
            mainF.backSignal();
            mainF.Show();
        }
    }
}
