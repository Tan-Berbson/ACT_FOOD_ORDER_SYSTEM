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
            panel1 = new Panel();
            panel2 = new Panel();
            listBox1 = new ListBox();
            panel3 = new Panel();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 57);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(2, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 541);
            panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(275, 499);
            listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(2, 610);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 65);
            panel3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(275, 59);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(111, 4);
            label4.Name = "label4";
            label4.Size = new Size(147, 47);
            label4.TabIndex = 10;
            label4.Text = "Jollibee";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 46);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 35);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 12;
            label1.Text = "Customer Receipt";
            // 
            // frm_reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 679);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_reciept";
            Text = "frm_reciept";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel4;
        private Label label1;
    }
}