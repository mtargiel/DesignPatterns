namespace AbstractFactory.EngineFactory
{
    public interface IEngine
    {
        int HorsePower { get; set; }
        double Capacity { get; set; }
        string Fuel { get; set; }

    }
}
