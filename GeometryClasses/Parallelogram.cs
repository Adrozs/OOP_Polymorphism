using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.GeometryClasses
{
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
}
