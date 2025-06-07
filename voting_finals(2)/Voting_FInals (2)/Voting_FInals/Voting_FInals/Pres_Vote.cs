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
    public partial class pres_vote : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public pres_vote()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            vote_menu vmenu = new vote_menu();
            this.Hide();
            vmenu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            VOTING_SYSTEM VS = new VOTING_SYSTEM();
            
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
            cmd.CommandText = "INSERT INTO Vote_Table(Student_Number,President_Vote) VALUES('" + ID_Num.Text + "','Giannis')";
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
            cmd.CommandText = "INSERT INTO Vote_Table(Student_Number,President_Vote) VALUES('" + ID_Num.Text + "','James')";
            cmd.ExecuteNonQuery();
            con.Close();

            vote_menu vmenu = new vote_menu();
            this.Hide();
            vmenu.Show();
        }
    }
}
