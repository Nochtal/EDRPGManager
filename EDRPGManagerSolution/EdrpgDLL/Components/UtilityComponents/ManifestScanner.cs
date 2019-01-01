using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class ManifestScanner: iUtilityComponent
    {
        public ManifestScanner(int bonus, char _class, int cost, double powerCost)
        {
            Description = string.Format("Allows you to determine the hyperspace destination of a ship that has just launched. You gain a +{0} bonus to your Systems check when you do so.", bonus);
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Manifest Scanner";
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
        /// <returns>-1 to represent not used</returns>
        public double getValue()
        {
            return -1;
        }
    }
}