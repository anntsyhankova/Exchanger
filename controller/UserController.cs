using Exchanger.entity;
using Exchanger.repository;
using System;
using System.Windows.Forms;

namespace Exchanger.controller
{
    class UserController
    {
        private UserRepository userRepository = new UserRepository();
        private static LoginForm loginForm;
        private static RegistrationForm registrationForm;
        private static User actualUser;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            registrationForm = new RegistrationForm();
            Application.Run(loginForm);
        }
        public Boolean validateUser(User user) {
            
            Boolean validation = userRepository.IsValidUser(user);
            if (user != null)
            {
                actualUser = user;
            }
            return validation;
        }

        public void saveUser(User user) {
            userRepository.CreateUser(user);
        }

        public void openRegistrationForm(Form sender) {
            sender.Hide();
            registrationForm.Show();
        }

        public void openLoginForm(Form sender) {
            sender.Hide();
            loginForm.Show();
        }

        public User getActualUser() {
            return actualUser;
        }
    }
}
