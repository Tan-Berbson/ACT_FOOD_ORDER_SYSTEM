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
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();

        }

        private void btn_systeminfo_Click(object sender, EventArgs e)
        {
            frm_systeminfo f = new frm_systeminfo();
            f.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_order.SelectedItem == null)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            string order = cmb_order.SelectedItem.ToString();

            int total = 100; // base price of item

            List<string> addons = new List<string>();

            if (checkBox1.Checked)
            {
                addons.Add("Order1");
                total += 20;
            }

            if (checkBox2.Checked)
            {
                addons.Add("Order2");
                total += 20;
            }

            string checkboxes = string.Join(", ", addons);

            ListViewItem ordersum = new ListViewItem(order);
            ordersum.SubItems.Add(checkboxes);
            ordersum.SubItems.Add("₱" + total.ToString());

            listView1.Items.Add(ordersum);

            ComputeGrandTotal(); // update total textbox
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Order", 130);
            listView1.Columns.Add("Add-ons", 130);
            listView1.Columns.Add("Total", 110);
        }
        private void ComputeGrandTotal()
        {
            int grandTotal = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                string value = item.SubItems[2].Text.Replace("₱", "");
                grandTotal += Convert.ToInt32(value);
            }

            txt_total.Text = "₱" + grandTotal.ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string total = txt_total.Text;
            frm_orderconfirmandpayment f2 = new frm_orderconfirmandpayment(total);

            foreach (ListViewItem item in listView1.Items)
            {
                f2.listView1.Items.Add((ListViewItem)item.Clone());
            }

            f2.Show();
            this.Hide();
        }

        private void btn_adds_Click(object sender, EventArgs e)
        {
            frm_addorder f = new frm_addorder();
            f.ShowDialog();
            this.Hide();
        }
    }
}
