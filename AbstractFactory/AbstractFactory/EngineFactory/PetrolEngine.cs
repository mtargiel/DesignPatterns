namespace AbstractFactory.EngineFactory
{
    internal class PetrolEngine : IEngine
    {
        public int HorsePower { get; set; }
        public double Capacity { get; set; }
        public string Fuel { get; set; }
    }
}
