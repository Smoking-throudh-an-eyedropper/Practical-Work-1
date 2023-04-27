using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr1
{
    internal class Elector : User
    {
        private bool _voted;
        private string _vote;
        public bool Voted
        {
            get { return _voted; }
            private set { _voted = value; }
        }
        public string Vote
        {
            get { return _vote; }
            private set { _vote = value; }
        }
        public Elector(string name, string login, string password, bool voted) : base (name, login, password)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Voted = voted;
        }
        public bool isVote()
        {
            Console.WriteLine("Проголосовал: да / нет");
            string result = Convert.ToString(Console.ReadLine());
            if (result == "да")
                return Voted = true;
            else
                return Voted = false;
        }
        public void vote()
        {
            Console.WriteLine("Голос:");
            Vote = Convert.ToString(Console.Read());
            Console.WriteLine("");
        }
    }
}
