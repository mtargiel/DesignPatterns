using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorBAD
{
    class Embraer190 : Aircraft
    {
        public Embraer190(string callSign) : base(callSign)
        {
            
        }

        public override int Ceiling => 40000;

        public override bool IsTrailingGapAcceptable()
        {
            throw new NotImplementedException();
        }
    }
}
