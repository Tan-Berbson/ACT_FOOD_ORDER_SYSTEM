namespace ACT_FOOD_ORDER
{
    partial class frm_signup
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
            txt_username = new TextBox();
            btn_register = new Button();
            txt_password = new TextBox();
            btn_back = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(72, 168);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(214, 29);
            txt_username.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(72, 273);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(214, 35);
            btn_register.TabIndex = 1;
            btn_register.Text = "register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(72, 229);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(214, 29);
            txt_password.TabIndex = 3;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(72, 331);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(214, 35);
            btn_back.TabIndex = 4;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 575);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(156, 308);
            label4.Name = "label4";
            label4.Size = new Size(147, 47);
            label4.TabIndex = 9;
            label4.Text = "Jollibee";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(126, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 109);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_back);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_register);
            panel2.Controls.Add(txt_password);
            panel2.Controls.Add(txt_username);
            panel2.Location = new Point(495, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 501);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(72, 209);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(72, 148);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 7;
            label2.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(106, 69);
            label5.Name = "label5";
            label5.Size = new Size(155, 47);
            label5.TabIndex = 4;
            label5.Text = "Register";
            // 
            // frm_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(911, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_signup";
            Text = "frm_signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_username;
        private Button btn_register;
        private TextBox txt_password;
        private Button btn_back;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}