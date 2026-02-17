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
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(79, 231);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(214, 23);
            btn_login.TabIndex = 2;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(79, 145);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(214, 23);
            txt_username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 86);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(79, 187);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(214, 23);
            txt_password.TabIndex = 5;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(79, 276);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(214, 23);
            btn_register.TabIndex = 6;
            btn_register.Text = "register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(383, 450);
            Controls.Add(btn_register);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private Label label1;
        private TextBox txt_password;
        private Button btn_register;
    }
}
