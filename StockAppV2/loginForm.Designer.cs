namespace StockAppV2
{
    partial class loginForm
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
            label1 = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            label2 = new Label();
            loginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 150);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(176, 147);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(222, 27);
            usernameText.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(176, 211);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(222, 27);
            passwordText.TabIndex = 1;
            passwordText.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 214);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(167, 292);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(142, 53);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 67);
            label3.Name = "label3";
            label3.Size = new Size(242, 27);
            label3.TabIndex = 3;
            label3.Text = "Enter Login Information";
            // 
            // loginForm
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(label1);
            ImeMode = ImeMode.Disable;
            MaximizeBox = false;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Management System: Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label label2;
        private Button loginBtn;
        private Label label3;
    }
}