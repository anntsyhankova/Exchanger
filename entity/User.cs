using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.entity
{
    public class User
    {
        private String login;
        private String password;

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public User() {
        }

        public String getLogin() { return this.login; }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Login == user.Login &&
                   Password == user.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1678800870;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }

        public override string ToString()
        {
            return this.Login;
        }
    }
}
