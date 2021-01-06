using System;
using System.Globalization;
using ExemploInterfaceComClasseAbstrata.Model.Enums;
using ExemploInterfaceComClasseAbstrata.Model.Entities;

namespace ExemploInterfaceComClasseAbstrata.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        
        //Sobrescria do método abstrato Area na superclasse
        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
