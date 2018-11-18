using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunShop();

            Console.Read();
        }

        public static void RunShop()
        {
            var store = new Store();
            var o1 = new ClientA();
            store.attach(o1);
            var o2 = new ClientB();
            store.attach(o2);
            store.someBusinessLogic();
            store.someBusinessLogic();
            store.detach(o2);
            store.someBusinessLogic();
        }
    }
}
