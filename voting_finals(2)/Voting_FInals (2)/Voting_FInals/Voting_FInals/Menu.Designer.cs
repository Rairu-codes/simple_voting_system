
namespace Voting_FInals
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vote_btn = new System.Windows.Forms.Button();
            this.tally_btn = new System.Windows.Forms.Button();
            this.win_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vote_btn
            // 
            this.vote_btn.BackColor = System.Drawing.Color.Transparent;
            this.vote_btn.BackgroundImage = global::Voting_FInals.Properties.Resources.gold;
            this.vote_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vote_btn.FlatAppearance.BorderSize = 0;
            this.vote_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_btn.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vote_btn.Location = new System.Drawing.Point(88, 250);
            this.vote_btn.Name = "vote_btn";
            this.vote_btn.Size = new System.Drawing.Size(263, 124);
            this.vote_btn.TabIndex = 6;
            this.vote_btn.Text = "VOTE";
            this.vote_btn.UseVisualStyleBackColor = false;
            this.vote_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // tally_btn
            // 
            this.tally_btn.BackColor = System.Drawing.Color.Transparent;
            this.tally_btn.BackgroundImage = global::Voting_FInals.Properties.Resources.gold;
            this.tally_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tally_btn.FlatAppearance.BorderSize = 0;
            this.tally_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tally_btn.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tally_btn.Location = new System.Drawing.Point(442, 250);
            this.tally_btn.Name = "tally_btn";
            this.tally_btn.Size = new System.Drawing.Size(263, 128);
            this.tally_btn.TabIndex = 7;
            this.tally_btn.Text = "VOTE TALLY";
            this.tally_btn.UseVisualStyleBackColor = false;
            this.tally_btn.Click += new System.EventHandler(this.tally_btn_Click);
            // 
            // win_btn
            // 
            this.win_btn.BackColor = System.Drawing.Color.Transparent;
            this.win_btn.BackgroundImage = global::Voting_FInals.Properties.Resources.gold;
            this.win_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.win_btn.FlatAppearance.BorderSize = 0;
            this.win_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win_btn.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_btn.Location = new System.Drawing.Point(794, 250);
            this.win_btn.Name = "win_btn";
            this.win_btn.Size = new System.Drawing.Size(231, 128);
            this.win_btn.TabIndex = 8;
            this.win_btn.Text = "WINNERS";
            this.win_btn.UseVisualStyleBackColor = false;
            this.win_btn.Click += new System.EventHandler(this.win_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = global::Voting_FInals.Properties.Resources.gold;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(10, 522);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(112, 51);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 77);
            this.label5.TabIndex = 14;
            this.label5.Text = "MENU";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BackgroundImage = global::Voting_FInals.Properties.Resources.gold;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(963, 530);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(110, 37);
            this.login_btn.TabIndex = 37;
            this.login_btn.Text = "BACK TO LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voting_FInals.Properties.Resources.vote_for_blog;
            this.ClientSize = new System.Drawing.Size(1085, 628);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.win_btn);
            this.Controls.Add(this.tally_btn);
            this.Controls.Add(this.vote_btn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1101, 667);
            this.MinimumSize = new System.Drawing.Size(1101, 667);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vote_btn;
        private System.Windows.Forms.Button tally_btn;
        private System.Windows.Forms.Button win_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_btn;
    }
}