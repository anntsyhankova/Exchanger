using Exchanger.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.repository
{
    class UserRepository
    {
        public static ArrayList userList = new ArrayList();
        public UserRepository() {
            userList.Add(new User("admin", "admin"));
        }

        public void CreateUser(User user)  {
                if (!userList.Contains(user)) { userList.Add(user); }
                else throw new Exception(""); 
        }

        public Boolean IsValidUser(User user) {
            return userList.Contains(user);
        }
    }
}
