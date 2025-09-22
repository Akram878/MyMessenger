using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMessenger
{
    internal class User
    {
        // الخصائص مخفية مع Getter/Setter
        private string id;
        private string username;
        private int age;
        private string country;
        private int number;
        private string status;
        private string lastSeen;
        private string password;

        // Properties
        public string Id
        {
            get { return id; }
            private set { id = value; } // لا يمكن تغييره من الخارج
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Status
        {
            get { return status; }
            private set { status = value; }
        }

        public string LastSeen
        {
            get { return lastSeen; }
            private set { lastSeen = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Constructor يستخدم الـProperties
        public User(string username , int number, string password)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            Age = age;
            Country = country;
            Number = number;
            Password = password;
            Status = "Offline";
            LastSeen = "";
        }

        // دوال التحكم بالحالة
        public void Login()
        {
            Status = "Online";
        }

        public void Logout()
        {
            Status = "Offline";
            LastSeen = DateTime.Now.ToString();
        }

        public void SendMessage(User receiver, string message)
        {
            // تطوير لاحقًا
        }

        public bool CheckPassword(string inputPassword)
        {
            return Password == inputPassword;
        }
    }

}
