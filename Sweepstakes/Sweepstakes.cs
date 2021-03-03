using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        public Sweepstakes(string name)
        {
            this.name = name;
            Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void _Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            contestants.Add(contestant.registrationNumber, contestant) ;
        }

        public void ContestantPickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
