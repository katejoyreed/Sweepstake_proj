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


        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            if (contestants.ContainsKey(contestant.registrationNumber))
            {
                contestant = new Contestant();
            }
            else 
            {
                contestants.Add(contestant.registrationNumber, contestant);
            }
            
        }

        public void ContestantPickWinner()
        {
            List<Contestant> _contestants = new List<Contestant>(contestants.Values);
            Random rand = new Random();
            Contestant randContestant = _contestants[rand.Next(_contestants.Count)];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.firstName} {contestant.lastName}; " +
                $"contestant email: {contestant.emailAddress}; registration number: " +
                $"{contestant.registrationNumber}"); 
        }
    }
}
