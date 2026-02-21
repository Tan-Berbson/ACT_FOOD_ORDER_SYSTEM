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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_login = new Button();
            txt_username = new TextBox();
            label1 = new Label();
            txt_password = new TextBox();
            btn_register = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F);
            btn_login.Location = new Point(562, 310);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(257, 35);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(562, 191);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(257, 29);
            txt_username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(631, 78);
            label1.Name = "label1";
            label1.Size = new Size(112, 47);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(562, 261);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(257, 29);
            txt_password.TabIndex = 5;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 12F);
            btn_register.Location = new Point(562, 361);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(257, 35);
            btn_register.TabIndex = 6;
            btn_register.Text = "Sign Up";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(562, 238);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(562, 167);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 7;
            label2.Text = "User name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(911, 575);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
        private Label label2;
    }
}
