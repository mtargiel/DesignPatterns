using AbstractFactory.EngineFactory;

namespace AbstractFactory.CarFactory
{
    public interface ICar
    {
        string Name { get; }
        IEngine Engine { get; set; }
        string ToString();
    }
}
