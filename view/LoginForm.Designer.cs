
namespace Exchanger
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.LinkLabel();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.registrationLabel);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 450);
            this.panel1.TabIndex = 0;
            // 
            // registrationLabel
            // 
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registrationLabel.LinkColor = System.Drawing.Color.White;
            this.registrationLabel.Location = new System.Drawing.Point(201, 332);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(133, 37);
            this.registrationLabel.TabIndex = 6;
            this.registrationLabel.TabStop = true;
            this.registrationLabel.Text = "Registration";
            this.registrationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLabel_LinkClicked);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterButton.Location = new System.Drawing.Point(99, 326);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(96, 36);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordField.Location = new System.Drawing.Point(144, 238);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(155, 30);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginField.Location = new System.Drawing.Point(144, 185);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(155, 30);
            this.loginField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "password:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(77, 185);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 25);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "login:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.AuthorizationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 60);
            this.panel2.TabIndex = 0;
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AuthorizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(382, 60);
            this.AuthorizationLabel.TabIndex = 0;
            this.AuthorizationLabel.Text = "Authorization";
            this.AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.LinkLabel registrationLabel;
        private System.Windows.Forms.Button enterButton;
    }
}