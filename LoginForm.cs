using scale.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scale
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string pass = password.Text.Trim();
            User user = new User();
            DataTable dt = user.Select(username,pass);
        
            if (dt.Rows.Count > 0 )
            {
                user.UserName = username;
                user.Id = (int)dt.Rows[0]["id"];
                MainForm mainForm = new MainForm();
                mainForm.SetUser(user);

                mainForm.FormClosed += (s, args) => this.Close();

                this.Hide();
                mainForm.Show();
                
            }
            else
            {
                label5.Text = "Incorrect password or username";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
            }

        }

        
    }
}
