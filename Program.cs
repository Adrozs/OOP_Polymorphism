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
            Rectangle rectangle = new Rectangle(rectangleB, rectangleH);
            Square square = new Square(squareB, squareH);
            Circle circle = new Circle(circleRadius);
            Parallelogram parallelogram = new Parallelogram(paralellogramB, paralellogramH);
            Ellips ellips = new Ellips(ellipsRadiusA, ellipsRadiusB);

            // Call all the objects area methods and print out the results
            Console.WriteLine("Rectangle area: " + Math.Round(rectangle.Area(),2));
            Console.WriteLine("Square area: " + Math.Round(square.Area(),2));
            Console.WriteLine("Circle area: " + Math.Round(circle.Area(),2));
            Console.WriteLine("Paralellogram area: " + Math.Round(parallelogram.Area(),2));
            Console.WriteLine("Ellips area: " + Math.Round(ellips.Area(),2));
        }
    }

    // Parent class
    // Making it abstract as all the child classes will override the method in Geometry
    public abstract class Geometry
    {
        public abstract double Area();
 
    }

    public class Rectangle : Geometry
    {
        // Declaring variables 
        private double _sideA;
        private double _sideB;

        // Constructor that takes the input and assigns it to the class' varaibles
        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        // Calculates the area
        public override double Area()
        {
            return _sideA * _sideB;
        }
    }

    public class Square : Geometry
    {
        // Declaring variables
        private double _sideA;
        private double _sideB;

        // Constructor that takes the input and assigns it to the class' varaibles
        public Square(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        // Calculates the area
        public override double Area()
        {
            return _sideA * _sideB;
        }
    }

    public class Circle : Geometry
    {
        // Declares variable
        private double _radius;

        // Assigns input to class' variable
        public Circle(double radius)
        {
            _radius = radius;
        }

        // Calculates area
        public override double Area()
        {
            return (Math.PI * _radius) * _radius;
        }
    }
    public class Parallelogram : Geometry
    {
        // Declaring variables needed to calculate area
        private double _side;
        private double _height;

        // Assigns input to class' variables
        public Parallelogram(double side, double height)
        {
            _side = side;
            _height = height;
        }

        // Calculates area
        public override double Area()
        {
            return _side * _height;
        }
    }

    public class Ellips : Geometry
    {
        // Declaring variables needed to calculate area
        private double _radiusA;
        private double _radiusB;

        // Assigns input to class' variable
        public Ellips(double radiusA, double radiusB)
        {
            _radiusA = radiusA;
            _radiusB = radiusB;
        }

        // Calculates area
        public override double Area()
        {
            return (Math.PI * _radiusA) * _radiusB;
        }
    }
}