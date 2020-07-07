namespace ChatApp
{
    partial class Form1
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
            this.MyChatApp = new System.Windows.Forms.Label();
            this.usernameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RegisterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // MyChatApp
            // 
            this.MyChatApp.AutoSize = true;
            this.MyChatApp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MyChatApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyChatApp.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyChatApp.Location = new System.Drawing.Point(167, 21);
            this.MyChatApp.Name = "MyChatApp";
            this.MyChatApp.Size = new System.Drawing.Size(168, 32);
            this.MyChatApp.TabIndex = 0;
            this.MyChatApp.Text = "MyChatAppLogin";
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernameText.Depth = 0;
            this.usernameText.Hint = "Usernsme..";
            this.usernameText.Location = new System.Drawing.Point(135, 91);
            this.usernameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.SelectedText = "";
            this.usernameText.SelectionLength = 0;
            this.usernameText.SelectionStart = 0;
            this.usernameText.Size = new System.Drawing.Size(239, 23);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Username";
            this.usernameText.UseSystemPasswordChar = false;
            this.usernameText.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordText.Depth = 0;
            this.passwordText.Hint = "Password..";
            this.passwordText.Location = new System.Drawing.Point(135, 154);
            this.passwordText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '\0';
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.Size = new System.Drawing.Size(239, 23);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Password";
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(135, 213);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(101, 46);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Location = new System.Drawing.Point(268, 213);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(106, 46);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyChatApp.Properties.Resources.j7klF;
            this.ClientSize = new System.Drawing.Size(473, 376);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.MyChatApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MyChatAppLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyChatApp;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordText;
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
    }
}

