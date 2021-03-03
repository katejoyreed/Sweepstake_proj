using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        public Sweepstakes(string name)
        {
            this.name = name;
            Name = name;
            contestants = new Dictionary<int, Contestant>();
        }
    }
}
