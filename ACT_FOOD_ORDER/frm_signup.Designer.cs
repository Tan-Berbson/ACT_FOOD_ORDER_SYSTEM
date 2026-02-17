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
            label1 = new Label();
            txt_password = new TextBox();
            btn_back = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(95, 140);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(179, 23);
            txt_username.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(95, 225);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(179, 23);
            btn_register.TabIndex = 1;
            btn_register.Text = "register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 84);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Sign Up";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(95, 175);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(179, 23);
            txt_password.TabIndex = 3;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(95, 270);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 23);
            btn_back.TabIndex = 4;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // frm_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(403, 450);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(txt_username);
            Name = "frm_signup";
            Text = "frm_signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Button btn_register;
        private Label label1;
        private TextBox txt_password;
        private Button btn_back;
    }
}