using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    class HBLimpetController : iOptionalComponent
    {
        public HBLimpetController( int accuracy, string overRide, char _class, double powerCost, int size, int strength)
        {
            Accuracy = accuracy;
            Override = overRide;
            Class = _class;
            Military = false;
            Name = "Hatch Breaker Limpet Controller";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int Accuracy { get { return Accuracy; } set { Accuracy = value; } }

        /// <summary>
        /// Example: 7(1d10 units). First number is DC on 1d10 to succeed in hack.
        /// If successful, roll number of d10 indicated for how many units of cargo
        /// canisters tumble out of the cargo bay.
        /// </summary>
        public string Override { get { return Override; } set { Override = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
