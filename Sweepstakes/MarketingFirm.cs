﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : ISweepstakesManager
    {
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInput("Name your sweepstakes: "));
        }


    }
}
