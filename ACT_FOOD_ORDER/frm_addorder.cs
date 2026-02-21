using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_FOOD_ORDER
{
    public partial class frm_addorder : Form
    {
        public frm_addorder()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_dashboard f = new frm_dashboard();
            f.Show();
            this.Close();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            frm_dashboard f = new frm_dashboard();
            f.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
