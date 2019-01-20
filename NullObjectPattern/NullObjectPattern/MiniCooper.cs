using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class MiniCooper : IAuto
    {
        public int Id => 1;
        public string Name => "mini 1.6";
        public void Start()
        {
            Console.WriteLine("Mini has started");
        }

        public void Stop()
        {
            Console.WriteLine("Mini has stopped");
        }
    }
}
