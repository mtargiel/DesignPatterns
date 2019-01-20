using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoRep = new AutoRepository();
            AutoBase auto1 = autoRep.Find("mini");

            auto1.Start();
            auto1.Stop();

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
