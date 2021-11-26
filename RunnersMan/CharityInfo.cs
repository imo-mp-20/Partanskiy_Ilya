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
    public partial class CharityInfo : Form
    {
        Byte id;
        public CharityInfo(Byte charId)
        {
            id = charId;
            InitializeComponent();
        }

        private void CharityInfo_Load(object sender, EventArgs e)
        {
            HelperOfRunner par = this.Owner as HelperOfRunner;
            SqlConnection conn = new SqlConnection(@"Data Source=IZENGARDEC\SQLEXPRESS;Initial Catalog=Runner;Persist Security Info=True;User ID=sa;Password=P116group!");
            conn.Open();
            SqlCommand comm = new SqlCommand($"SELECT * FROM Charity  WHERE CharityId={id}", conn);
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            label1.Text = reader[1].ToString();
            richTextBox1.Text = reader[2].ToString();
            pictureBox1.Image = Image.FromFile("marathon-skills-2016-charity-data\\"+@reader[3].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            par.closeCharity();
            conn.Close();
            reader.Close();
        }
    }
}
