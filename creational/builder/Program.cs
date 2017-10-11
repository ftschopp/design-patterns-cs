using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var carBuilderDirector = new CarBuilderDirector(new CarBuilder());
            var car = carBuilderDirector.BuildCar();
        }
    }
}
