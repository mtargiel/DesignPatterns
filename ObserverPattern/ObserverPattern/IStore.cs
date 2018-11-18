using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IStore
    {
        void attach(IClient client);

        void detach(IClient client);

        void notify();
    }
}
