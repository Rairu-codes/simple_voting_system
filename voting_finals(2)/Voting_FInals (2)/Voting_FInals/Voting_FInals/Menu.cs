using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_FInals
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            vote_menu VM = new vote_menu();
            this.Hide();
            VM.Show();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tally_btn_Click(object sender, EventArgs e)
        {
            tally VT = new tally();
            this.Hide();
            VT.Show();
        }

        private void win_btn_Click(object sender, EventArgs e)
        {
            winner w = new winner();
            this.Hide();
            w.Show();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            VOTING_SYSTEM log = new VOTING_SYSTEM();
            this.Hide();
            log.Show();
        }
    }
    
}
