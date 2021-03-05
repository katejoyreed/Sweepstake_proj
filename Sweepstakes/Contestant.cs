using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : UserInterface, IObservable<Contestant>
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        List<IObserver<Contestant>> observers = new List<IObserver<Contestant>>();

        public Contestant()
        {
            firstName = GetUserInput("What is your first name?");
            lastName = GetUserInput("What is your last name?");
            emailAddress = GetUserInput("Please enter your email address:");
            Random _random = new Random();
            int randomKey = _random.Next();
            registrationNumber = randomKey;
        }


        public IDisposable Subscribe(IObserver<Contestant> observer)
        {
            if (! observers.Contains(observer))
            {
                observers.Add(observer);
            }
            
        }
       
    }
}
