using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.FixedComponents
{
    public class Sensors : iFixedComponent
    {
        public Sensors(int size, char _class, double powerCost, int cost, int strength, int[] effects)
        {
            Name = "Sensors";
            Size = size;
            PowerCost = powerCost;
            Class = _class;
            Cost = cost;
            Strength = strength;
            Effects = effects;
            Military = false;
        }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        /// <summary>
        /// i: Bonus Type, range
        /// 0: Initiative, 0-2
        /// 1: Dogfighting, 0-2
        /// 2: General Scan Bonus, 0-5
        /// </summary>
        public int[] Effects { get { return Effects; } set { Effects = value; } }

        public void InitiativeBonus(int bonus) { Effects[0] = bonus; }
        public int InitiativeBonus() { return Effects[0]; }

        public void DogfightingBonus(int bonus) { Effects[1] = bonus; }
        public int DogFightingBonus() { return Effects[1]; }
        
        public void GenScanBonus(int bonus) { Effects[2] = bonus; }
        public int GenScanBonus() { return Effects[2]; }
    }
}
