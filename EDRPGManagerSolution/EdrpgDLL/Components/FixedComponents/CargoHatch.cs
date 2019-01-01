using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.FixedComponents
{
    public class CargoHatch : iFixedComponent
    {
        public CargoHatch()
        {
            Class = 'H';
            Size = 1;
            PowerCost = 0.6;
            Strength = 10;
            Cost = 0;
            Name = "Cargo Hatch";
            Military = false;
        }

        public char Class { get { return Class; } set { Class = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public double getValue()
        {
            return Strength;
        }
    }
}