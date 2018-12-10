using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class ECM : iUtilityComponent
    {
        /// <summary>
        /// Only the default ECM is available.
        /// </summary>
        public ECM()
        {
            Description = "You gain a continual +4 defence bonus against Seeker Missile attacks.";
            Class = 'D';
            Cost = 12500;
            Military = false;
            Name = "Electronic Counter Measure";
            PowerCost = 0.2;
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
    }
}
