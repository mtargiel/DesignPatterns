using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Store : IStore
    {
        public int State { get; set; }

        private List<IClient> _observers = new List<IClient>();

        public void attach(IClient client)
        {
            Console.Write("Store: Attached an client.\n");
            this._observers.Add(client);
        }

        public void detach(IClient client)
        {
            foreach (var elem in _observers)
            {
                if (elem == client)
                {
                    _observers.Remove(client);
                    Console.Write("Store: Detached an client.\n");
                    break;
                }
            }
        }

        public void notify()
        {
            Console.Write("Store: Notifying observers...\n");

            foreach (var observer in _observers)
            {
                observer.update(this);
            }
        }

        public void someBusinessLogic()
        {
            Console.Write("\nSubject: I'm doing something important.\n");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.Write("Store: My state has just changed to: " + this.State + "\n");
            this.notify();
        }
    }

}
