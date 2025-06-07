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
    public partial class admin_log : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-261U98HK;Initial Catalog=voting_db;Integrated Security=True");

        public admin_log()
        {
            InitializeComponent();
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
            else if (!ID.Equals("admin") && !pass.Equals("admin"))
            {
                MessageBox.Show("This account is not an Admin Account!", "OH NO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VOTING_SYSTEM log = new VOTING_SYSTEM();
                this.Hide();
                log.Show();
            }

            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Account_Table WHERE Student_Number = '" + ID + "' AND Password = '" + pass + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);


                    if (dt.Rows.Count >= 1)
                    {

                        accounts acc = new accounts();
                        this.Hide();
                        acc.Show();
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
            }

                
           
            
            
            

            


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_log_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
