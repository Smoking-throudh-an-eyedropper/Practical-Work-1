using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr1
{
    internal class Voting : Candidate
    {
        private string _title;
        private string _nameCandidate;
        public string Titel
        {
            get { return _title; }
            private set { _title = value; }
        }
        public string NameCandidate
        {
            get { return _nameCandidate; }
            private set { _nameCandidate = value; }
        }
        public Voting(string name, string login, string password, uint voice, string titel, string nameCandidate) : base(name, login, password, voice)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Titel = titel;
            NameCandidate = nameCandidate;
        }
    }
}
