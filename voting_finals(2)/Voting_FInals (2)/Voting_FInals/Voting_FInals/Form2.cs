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

namespace Voting_FInals
{
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            VOTING_SYSTEM log = new VOTING_SYSTEM();
            this.Hide();
            log.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            string ID = ID_Num.Text;
            string pass = password.Text;
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string sec = textBox3.Text;

            if (ID.Equals(String.Empty))
            {
                MessageBox.Show("Please fill up this Field!!", "(Warning)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pass.Equals(String.Empty))
            {
                MessageBox.Show("Please fill up this Field!!", "(Warning)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fname.Equals(String.Empty))
            {
                MessageBox.Show("Please fill up this Field!!", "(Warning)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lname.Equals(String.Empty))
            {
                MessageBox.Show("Please fill up this Field!!", "(Warning)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sec.Equals(String.Empty))
            {
                MessageBox.Show("Please fill up this Field!!", "(Warning)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Going to the Login Area!!", "Welcome!! (Pls Vote Wisely)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VOTING_SYSTEM log = new VOTING_SYSTEM();
                this.Hide();
                log.Show();
            }

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Account_Table(Student_Number,Password,First_Name,Last_Name,Section) VALUES ('" + ID_Num.Text + "','" + password.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                
            }

            catch
            {
                
                MessageBox.Show(this, "You are not yet registered", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VOTING_SYSTEM log = new VOTING_SYSTEM();
                this.Hide();
                log.Show();

            }

            


        }
    }
}
