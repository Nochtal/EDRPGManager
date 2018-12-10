using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    public class ShieldBooster: iUtilityComponent
    {
        public ShieldBooster(double shieldBonus, char _class, int cost, int powerCost)
        {
            ShieldBonus = shieldBonus;
            Description = string.Format("Gain a {0}% boost to your Shield score.", shieldBonus * 100);
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Shield Booster";
            PowerCost = powerCost;
            Size = 0;
            Strength = 1;
        }

        public double ShieldBonus { get { return ShieldBonus; } set { ShieldBonus = value; } }

        public string Description { get { return Description; } set { Description = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
