using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ACT_FOOD_ORDER.Class1;
using static ACT_FOOD_ORDER.Class1.auth;
using Microsoft.Data.Sqlite;

namespace ACT_FOOD_ORDER
{
   
    public partial class frm_signup : Form
    {
        auth AUTH = new auth();
        public frm_signup()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(AUTH.register(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
