using System;
using System.Windows.Forms;

namespace ACT_FOOD_ORDER
{
    public partial class frm_reciept : Form
    {
        public frm_reciept(
            ListView.ListViewItemCollection items,
            string customerName,
            string orderNumber,
            string dineType,
            string paymentMethod,
            string total)
        {
            InitializeComponent();

            listBox1.Items.Clear();

            listBox1.Items.Add("        ACT FOOD ORDER");
            listBox1.Items.Add("================================");
            listBox1.Items.Add($"Order No : {orderNumber}");
            listBox1.Items.Add($"Customer : {customerName}");
            listBox1.Items.Add($"Date     : {DateTime.Now:MM/dd/yyyy hh:mm tt}");
            listBox1.Items.Add($"Type     : {dineType}");
            listBox1.Items.Add($"Payment  : {paymentMethod}");
            listBox1.Items.Add("--------------------------------");

            foreach (ListViewItem item in items)
            {
                string order = item.SubItems[0].Text;
                string addons = item.SubItems[1].Text;
                string itemTotal = item.SubItems[2].Text;

                // Align item name and price
                listBox1.Items.Add($"{order,-20}{itemTotal,10}");

                if (!string.IsNullOrWhiteSpace(addons))
                {
                    listBox1.Items.Add($"   + {addons}");
                }
            }

            listBox1.Items.Add("--------------------------------");
            listBox1.Items.Add($"TOTAL:{"",15}{total}");
            listBox1.Items.Add("================================");
            listBox1.Items.Add("Thank you!");

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frm_dashboard f = new frm_dashboard();
            f.Show();
            this.Close();

        }
    }
}
