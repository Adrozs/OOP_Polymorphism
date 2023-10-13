using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.GeometryClasses
{
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
}
