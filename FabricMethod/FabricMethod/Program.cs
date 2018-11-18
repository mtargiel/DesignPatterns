using System;
namespace ConsoleAppDemoSyntax
{
    interface ILogistic
    {
        ITransport CreateTransport();
    }
    interface ITransport
    {
        string Deliver();
    }
    class Boat : ITransport
    {
        public string Deliver()
        {
            return "paddle, paddle";
        }
    }
    class Truck : ITransport
    {
        public string Deliver()
        {
            return "brum, brum";
        }
    }
    class SeaLogistic : ILogistic
    {
        public ITransport CreateTransport()
        {
            return new Boat();
        }
    }
    class RoadLogistic : ILogistic
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILogistic seaLogistic = new SeaLogistic();
            ILogistic truckLogistic = new RoadLogistic();
            ITransport boat = seaLogistic.CreateTransport();
            ITransport truck = truckLogistic.CreateTransport();
            Console.WriteLine(boat.Deliver());
            Console.WriteLine(truck.Deliver());
            Console.ReadKey();
        }
    }
}