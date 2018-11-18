namespace AbstractFactory.EngineFactory
{
    public interface IEngineFactory
    {
        IEngine CreateDieselEngine(int horsePower, double capacity);
        IEngine CreatePetrolEngine(int horsePower, double capacity);
    }
}
