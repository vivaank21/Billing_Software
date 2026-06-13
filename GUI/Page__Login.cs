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
using Billing_Software.Connection;

namespace Billing_Software.GUI
{
    public partial class Page__Login : Form
    {
        public Page__Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectiontoDB con = new ConnectiontoDB();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl__users WHERE UserName = @usn AND Password = @pass", con.GetConnection);
                cmd.Parameters.Add("@usn", SqlDbType.VarChar).Value = textBox_username.Text.Trim();
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBox_password.Text.Trim();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOMETHING WENT WRONG" + ex);
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox__showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox__showpass.Checked)
            {
                textBox_password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true; // Hide password
            }

        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
