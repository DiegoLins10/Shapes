using Shapees.Entities.Enums;
using Shapees.Services;
using System;


namespace Shapees.Entities
{
    class Circle : AbstractShapee
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
