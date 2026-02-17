namespace ACT_FOOD_ORDER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_login = new Button();
            txt_username = new TextBox();
            label1 = new Label();
            txt_password = new TextBox();
            btn_register = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_login.Location = new Point(72, 285);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(214, 35);
            btn_login.TabIndex = 2;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(72, 166);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(214, 29);
            txt_username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(118, 70);
            label1.Name = "label1";
            label1.Size = new Size(112, 47);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(72, 229);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(214, 29);
            txt_password.TabIndex = 5;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_register.Location = new Point(72, 338);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(214, 35);
            btn_register.TabIndex = 6;
            btn_register.Text = "register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 575);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_register);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(txt_username);
            panel2.Controls.Add(txt_password);
            panel2.Location = new Point(497, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 501);
            panel2.TabIndex = 7;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(126, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 109);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(911, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private Label label1;
        private TextBox txt_password;
        private Button btn_register;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label2;
    }
}
