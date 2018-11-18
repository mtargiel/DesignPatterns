namespace AbstractFactory.CarFactory
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateFiat500()
        {
            return new Fiat500("Fiat 500");
        }

        public ICar CreatePand()
        {
           return new Panda("Fiat Panda");
        }
    }
}
