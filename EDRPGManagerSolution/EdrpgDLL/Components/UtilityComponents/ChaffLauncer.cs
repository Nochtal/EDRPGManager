using EdrpgDLL.Components.Abstract;

namespace EdrpgDLL.Components.UtilityComponents
{
    /// <summary>
    /// 
    /// </summary>
    class ChaffLauncer : iUtilityComponent
    {
        /// <summary>
        /// Only the default Chaff Launcher is available.
        /// </summary>
        public ChaffLauncer()
        {
            Description = "You can activate your Chaff Launcher as an Equipment Action. You gain a +4 defence bonus against gimbled and automated turret weapon attacks until your next turn starts.";
            Ammo = 6;
            Class = 'D';
            Cost = 8500;
            Military = false;
            Name = "Chaff Launcher";
            PowerCost = 0.2;
            Size = 0;
            Strength = 1;
        }

        public string Description { get { return Description; } set { Description = value; } }

        public int Ammo { get { return Ammo; } set { Ammo = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
