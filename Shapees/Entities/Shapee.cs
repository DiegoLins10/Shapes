using Shapees.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapees.Entities
{
    abstract class Shapee
    {
        public Color Color { get; set; }


        public Shapee(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
