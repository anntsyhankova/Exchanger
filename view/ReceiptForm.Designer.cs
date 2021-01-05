
namespace Exchanger
{
    partial class ReceiptForm
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
            this.responce = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.responce);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 453);
            this.panel1.TabIndex = 1;
            // 
            // responce
            // 
            this.responce.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.responce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.responce.Location = new System.Drawing.Point(0, 83);
            this.responce.MaximumSize = new System.Drawing.Size(0, 300);
            this.responce.Name = "responce";
            this.responce.Size = new System.Drawing.Size(382, 300);
            this.responce.TabIndex = 7;
            this.responce.Text = "Here should be text";
            this.responce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.Location = new System.Drawing.Point(0, 413);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(382, 40);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.ReceiptLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 83);
            this.panel2.TabIndex = 0;
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.ReceiptLabel.ForeColor = System.Drawing.Color.White;
            this.ReceiptLabel.Location = new System.Drawing.Point(0, 0);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(382, 83);
            this.ReceiptLabel.TabIndex = 0;
            this.ReceiptLabel.Text = "Receipt";
            this.ReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BackButton;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceiptForm";
            this.Text = "Receipt";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ReceiptLabel;
        private System.Windows.Forms.Label responce;
    }
}