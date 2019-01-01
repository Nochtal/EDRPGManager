using EdrpgDLL.Abstract;

namespace EdrpgDLL.Components.OptionalComponents
{
    public class MRPackage : iOptionalComponent
    {
        public MRPackage(string moduleGP, int extraSP, char _class, int cost, int size)
        {
            ModuleGroupsProtected = moduleGP;
            ExtraStrengthPoints = extraSP;
            Class = _class;
            Cost = cost;
            Military = true;
            Name = "Module Reinforcement Package";
            PowerCost = 0;
            Size = size;
            Strength = 0;
        }

        public string ModuleGroupsProtected { get { return ModuleGroupsProtected; } set { ModuleGroupsProtected = value; } }

        public int ExtraStrengthPoints { get { return ExtraStrengthPoints; } set { ExtraStrengthPoints = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public double getValue()
        {
            return ExtraStrengthPoints;
        }
    }
}
