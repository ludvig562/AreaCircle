// Ludvig Revholm Hedman .NET26
using System.Reflection.Metadata;

namespace AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);// make a new object in the class cirkle named circle1 that has the value 5 and sends it to the method 
            Circle circle2 = new Circle(6);

            Console.WriteLine(circle1.GetArea());// call the method GetArea's result for det name circle1 and print it on the screen 
            Console.WriteLine(circle2.GetArea());
        }
    }
}
