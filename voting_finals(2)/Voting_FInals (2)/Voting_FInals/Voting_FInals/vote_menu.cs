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
    public partial class vote_menu : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public vote_menu()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            VOTING_SYSTEM log = new VOTING_SYSTEM();
            this.Hide();
            log.Show();
        }

        private void pres_vote_btn_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Vote_Table WHERE Student_Number = '" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("You have already voted! You can only vote 1 time!", "OH NO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                pres_vote pres = new pres_vote();
                this.Hide();
                pres.Show();
            }
            
            
        }

        private void vice_vote_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VicePresident_Vote FROM Vote_Table WHERE VicePresident_Vote IS NULL";
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                vice_vote vice = new vice_vote();
                this.Hide();
                vice.Show();
            }

            else
            {
                MessageBox.Show("You have already voted! You can only vote 1 time!", "OH NO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sec_vote_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Secretary_Vote FROM Vote_Table WHERE Secretary_Vote IS NULL";
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                sec_vote sec = new sec_vote();
                this.Hide();
                sec.Show();
            }

            else
            {
                MessageBox.Show("You have already voted! You can only vote 1 time!", "OH NO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.Show();
        }

        private void vote_menu_Load(object sender, EventArgs e)
        {

        }

        private void ID_Num_TextChanged(object sender, EventArgs e)
        {
            ID_Num.Text = VOTING_SYSTEM.passID;
        }
    }
}
