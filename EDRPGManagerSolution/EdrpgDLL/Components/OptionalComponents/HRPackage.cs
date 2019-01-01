using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class HRPackage : iOptionalComponent
    {
        public HRPackage(int extraHP, char _class, int cost, int size, int strength)
        {
            ExtraHullPoints = extraHP;
            Class = _class;
            Cost = cost;
            Military = true;
            Name = "Hull Reinforcement Package";
            PowerCost = 0;
            Size = size;
            Strength = strength;
        }

        public int ExtraHullPoints { get { return ExtraHullPoints; } set { ExtraHullPoints = value; } }

        public char Class { get { return Class; } set { Class = value; } }
        
        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return ExtraHullPoints;
        }
    }
}
