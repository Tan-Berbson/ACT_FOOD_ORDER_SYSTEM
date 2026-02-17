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
    public partial class frm_orderconfirmandpayment : Form
    {
        public frm_orderconfirmandpayment()
        {
            InitializeComponent();
        }

        private void frm_orderconfirmandpayment_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Order", 130);
            listView1.Columns.Add("Add-ons", 130);
            listView1.Columns.Add("Total", 110);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string dinetype = "";
            string paymentmethod = "";

            if (radioButton1.Checked)
                dinetype = "Eat In";

            if (radioButton2.Checked)
                dinetype = "Take Out";

            if (radioButton3.Checked)
                paymentmethod = "Cash";

            if (radioButton4.Checked)
                paymentmethod = "GCash";

            if (radioButton5.Checked)
                paymentmethod = "PayMaya";

            frm_reciept receipt = new frm_reciept(
      listView1.Items,
      txt_customername.Text,
      txt_Ordernumber.Text,
      dinetype,
      paymentmethod,
      txt_total.Text
  );

            receipt.Show();


        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_customername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ordernumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
