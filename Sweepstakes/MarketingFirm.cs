using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : ISweepstakesManager
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInput("Name your sweepstakes: "));
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = manager.GetSweepstakes();
            return sweepstakes;
        }

    }
}
