using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class User
    {
        private string _name;
        private string _login;
        private string _password;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Login
        {
            get { return _login; }
            private set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }
        public User(string name, string login, string password)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Name = name;
            Login = login;
            Password = password;
        }
        public bool enter()
        {
            Console.WriteLine("Введите логин:");
            string enterLogin = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите пароль:");
            string enterPassword = Convert.ToString(Console.ReadLine());
            if (enterLogin == Login && enterPassword == Password)
                return true;
            else
                return false;
        }
        void Display()
        {
            Console.WriteLine("User");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Login:{Login}");
            Console.WriteLine($"Password:{Password}");
        }
    }
}
