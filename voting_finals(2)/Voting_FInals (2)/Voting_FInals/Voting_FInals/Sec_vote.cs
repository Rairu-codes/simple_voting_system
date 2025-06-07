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
    public partial class sec_vote : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public sec_vote()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            vote_menu vmenu = new vote_menu();
            this.Hide();
            vmenu.Show();
        }

        private void ID_Num_TextChanged(object sender, EventArgs e)
        {
            ID_Num.Text = VOTING_SYSTEM.passID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Vote_Table SET Secretary_Vote ='B.I.G' WHERE Student_Number='" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            vote_menu vmenu = new vote_menu();
            this.Hide();
            vmenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Vote_Table SET Secretary_Vote ='Tupac' WHERE Student_Number='" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            vote_menu vmenu = new vote_menu();
            this.Hide();
            vmenu.Show();
        }
    }
}
