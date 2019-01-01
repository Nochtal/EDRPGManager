using EdrpgDLL.Abstract;

namespace EdrpgDLL.FixedComponents
{
    public class PowerDistributor : iFixedComponent
    {
        public PowerDistributor(char _class, double powerCost, int cost, int size, int strength, int floatingBonus, int agilityBonus, int hitBonus, int shieldBonus)
        {
            Class = _class;
            PowerCost = powerCost;
            Cost = cost;
            Size = size;
            Strength = strength;
            Name = "Power Distributor";
            Effects = new int[] { floatingBonus, agilityBonus, hitBonus, shieldBonus };
            Military = false;
        }

        public char Class { get { return Class; } set { Class = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        /// <summary>
        /// List of bonuses based on Class and Size of Power Distributor
        /// i: bonus type, range
        /// 0: Floating, 0-2
        /// 1: Agility, 0-1
        /// 2: To Hit, 0-1
        /// 3: Shields, 0 or 5
        /// </summary>
        public int[] Effects { get { return Effects; } set { Effects = value; } }

        public void FloatingBonus(int bonus) { Effects[0] = bonus; }
        public int FloatingBonus() { return Effects[0]; }

        public void AgilityBonus(int bonus) { Effects[1] = bonus; }
        public int AgilityBonus() { return Effects[1]; }

        public void ToHitBonus(int bonus) { Effects[2] = bonus; }
        public int ToHitBonus() { return Effects[2]; }

        public void ShieldsBonus(int bonus) { Effects[3] = bonus; }
        public int ShieldsBonus() { return Effects[3]; }

        public double getValue()
        {
            return -1;
        }
    }
}