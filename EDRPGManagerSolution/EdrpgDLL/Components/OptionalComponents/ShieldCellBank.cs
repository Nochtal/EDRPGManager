using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class ShieldCellBank : iOptionalComponent
    {
        public ShieldCellBank(int recharge, int duration, char _class, int cost, double powerCost, int size, int strength)
        {
            RechargeRate = recharge;
            Duration = duration;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Shield Cell Bank";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int RechargeRate { get { return RechargeRate; } set { RechargeRate = value; } }

        public int Duration { get { return Duration; } set { Duration = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
