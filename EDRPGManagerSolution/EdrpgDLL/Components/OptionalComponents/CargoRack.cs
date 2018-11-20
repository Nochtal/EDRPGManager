using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class CargoRack : iOptionalComponent
    {
        public CargoRack(char _class, int size, int capacity, int cost, int strength)
        {
            Capacity = capacity;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Cargo Rack";
            PowerCost = 0;
            Size = size;
            Strength = strength;
        }

        public int Capacity { get { return Capacity; } set { Capacity = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
