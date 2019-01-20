using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoRep = new AutoRepository();
            IAuto auto1 = autoRep.Find(1);
            auto1.Start();
            auto1.Stop();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
