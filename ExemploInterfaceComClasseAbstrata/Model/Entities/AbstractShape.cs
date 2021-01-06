using ExemploInterfaceComClasseAbstrata.Model.Enums;

namespace ExemploInterfaceComClasseAbstrata.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color color { get; set; }

        public abstract double Area();
    }
}
