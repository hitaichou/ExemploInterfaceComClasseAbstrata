using ExemploInterfaceComClasseAbstrata.Enums;
namespace ExemploInterfaceComClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        //Declaro que o método é abstrato
        public abstract double Area();

    }
}
