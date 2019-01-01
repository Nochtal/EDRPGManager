using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class FuelScoop : iOptionalComponent
    {
        public FuelScoop(int safeScoop, int emergencyScoop, char _class, int cost, double powerCost, int size, int strength)
        {
            SafeScoop = safeScoop;
            EmergencyScoop = emergencyScoop;
            Class = _class;
            Military = false;
            Name = "Fuel Scoop";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        /// <summary>
        /// -1 represents Auto success.
        /// </summary>
        public int SafeScoop { get { return SafeScoop; } set { SafeScoop = value; } }

        /// <summary>
        /// -1 represents Auto success.
        /// </summary>
        public int EmergencyScoop { get { return EmergencyScoop; } set { EmergencyScoop = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return SafeScoop;
        }
    }
}
