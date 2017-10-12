using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometryFactory geometryFactory = new GeometryFactory();
            Console.WriteLine("-------------- Object Details-----------------");
            IGeometry geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(9);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(3);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(9);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(3);
            Console.WriteLine("-------------- Object Count-----------------");
            int ObjectCount = geometryFactory.ObjectCount();
            Console.WriteLine("Total objects created: " + ObjectCount);
 
            Console.ReadLine();
        }
    }
}
