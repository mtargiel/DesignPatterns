using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class AutoRepository
    {
        List<IAuto> autos;

        public AutoRepository()
        {
            autos = new List<IAuto>()
            {
                new MiniCooper(),
                new BMW335()
            };

        }

        public IAuto Find(int id)
        {
            return autos.Find(x => x.Id == id);
        }
    }
}
