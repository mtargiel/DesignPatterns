using AbstractFactory.EngineFactory;

namespace AbstractFactory.CarFactory
{
    internal class Fiat500 : ICar
    {
        public string Name { get; }
        public IEngine Engine { get; set; }

        public Fiat500(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
           return string.Format($"{Name}, {Engine.Capacity}L, fuel: {Engine.Fuel}, {Engine.HorsePower}HP");
        }
    }
}
