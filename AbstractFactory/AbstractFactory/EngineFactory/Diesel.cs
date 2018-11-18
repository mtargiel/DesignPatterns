namespace AbstractFactory.EngineFactory
{
    internal class Diesel : IEngine
    {
        public int HorsePower { get; set; }
        public double Capacity { get; set; }
        public string Fuel { get; set; }

    }
}
