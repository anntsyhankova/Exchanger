using Exchanger.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchanger
{
    public partial class LoginForm : Form
    {
        private UserController userController = new UserController();
        private ReceiptController receiptController = new ReceiptController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            entity.User user = new entity.User(loginField.Text, passwordField.Text);
            try
            {
                if (userController.validateUser(user))
                {
                    receiptController.openRateFormFromLoginForm(this);
                }
                else { throw new Exception(); }
            }
            catch (Exception) {
                MessageBox.Show("Invalid login/password");
            }
        }

        Point lastPoint;

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userController.openRegistrationForm(this);
        }
    }
}
