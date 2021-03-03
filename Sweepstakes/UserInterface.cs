using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
