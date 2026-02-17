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
    public partial class frm_systeminfo : Form
    {
        public frm_systeminfo()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_dashboard f = new frm_dashboard();
            f.Show();
            this.Hide();
        }
    }
}
