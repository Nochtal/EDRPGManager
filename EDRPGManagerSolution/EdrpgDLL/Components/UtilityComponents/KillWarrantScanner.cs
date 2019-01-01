using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    public class KillWarrantScanner: iUtilityComponent
    {
        public KillWarrantScanner(int bonus, char _class, int cost, int powerCost)
        {
            Description = string.Format("This scanner and communications computer gives you a {0}% bounty reward bonus.", bonus);
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Kill Warrant Scanner";
            PowerCost = powerCost;
            Size = 0;
            Strength = 1;
        }

        public string Description { get { return Description; } set { Description = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Power Cost as double</returns>
        public double getValue()
        {
            return PowerCost;
        }
    }
}
