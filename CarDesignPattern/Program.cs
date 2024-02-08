namespace CarDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We want custom cars with functionalities such as cars with with/without blue headlights,
            //with/without disk break , with/without power steering ,etc
            Car car = new PowerSteering(new MarutiSuzuki());
            car.Features();
            car.ShowFeatures();
        }
    }
}