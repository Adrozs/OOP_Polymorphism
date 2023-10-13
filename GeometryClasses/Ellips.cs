using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.GeometryClasses
{
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
