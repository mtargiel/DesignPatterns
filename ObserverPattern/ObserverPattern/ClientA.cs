using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ClientA : IClient
    {
        public void update(IStore store)
        {
            if (!(store is Store))
            {
                return;
            }

            if ((store as Store).State < 3)
            {
                Console.Write("ClientA: Reacted to the event.\n");
            }
        }
    }
}
