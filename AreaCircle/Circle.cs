using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCircle
{
    internal class Circle
    {
        private int _radius;

        public Circle(int radius)// konstruktor with parametern radius
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI; // Calculate the area of the circle 
        }
    }
}
