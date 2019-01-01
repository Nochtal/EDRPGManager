using System;
using EdrpgDLL.Abstract;

namespace EdrpgDLL.Concret
{
    /// <summary>
    /// 
    /// </summary>
    public class FrameShiftDrive : iFixedComponent
    {
        public FrameShiftDrive(char _class, int _size, int _strength, double _powerCost, int _range, int cost)
        {
            Name = "FSD";
            Range = _range;
            PowerCost = _powerCost;
            Class = _class;
            Size = _size;
            Strength = _strength;
            Cost = cost;
        }

        public int Range { get { return Range; } set { Range = value; } }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }
        
        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Range as double</returns>
        public double getValue()
        {
            return Range;
        }
    }
}
