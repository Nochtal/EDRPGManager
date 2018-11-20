using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class FSDInterdictor : iOptionalComponent
    {
        public FSDInterdictor(int pilotingModifer, string sizeLimit, char _class, int cost, double powerCost, int size, int strength)
        {
            PilotingModifer = pilotingModifer;
            SizeLimit = sizeLimit;
            Class = _class;
            Cost = cost;
            Military = false;
            Name = "Frame Shift Drive Interdictor";
            PowerCost = powerCost;
            Size = size;
            Strength = strength;
        }

        public int PilotingModifer { get { return PilotingModifer; } set { PilotingModifer = value; } }

        public string SizeLimit { get { return SizeLimit; } set { SizeLimit = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
