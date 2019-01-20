using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorBAD
{
    public abstract class Aircraft
    {
        protected IList<Aircraft> _acknowledgedAircraft = new List<Aircraft>();
        public string CallSign { get; private set; }
        public Aircraft(string callSign)
        {
            CallSign = callSign;
        }

        public void Acknowledges(Aircraft aircraft)
        {
            _acknowledgedAircraft.Add(aircraft);
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            var incomming = (Aircraft)obj;

            return this.CallSign.Equals(incomming.CallSign);
        }

        public abstract int Ceiling { get; }
        public abstract bool IsTrailingGapAcceptable();

        public int Altitude { get; set; }
    }
}
