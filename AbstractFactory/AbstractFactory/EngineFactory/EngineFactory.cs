namespace AbstractFactory.EngineFactory
{
    public class EngineFactory : IEngineFactory
    {
        public IEngine CreateDieselEngine(int horsePower, double capacity)
        {
            return new Diesel()
            {
                HorsePower = horsePower,
                Fuel = "ON",
                Capacity = capacity
            };
        }

        public IEngine CreatePetrolEngine(int horsePower, double capacity)
        {
            return new PetrolEngine()
            {
                HorsePower = horsePower,
                Fuel = "PB95",
                Capacity = capacity
            };
        }
    }
}
