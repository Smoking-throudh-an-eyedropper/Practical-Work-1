using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class VotingSystem
    {
        private List<User> ListUser;
        private List<Voting> ListVoice;
        static void Main(string[] args)
        {
            VotingSystem votingSystem = new VotingSystem();
            votingSystem.addUser();
            votingSystem.addVoice();
            votingSystem.getResults();
        }
        public void getResults()
        {
            var Results = ListVoice.ToList();
            Results.ForEach(r => Console.WriteLine(r));
        }
        public void addVoice()
        {
            Console.WriteLine("Чтобы довать voice введите 1, если этого не требуется введите 0");
            int addV = Convert.ToInt16(Console.ReadLine());
            if (addV == 1)
            {
                ListVoice.Add(new Voting(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToUInt16(Console.Read()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));
                Console.WriteLine("Чтобы закончить добавление элементов в список введите [0]");
                addV = Convert.ToInt16(Console.ReadLine());
            }
            else
            {
                if (addV == 0)
                {
                    Console.WriteLine("Добавление элементов в список завершено");
                }
            }
        }
        public void addUser()
        {
            Console.WriteLine("Чтобы довать user введите 1, если этого не требуется введите 0");
            int addU = Convert.ToInt16(Console.ReadLine());
            if (addU == 1)
            {
                ListUser.Add(new User(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));
                Console.WriteLine("Чтобы закончить добавление элементов в список введите [0]");
                addU = Convert.ToInt16(Console.ReadLine());
            }
            else
            {
                if (addU == 0)
                {
                    Console.WriteLine("Добавление элементов в список завершено");
                }
            }
        }
    }
}
