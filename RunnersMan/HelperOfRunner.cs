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
    public partial class HelperOfRunner : Form
    {
        bool isNext = false;
        bool charityIsOpen = false;
        Byte nowCharity = 0;
        List<string> charities = new List<string>();
        List<string> regID = new List<string>();
        string eventId = "";
        SqlConnection conn= new SqlConnection();
        public HelperOfRunner(string needEvent)
        {
            eventId = needEvent;
            InitializeComponent();
        }
        
        public bool Connect_to_DB(string nameDB)
        {
            conn = new SqlConnection(nameDB);
            conn.Open();
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(choosePrice.Text) - 10)>0) {
                choosePrice.Text = (Convert.ToInt32(choosePrice.Text) - 10).ToString(); 
            }
            else
            {
                choosePrice.Text = "0";
            }
        }

        private void choosePrice_TextChanged(object sender, EventArgs e)
        {
            price.Text = "$ "+choosePrice.Text;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            choosePrice.Text = (Convert.ToInt32(choosePrice.Text) + 10).ToString();
        }

        private void choosePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (choosePrice.Text == "")
            {
                choosePrice.Text = "0";
            }
        }

        private void HelperOfRunner_Load(object sender, EventArgs e)
        {
            Form1 mainF = this.Owner as Form1;
            label1.Text = mainF.getNameMarathon();
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            Connect_to_DB(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
            SqlCommand comm = new SqlCommand($"SELECT Registration.RunnerId,Registration.RegistrationId,CharityId FROM Registration,Runner WHERE   Registration.RegistrationId in (SELECT RegistrationId FROM RegistrationEvent WHERE EventId='{eventId}') AND Registration.RunnerId =Runner.RunnerId AND Registration.RegistrationStatusId=3 GROUP BY Registration.RunnerId,Registration.RegistrationId,CharityId ORDER BY Registration.RunnerId;", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                charities.Add(reader[2].ToString());
                SqlConnection conn2 = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
                conn2.Open();
                SqlCommand comm2 = new SqlCommand($"SELECT [User].FirstName,[User].LastName,Country.CountryName FROM[User], Country, Runner WHERE Runner.RunnerId ={reader[0].ToString()} AND Country.CountryCode = (SELECT Runner.CountryCode FROM Runner WHERE Runner.RunnerId = {reader[0].ToString()}) AND [User].Email = (SELECT Runner.Email FROM Runner WHERE Runner.RunnerId = {reader[0].ToString()});", conn2);
                SqlDataReader reader2 = comm2.ExecuteReader();
                regID.Add(reader[1].ToString());
                reader2.Read();
                string name = reader2[0].ToString();
                string lastname = reader2[1].ToString();
                string country = reader2[2].ToString();
                SqlConnection conn3 = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
                conn3.Open();
                SqlCommand comm3 = new SqlCommand($"SELECT BibNumber FROM RegistrationEvent WHERE RegistrationEvent.RegistrationId =  {reader[1].ToString()} AND EventId = '{eventId}';",conn3);
                SqlDataReader reader3 = comm3.ExecuteReader();
                reader3.Read();
                string bib = reader3[0].ToString();
                comboBoxOfRunners.Items.Add(name+" "+ lastname + " " +bib+" "+ country);
                conn2.Close();
                reader2.Close();
                reader3.Close();
                conn3.Close();
            }
            reader.Close();
            this.BackColor = Color.White;
            panel1.BackColor=Color.FromArgb(80, 80, 80);
            labelTime.BackColor= Color.FromArgb(80, 80, 80);
            label1.ForeColor= Color.White;
        }

        private void cardCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((!Char.IsDigit(s) || cardCVC.TextLength == 3) && s!=8 )
            {
                e.Handled = true;
            }
        }

        private void monthCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) ||  monthCard.TextLength==2) && number != 8 ) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void yearCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) ||  yearCard.TextLength == 4) && number != 8 ) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
    
            FormClosedEventArgs w= new FormClosedEventArgs(CloseReason.UserClosing);
            this.Close();
        }

        private void HelperOfRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 mainF = this.Owner as Form1;
            if (!isNext)
            {
                mainF.Show();
            }
        }

        private void comboBoxOfRunners_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand comm = new SqlCommand($"SELECT CharityName FROM Charity WHERE CharityId={charities[comboBoxOfRunners.SelectedIndex]}", conn);
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            label12.Text = reader[0].ToString();
            nowCharity = Convert.ToByte(charities[comboBoxOfRunners.SelectedIndex]);
            reader.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            Form1 mainF = this.Owner as Form1;
            var z = (mainF.getTime() - curDate);
            labelTime.Text = $"{z.Days} дней {z.Hours} часов {z.Minutes} минут до старта марафона";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowCharity!=0)
            {
                charityIsOpen = true;
                CharityInfo ui = new CharityInfo(nowCharity);
                ui.Owner = this;
                ui.Show();
            }
        }
        public void closeCharity()
        {
            charityIsOpen = false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            yourName.Text = "";
            ownerOfCard.Text = "";
            maskedTextBox1.Text = "";
            monthCard.Text = "";
            yearCard.Text = "";
            cardCVC.Text = "";
            choosePrice.Text = "50";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainF = this.Owner as Form1;
            bool prov = true;
            DateTime time = mainF.getTime();
            if (yourName.Text == "")
            {
                prov = false;
                MessageBox.Show("Имя не введено");
            }
            else if (ownerOfCard.Text == "")
            {
                prov = false;
                MessageBox.Show("Владелец карты не введён");
            }
            else if (!maskedTextBox1.MaskCompleted)
            {
                prov = false;
                MessageBox.Show("Номер карты не введён полностью");
            }
            else if (monthCard.Text == "")
            {
                prov = false;
                MessageBox.Show("Месяц карты не введён");
            }
            else if (Convert.ToInt32(monthCard.Text) < time.Month && Convert.ToInt32(yearCard.Text) == time.Year)
            {
                prov = false;
                MessageBox.Show("Ваша карта устарела");
            }
            else if (Convert.ToInt32(monthCard.Text)>=13)
            {
                prov = false;
                MessageBox.Show("Введён некоррекктный месяц");
            }
            else if (yearCard.Text == "")
            {
                prov = false;
                MessageBox.Show("Год карты не введён");
            }
            else if (Convert.ToInt32(yearCard.Text) < time.Year)
            {
                prov = false;
                MessageBox.Show("Ваша карта устарела");
            }
            
            else if (cardCVC.TextLength != 3)
            {
                prov = false;
                MessageBox.Show("CVC введён некорректно");
            }
            if (prov && !charityIsOpen)
            {
                SqlCommand comm = new SqlCommand($"INSERT INTO Sponsorship(SponsorName, RegistrationId, Amount) VALUES('{yourName.Text}', {regID[comboBoxOfRunners.SelectedIndex]}, {choosePrice.Text})", conn);
                SqlDataReader reader = comm.ExecuteReader();
                Form1 mainF1 = this.Owner as Form1;
                ThankForSponsor tr = new ThankForSponsor(Convert.ToInt32(choosePrice.Text), label1.Text, label12.Text, mainF1.getTime(), comboBoxOfRunners.Items[comboBoxOfRunners.SelectedIndex].ToString());
                tr.Owner = mainF1;
                tr.Show();
                isNext = true;
                this.Close();
            }                    
            
             
        }
    }
}
