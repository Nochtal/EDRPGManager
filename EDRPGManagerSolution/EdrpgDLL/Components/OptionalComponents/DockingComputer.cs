using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class DockingComputer : iOptionalComponent
    {
        public DockingComputer()
        {
            Description = "Docks at any station with flight control (almost all of them. 99% chance of successful dock.";
            Class = 'E';
            Cost = 4500;
            Military = false;
            Name = "Docking Computer";
            PowerCost = 0.39;
            Size = 1;
            Strength = 10;
        }

        public string Description { get { return Description; } set { Description = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return PowerCost;
        }
    }
}
