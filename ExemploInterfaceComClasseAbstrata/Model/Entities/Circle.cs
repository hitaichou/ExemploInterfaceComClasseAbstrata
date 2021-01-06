using System;
using System.Globalization;
using ExemploInterfaceComClasseAbstrata.Model.Enums;
using ExemploInterfaceComClasseAbstrata.Model.Entities;

namespace ExemploInterfaceComClasseAbstrata.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = " 
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
