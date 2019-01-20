using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern_AbstractClass
{
    class MiniCooper : AutoBase
    {
        public override int Id => 1;
        public override string Name => "mini cooper";
        public override void Start()
        {
            Console.WriteLine("minicooper has started");
        }

        public override void Stop()
        {
            Console.WriteLine("minicooper hast stopped");
        }
    }
}
