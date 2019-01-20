using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern 
{
    class BMW335 : IAuto
    {
        public int Id => 2;

        public string Name => "BMW 335Xi";

        public void Start()
        {
            Console.WriteLine("BMW has started");
        }

        public void Stop()
        {
            Console.WriteLine("BMW has stopped");
        }
    }
}
