namespace ACT_FOOD_ORDER
{
    partial class frm_systeminfo
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
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btn_back = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 57);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 30);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(4, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 334);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(4, 403);
            panel4.Name = "panel4";
            panel4.Size = new Size(504, 334);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(501, 30);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_back);
            panel6.Location = new Point(7, 743);
            panel6.Name = "panel6";
            panel6.Size = new Size(501, 48);
            panel6.TabIndex = 6;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Red;
            btn_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(5, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(490, 42);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // frm_systeminfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 795);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "frm_systeminfo";
            Text = "frm_systeminfo";
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btn_back;
    }
}