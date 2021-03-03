using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : UserInterface
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant()
        {
            firstName = GetUserInput("What is your first name?");
            lastName = GetUserInput("What is your last name?");
            emailAddress = GetUserInput("Please enter your email address:");

        }
    }
}
