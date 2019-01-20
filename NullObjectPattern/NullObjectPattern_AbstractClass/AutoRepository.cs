using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern_AbstractClass
{
    class AutoRepository
    {
        public AutoBase Find(string carName)
        {
            if (carName.Contains("mini"))
                return  new MiniCooper();

            return  AutoBase.NULL;

        }
    }
}
