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
    public partial class RegistrationForm : Form
    { 
        private UserController userController = new UserController();
    
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void registrateButton_Click(object sender, EventArgs e)
        {
            try
            {
                userController.saveUser(new entity.User(loginField.Text, passwordField.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Such user is already registrated.");
            }
            finally
            {
                userController.openLoginForm(this);
            }
        }
    }
}
