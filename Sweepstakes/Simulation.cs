using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            
            string userSelectedManager = UserInterface.GetUserInput("Press 0 for stack manager or 1 for queue manager");

            if (userSelectedManager == "0")
            {
                SweepstakesStackManager stackManager = new SweepstakesStackManager();
                MarketingFirm marketingFirm = new MarketingFirm(stackManager);
            }
            else if (userSelectedManager == "1")
            {
                SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                MarketingFirm marketingFirm = new MarketingFirm(queueManager);
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                SelectManager();
            }
        }
    }
}
