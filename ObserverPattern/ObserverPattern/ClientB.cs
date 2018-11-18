using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ClientB : IClient
    {
        public void update(IStore store)
        {
            if (!(store is Store))
            {
                return;
            }

            if ((store as Store).State == 0 || (store as Store).State >= 2)
            {
                Console.Write("ClientB: Reacted to the event.\n");
            }
        }
    }
}
