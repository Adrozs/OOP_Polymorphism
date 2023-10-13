using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.GeometryClasses
{
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
}
