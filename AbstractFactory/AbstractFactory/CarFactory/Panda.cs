using AbstractFactory.EngineFactory;

namespace AbstractFactory.CarFactory
{
    internal class Panda : ICar
    {
        public string Name { get; }
        public IEngine Engine { get; set; }

        public Panda(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format($"{Name}, {Engine.Capacity}L, fuel: {Engine.Fuel}, {Engine.HorsePower}HP");
        }
    }
}
