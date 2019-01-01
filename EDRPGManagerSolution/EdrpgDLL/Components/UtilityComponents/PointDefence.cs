using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class PointDefence: iUtilityComponent
    {
        /// <summary>
        /// Only the default Point Defence is Available.
        /// </summary>
        public PointDefence()
        {
            Ammo = 10;
            Description = "Automatically activates when a missile, torpedo or mine would hit you. Roll a D10. On an even score, the missile or mine is destroyed.";
            Class = 'E';
            Cost = 18546;
            Military = false;
            Name = "Point Defence";
            PowerCost = 0.2;
            Size = 0;
            Strength = 1;
        }

        public int Ammo { get { return Ammo; } set { Ammo = value; } }

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
        /// <returns>Ammo as a double</returns>
        public double getValue()
        {
            return Ammo;
        }
    }
}
