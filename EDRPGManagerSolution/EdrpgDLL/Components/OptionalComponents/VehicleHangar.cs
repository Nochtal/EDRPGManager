using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class VehicleHangar : iOptionalComponent
    {
        public VehicleHangar(int bays, int cost, double powerCost, int size, int strength)
        {
            VehicleBays = bays;
            Class = 'H';
            Cost = cost;
            Military = false;
            Name = "Vehicle Hangar";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int VehicleBays { get { return VehicleBays; } set { VehicleBays = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return VehicleBays;
        }
    }
}