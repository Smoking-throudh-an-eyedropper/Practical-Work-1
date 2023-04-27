using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr1
{
    internal class Admin : User
    {
        private bool _admineStatus;
        public bool AdminStatus
        {
            get { return _admineStatus; }
            private set { _admineStatus = value; }
        }
        public Admin(string name, string login, string password, bool admineStatus) : base(name, login, password)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            AdminStatus = admineStatus;
        }
        public string CreateUser()
        {
            Console.WriteLine("Создать пользователя");
            User user = new User(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()));
            return $"Вы создали пользователя {user.Name}";
        }
    }
}
