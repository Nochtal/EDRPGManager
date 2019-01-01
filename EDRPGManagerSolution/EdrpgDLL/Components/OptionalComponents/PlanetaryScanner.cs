using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class PlanetaryScanner : iOptionalComponent
    {
        public PlanetaryScanner(string notes, char _class, int cost, string name, double powerCost, int strength)
        {
            Notes = notes;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = name;
            PowerCost = powerCost;
            Size = 1;
            Strength = strength;
        }

        public string Notes { get { return Notes; } set { Notes = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return PowerCost;
        }
    }
}
