using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern_AbstractClass
{
    class BMW335 : AutoBase
    {
        public override int Id => 2;
        public override string Name => "BMW 335Xi";
        public override void Start()
        {
            Console.WriteLine("BMW has started");
        }

        public override void Stop()
        {
            Console.WriteLine("BMW has stopped");
        }
    }
}
