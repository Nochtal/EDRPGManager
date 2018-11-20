using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class PRLimpetController : iOptionalComponent
    {
        public PRLimpetController(int maxAcitve, int miningBonus, char _class, int cost, double powerCost, int size, int strength)
        {
            MaxActiveDrones = maxAcitve;
            MiningValuebonus = miningBonus;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Prospector Limpet Controller";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int MaxActiveDrones { get { return MaxActiveDrones; } set { MaxActiveDrones = value; } }

        public int MiningValuebonus { get { return MiningValuebonus; } set { MiningValuebonus = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
