using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorBAD
{
    class Airbus321 : Aircraft
    {
        public Airbus321(string callSign) : base(callSign)
        {
            
        }

        public override int Ceiling => 41000;

        public override bool IsTrailingGapAcceptable()
        {
            throw new NotImplementedException();
        }
    }
}
