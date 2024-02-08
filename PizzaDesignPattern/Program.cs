namespace PizzaDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePizza bp1 = new ExtraCheese(new ExtraVeggies(new BreadPizzaBase()));
            Console.WriteLine("Cost of pizza is {0}" ,bp1.Cost());
            BasePizza bp2 = new ExtraVeggies(new WheatPizzaBase());
            Console.WriteLine("Cost of pizza is {0}", bp2.Cost());
        }
    }
}