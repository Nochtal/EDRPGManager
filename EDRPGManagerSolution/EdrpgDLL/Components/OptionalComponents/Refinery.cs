using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class Refinery : iOptionalComponent
    {
        public Refinery(int miningBonus, char _class, int cost, double powerCost, int size, int strength)
        {
            MiningValueBonus = miningBonus;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Refinery";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int MiningValueBonus { get { return MiningValueBonus; } set { MiningValueBonus = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
