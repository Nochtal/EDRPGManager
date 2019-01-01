using System;
using EdrpgDLL.Abstract;

namespace EdrpgDLL.Concret
{
    /// <summary>
    /// Thrusters are engines that project your ship through normal, sub-light space. Higher quality thrusters improve the speed and agility of your ship, often at a high power cost.
    /// Thrusters are subject to critical hits. If your thrusters are critically damaged you can no longer manoeuver. Your ship will keep travelling in a straight line but cannot avoid incoming fire.
    /// </summary>
    public class Thrusters : iFixedComponent
    {
        public Thrusters(int _size, char _class, double _powerCost, int _strength, int _speedBonus, int _agilityBonus, int _cost)
        {
            Name = "Thrusters";
            Size = _size;
            Class = _class;
            PowerCost = _powerCost;
            Effects = new int[] { _speedBonus, _agilityBonus };
            Cost = _cost;
            Strength = _strength;
        }

        public double PowerCost { get { return PowerCost; } set { PowerCost = value; } }

        public int[] Effects { get { return Effects; } set { Effects = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }

        public bool Military { get { return Military; } set { Military = value; } }

        public int SpeedBonus()
        {
            return Effects[0];
        }

        public int AgilityBonus()
        {
            return Effects[1];
        }

        public double getValue()
        {
            return -1;
        }
    }
}
