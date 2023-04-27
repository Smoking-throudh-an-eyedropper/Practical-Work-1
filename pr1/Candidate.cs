using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Candidate : User
    {
        private uint _voice;
        public uint Voice
        {
            get { return _voice; }
            private set { _voice = value; }
        }
        public Candidate(string name, string login, string password, uint voice): base(name, login, password)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Voice = voice;
        }
        public uint addVoice (Candidate candidate)
        {
            Console.WriteLine("Name:", candidate.Name);
            Console.WriteLine("Введите количество голосов:");
            uint voices = Convert.ToUInt32(Console.ReadLine());
            candidate.Voice += voices;
            return candidate.Voice;
        }
        void Display()
        {
            Console.WriteLine("Candidate");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Voice:{Voice}");
        }
    }
}
