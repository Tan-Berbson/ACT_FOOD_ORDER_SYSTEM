namespace ACT_FOOD_ORDER
{
    partial class frm_registercashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registercashier));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_login = new Button();
            btn_register = new Button();
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(460, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 575);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(87, 308);
            label4.Name = "label4";
            label4.Size = new Size(269, 86);
            label4.TabIndex = 9;
            label4.Text = "Jollibee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(91, 293);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 26;
            label5.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(91, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 29);
            textBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(91, 228);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 24;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(91, 157);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 23;
            label2.Text = "User name";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F);
            btn_login.Location = new Point(91, 367);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(257, 35);
            btn_login.TabIndex = 18;
            btn_login.Text = "Register";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 12F);
            btn_register.Location = new Point(91, 417);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(257, 35);
            btn_register.TabIndex = 22;
            btn_register.Text = "Back";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(78, 65);
            label1.Name = "label1";
            label1.Size = new Size(285, 47);
            label1.TabIndex = 20;
            label1.Text = "Register Cashier";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(91, 181);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(257, 29);
            txt_username.TabIndex = 19;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(91, 251);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(257, 29);
            txt_password.TabIndex = 21;
            // 
            // frm_registercashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 575);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Name = "frm_registercashier";
            Text = "frm_registercashier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button btn_login;
        private Button btn_register;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
    }
}