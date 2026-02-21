namespace ACT_FOOD_ORDER
{
    partial class frm_reciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reciept));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            panel3 = new Panel();
            btn_confirm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 57);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(111, 4);
            label4.Name = "label4";
            label4.Size = new Size(147, 47);
            label4.TabIndex = 10;
            label4.Text = "Jollibee";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(27, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 532);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 35);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 12;
            label1.Text = "Customer Receipt";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 484);
            listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_confirm);
            panel3.Location = new Point(24, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 74);
            panel3.TabIndex = 4;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.Green;
            btn_confirm.FlatStyle = FlatStyle.Popup;
            btn_confirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirm.ForeColor = SystemColors.Control;
            btn_confirm.Location = new Point(1, 6);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(275, 59);
            btn_confirm.TabIndex = 1;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // frm_reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(335, 679);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_reciept";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_reciept";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Panel panel3;
        private Button btn_confirm;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel4;
        private Label label1;
    }
}