using System;
using AbstractFactory.CarFactory;
using AbstractFactory.EngineFactory;

namespace Customer
{
    class Program
    {
        static void Main()
        {
            ICarFactory carFactory = new CarFactory();
            IEngineFactory engineFactory = new EngineFactory();

            var fiat500 = carFactory.CreateFiat500();
            var panda = carFactory.CreatePand();

            fiat500.Engine = engineFactory.CreateDieselEngine(120, 1.4);
            panda.Engine = engineFactory.CreatePetrolEngine(200, 3.0);

            Console.WriteLine(fiat500.ToString());
            Console.WriteLine(panda.ToString());

            Console.Read();

        }
    }
}
