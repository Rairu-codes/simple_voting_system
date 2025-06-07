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
    public partial class accounts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");
        public accounts()
        {
            InitializeComponent();
            disp_data();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Account_Table(Student_Number,Password,First_Name,Last_Name,Section) VALUES ('" + ID_Num.Text + "','" + password.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            VOTING_SYSTEM log = new VOTING_SYSTEM();
            this.Hide();
            log.Show();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Account_Table WHERE Student_Number = '" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Account_Table";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void accounts_Load(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Account_Table SET Password='" + password.Text + "', First_Name='" + textBox1.Text + "',Last_Name='" + textBox2.Text + "',Section='" + textBox3.Text + "' WHERE Student_Number='" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void sea_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Account_Table where Student_Number='" + ID_Num.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
