namespace ACT_FOOD_ORDER
{
    partial class frm_dashboard
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
            panel2 = new Panel();
            btn_systeminfo = new Button();
            btn_logout = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            listView1 = new ListView();
            panel11 = new Panel();
            txt_total = new TextBox();
            panel7 = new Panel();
            btn_Clear = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            panel8 = new Panel();
            btn_confirm = new Button();
            panel4 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel10 = new Panel();
            panel9 = new Panel();
            cmb_order = new ComboBox();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(btn_systeminfo);
            panel2.Controls.Add(btn_logout);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1293, 84);
            panel2.TabIndex = 0;
            // 
            // btn_systeminfo
            // 
            btn_systeminfo.BackColor = Color.Red;
            btn_systeminfo.FlatStyle = FlatStyle.Flat;
            btn_systeminfo.ForeColor = Color.White;
            btn_systeminfo.Location = new Point(1051, 24);
            btn_systeminfo.Name = "btn_systeminfo";
            btn_systeminfo.Size = new Size(103, 43);
            btn_systeminfo.TabIndex = 6;
            btn_systeminfo.Text = "System Information";
            btn_systeminfo.UseVisualStyleBackColor = false;
            btn_systeminfo.Click += btn_systeminfo_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(1173, 22);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(103, 43);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(33, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(867, 399);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(listView1);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(txt_total);
            panel5.Location = new Point(906, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 629);
            panel5.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(7, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(380, 517);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Red;
            panel11.Location = new Point(0, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(387, 40);
            panel11.TabIndex = 2;
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.Red;
            txt_total.Font = new Font("Segoe UI", 22F);
            txt_total.ForeColor = SystemColors.Control;
            txt_total.Location = new Point(7, 582);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(380, 47);
            txt_total.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_Clear);
            panel7.Controls.Add(btn_delete);
            panel7.Controls.Add(btn_add);
            panel7.Location = new Point(36, 738);
            panel7.Name = "panel7";
            panel7.Size = new Size(863, 60);
            panel7.TabIndex = 0;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.ActiveCaption;
            btn_Clear.Location = new Point(671, 11);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(184, 43);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Green;
            btn_delete.Location = new Point(481, 11);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(184, 43);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Red;
            btn_add.Location = new Point(13, 11);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(461, 43);
            btn_add.TabIndex = 0;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_confirm);
            panel8.Location = new Point(906, 738);
            panel8.Name = "panel8";
            panel8.Size = new Size(390, 62);
            panel8.TabIndex = 0;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.Red;
            btn_confirm.Location = new Point(7, 11);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(380, 43);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(panel10);
            panel4.Location = new Point(33, 515);
            panel4.Name = "panel4";
            panel4.Size = new Size(866, 219);
            panel4.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(138, 68);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Red;
            panel10.Location = new Point(2, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(865, 40);
            panel10.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Red;
            panel9.Controls.Add(cmb_order);
            panel9.Location = new Point(36, 107);
            panel9.Name = "panel9";
            panel9.Size = new Size(864, 40);
            panel9.TabIndex = 0;
            // 
            // cmb_order
            // 
            cmb_order.FormattingEnabled = true;
            cmb_order.Items.AddRange(new object[] { "testing1", "testing2", "testing3", "testing4" });
            cmb_order.Location = new Point(310, 3);
            cmb_order.Name = "cmb_order";
            cmb_order.Size = new Size(121, 23);
            cmb_order.TabIndex = 7;
            // 
            // frm_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 806);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frm_dashboard";
            Text = "frm_dashboard";
            Load += frm_dashboard_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Button btn_delete;
        private Button btn_add;
        private Panel panel11;
        private TextBox txt_total;
        private Panel panel8;
        private Button btn_confirm;
        private Panel panel4;
        private Panel panel10;
        private Panel panel9;
        private Button btn_logout;
        private Button btn_Clear;
        private Button btn_systeminfo;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox cmb_order;
        public ListView listView1;
    }
}