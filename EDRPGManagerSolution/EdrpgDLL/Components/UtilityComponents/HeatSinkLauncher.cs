using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class HeatSinkLauncher: iUtilityComponent
    {
        /// <summary>
        /// Only the default Heat Sink Launcher is available.
        /// </summary>
        public HeatSinkLauncher()
        {

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
    }
}
