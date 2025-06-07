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
    public partial class tally : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public tally()
        {
            InitializeComponent();
            showGrid2(dataGridView2);
            showGrid1(dataGridView1);
            showGrid3(dataGridView3);
            showGrid4(dataGridView4);
            showGrid5(dataGridView5);
            showGrid6(dataGridView6);
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.Show();
        }
        private void showGrid2(DataGridView dataGridView)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'James Votes' FROM Vote_Table WHERE President_Vote='James'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void showGrid1(DataGridView dataGridView)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'Giannis Votes' FROM Vote_Table WHERE President_Vote='Giannis'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void showGrid3(DataGridView dataGridView)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'Ronaldo Votes' FROM Vote_Table WHERE VicePresident_Vote='Ronaldo'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void showGrid4(DataGridView dataGridView)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'Messi Votes' FROM Vote_Table WHERE VicePresident_Vote='Messi'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void showGrid5(DataGridView dataGridView)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'B.I.G Votes' FROM Vote_Table WHERE Secretary_Vote='B.I.G'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            con.Close();
        }

        private void showGrid6(DataGridView dataGridView)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS 'Tupac Votes' FROM Vote_Table WHERE Secretary_Vote='Tupac'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tally_Load(object sender, EventArgs e)
        {

        }
    }
}
