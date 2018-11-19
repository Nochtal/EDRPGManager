using EdrpgDLL.Abstract;

namespace EdrpgDLL.Concret
{
    public class LifeSupport : iFixedComponent
    {
        public LifeSupport(double time, double powerCost, char _class, int cost, int size, int strength)
        {
            Time = time;
            PowerCost = powerCost;
            Class = _class;
            Cost = cost;
            Size = size;
            Strength = strength;
            Name = "Life Support";
        }

        public double Time { get { return Time; } set { Time = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
