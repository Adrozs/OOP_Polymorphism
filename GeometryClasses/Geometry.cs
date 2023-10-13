using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.GeometryClasses
{
    // Parent class
    // Making it abstract as all the child classes will override the Area method
    public abstract class Geometry
    {
        public abstract double Area();

    }
}
