namespace AbstractFactory.CarFactory
{
    public interface ICarFactory
    {
        ICar CreatePand();
        ICar CreateFiat500();

    }
}
