using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.FixedComponents
{
    public class FuelTank : iFixedComponent
    {
        public FuelTank(char _class, int size, int fuelTonnage, int cost)
        {
            Class = _class;
            Size = size;
            PowerCost = 0;
            Name = "Fuel Tank";
            FuelTonnage = fuelTonnage;
            Military = false;
        }

        public char Class { get { return Class; } set { Class = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public int FuelTonnage { get { return FuelTonnage; } set { FuelTonnage = value; } }

        public bool Military { get { return Military; } set { Military = value; } }
    }
}
