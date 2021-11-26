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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        bool isNext = false;
        Form1 mainform;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(80,80,80);
            labelTime.BackColor = Color.FromArgb(80, 80, 80);
            mainform = this.Owner as Form1;
            label1.Text = mainform.getNameMarathon();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            var z = (mainform.getTime() - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
            conn.Open();
            SqlCommand comm = new SqlCommand($"SELECT [Password],[RoleName] FROM [User],[Role] WHERE Email='{textBox1.Text}' AND [Role].RoleId=[User].RoleId;", conn);
            SqlDataReader reader = comm.ExecuteReader();
            bool i = false;
            while (reader.Read())
            {
                if (reader[0].ToString()==textBox2.Text)
                {
                    if (reader[1].ToString() == "Runner")
                    {
                        RunnerForm wr = new RunnerForm(textBox1.Text);
                        wr.Owner = mainform;
                        i = isNext = true;
                        this.Close();
                        wr.Show();
                    } 
                    else if (reader[1].ToString()== "Coordinator")
                    {
                        CoordinatorForm wr = new CoordinatorForm();
                        wr.Owner = mainform;
                        i = isNext = true;
                        this.Close();
                        wr.Show();
                    } 
                    else if (reader[1].ToString() == "Administrator")
                    {
                        AdministratorForm wr = new AdministratorForm();
                        wr.Owner = mainform;
                        i = isNext = true;
                        this.Close();
                        wr.Show();
                    }
                }
            }
            if (!i)
            {
                MessageBox.Show("Неправильный Email или Password. Повторите ввод");
                textBox2.Text = "";
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNext)
            {
                mainform.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
