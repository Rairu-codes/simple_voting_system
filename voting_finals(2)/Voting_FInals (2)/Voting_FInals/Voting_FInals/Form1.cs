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
    public partial class VOTING_SYSTEM : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public static string passID;

        public VOTING_SYSTEM()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            this.Hide();
            reg.Show();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void acc_btn_Click(object sender, EventArgs e)
        {
            admin_log ad = new admin_log();
            this.Hide();
            ad.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string ID = ID_Num.Text;
            string pass = password.Text;

            if (ID.Equals(String.Empty))
            {
                MessageBox.Show("Fill up the Empty Field", "OH NO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pass.Equals(String.Empty))
            {
                MessageBox.Show("Fill up the Empty Field", "OH NO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Account_Table WHERE Student_Number = '" + ID_Num.Text + "' AND Password = '" + password.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    Menu men = new Menu();
                    this.Hide();
                    men.Show();
                }
                else
                {
                    if (!ID.Equals(String.Empty) && !pass.Equals(String.Empty))
                    {
                        MessageBox.Show(this, "Please Check your username/password or You are not yet registered", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }

            catch
            {
                if (!ID.Equals(String.Empty) && !pass.Equals(String.Empty))
                {
                    MessageBox.Show(this, "You are not yet registered", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            passID = ID_Num.Text;

        }

        private void ID_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VOTING_SYSTEM_Load(object sender, EventArgs e)
        {

        }
    }
}
