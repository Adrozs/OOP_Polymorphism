// Adrian Rozsahegyi NET23

using Polymorphism.GeometryClasses;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the shape area calculator.\nYou will now choose several values to calculate " +
                "the area of said shapes.\n\n");

            // Rectangle input
            Console.WriteLine("Rectangle");
            Console.Write("Choose base cm: ");
            double rectangleB = int.Parse(Console.ReadLine());
            Console.Write("Choose height cm: ");
            double rectangleH = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Square input
            Console.WriteLine("Square");
            Console.Write("Choose base cm: ");
            double squareB = int.Parse(Console.ReadLine());
            Console.Write("Choose height cm: ");
            double squareH = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Cirlce input
            Console.WriteLine("Circle");
            Console.Write("Choose radius cm: ");
            double circleRadius = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Paralellogram input
            Console.WriteLine("Paralellogram");
            Console.Write("Choose base cm: ");
            double paralellogramB = int.Parse(Console.ReadLine());
            Console.Write("Choose height cm: ");
            double paralellogramH = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Ellips input
            Console.WriteLine("Ellips");
            Console.Write("Choose the first radius cm: ");
            double ellipsRadiusA = int.Parse(Console.ReadLine());
            Console.Write("Choose the second radius cm: ");
            double ellipsRadiusB = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Creates new object instances of all classes and sends the inputs into their constructors
            Geometry rectangle = new Rectangle(rectangleB, rectangleH);
            Geometry square = new Square(squareB, squareH);
            Geometry circle = new Circle(circleRadius);
            Geometry parallelogram = new Parallelogram(paralellogramB, paralellogramH);
            Geometry ellips = new Ellips(ellipsRadiusA, ellipsRadiusB);

            // Call all the objects area methods and print out the results
            Console.WriteLine("Rectangle area: " + Math.Round(rectangle.Area(),2));
            Console.WriteLine("Square area: " + Math.Round(square.Area(),2));
            Console.WriteLine("Circle area: " + Math.Round(circle.Area(),2));
            Console.WriteLine("Paralellogram area: " + Math.Round(parallelogram.Area(),2));
            Console.WriteLine("Ellips area: " + Math.Round(ellips.Area(),2));
        }
    }
}