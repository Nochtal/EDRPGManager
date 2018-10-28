using EdrpgDLL.Abstract;

namespace EdrpgDLL.Concret
{
    public class PowerPlants : iFixedComponent
    {
        /// <summary>
        /// ALl hyperspace-capable ships carry a fusion power plant to generate energy for their systems. Larger and higher quality power plants generate more energy than smaller and lower quality ones. Power plants output is measured in Megawatts (MW). The total power drain of all your ship's equipment cannot exceed the power output of your power plant.
        /// Power plants are subject to critical hits. If a power plant is critically damaged, it shuts down. The equipment on your ship stops working and your Emergency Life Support Systems kick in. If you do not fix the power plant before your Life Support System runs out of power, you will die of cold and suffocation. It is wise to get into a spacesuit before your time is up.
        /// </summary>
        public PowerPlants(char _class, int _size, double _powerGenerated, int _strength, int _cost)
        {
            Name = "Power Plant";
            Class = _class;
            Size = _size;
            Strength = _strength;
            PowerGenerated = _powerGenerated;
            Cost = _cost;
        }

        public double PowerGenerated { get { return PowerGenerated; } set { PowerGenerated = value; } }

        public char Class { get { return Class; } set { Class = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public int Cost { get { return Cost; } set { Cost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public int Strength { get { return Strength; } set { Strength = value; } }
    }
}
