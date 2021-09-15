using Shapees.Entities.Enums;
using Shapees.Services;
using System;


namespace Shapees.Entities
{
    abstract class AbstractShapee : IShapee
    {
        public Color Color { get; set; }

        protected AbstractShapee(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
