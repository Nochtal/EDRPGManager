using EdrpgDLL.Components.FixedComponents;
using EdrpgDLL.Components.OptionalComponents;
using EdrpgDLL.Concret;
using EdrpgDLL.FixedComponents;
using EdrpgDLL.Ships.Abstract;
using EdrpgDLL.Ships.Mounts;
using System;

namespace EdrpgDLL.Ships.Spacecraft
{
    public class Adder : iShip
    {
        public Adder()
        {
            Category = "Small Spacecraft";
            Manufacturer = "Zorgon Peterson";
            Dimensions = "L 31.5m x W 28.8m x H 9.6m";
            LandingPad = "Small";
            Crew = 2;
            Passengers = 1;

            Agility = 8;
            Speed = 6;
            Range = "Explorer (50% Bonus)";
            Fuel = "8T (80LY)";
            Hull = 75;

            Bulkheads = new Bulkheads("Adder", 35120, 79030);
            ReinforcedAlloys = true;
            Weapons = new WeaponMount[] { new WeaponMount(1), new WeaponMount(1), new WeaponMount(2) };
            Utilities = new UtilityMount[] { new UtilityMount(0), new UtilityMount(0) };
            Fixed = new FixedMount[] { new FixedMount(3, "Power Plant", new PowerPlants('E', 3, 8, 30, 6200)),
                                       new FixedMount(3, "Thrusters", new Thrusters(3, 'E', 2.48, 30, 0, 0, 6270)),
                                       new FixedMount(3, "FSD", new FrameShiftDrive('E', 3, 25, 0.24, 9, 6270)),
                                       new FixedMount(1, "Life Support", new LifeSupport(5, 0.32, 'E', 520, 1, 15)),
                                       new FixedMount(2, "Power Distributor", new PowerDistributor('E', 0.36, 1450, 2, 20,
                                            0, 0, 0, 0)),
                                       new FixedMount(3, "Sensors", new Sensors(3, 'E', 0.18, 1450, 15, new int[]       
                                            { 0,0 })) };
            FuelTank = new FixedMount(3, "FuelTank", new FuelTank('C', 3, 8, 7060));
            CargoHatch = new FixedMount(1, "Cargo Hatch", new CargoHatch());
            Optionals = new OptionalMount[] { new OptionalMount(3), new OptionalMount(3), new OptionalMount(2), new OptionalMount(2), new OptionalMount(1) };
        }

        public string Category { get { return Category; } set { Category = value; } }

        public string Manufacturer { get { return Manufacturer; } set { Manufacturer = value; } }

        public string Dimensions { get { return Dimensions; } set { Dimensions = value; } }

        public string LandingPad { get { return LandingPad; } set { LandingPad = value; } }

        public int Crew { get { return Crew; } set { Crew = value; } }

        public int Passengers { get { return Passengers; } set { Passengers = value; } }

        public int Agility { get { return Agility; } set { Agility = value; } }

        public int Speed { get { return Speed; } set { Speed = value; } }

        public string Range { get { return Range; } set { Range = value; } }

        public string Fuel { get { return Fuel; } set { Fuel = value; } }

        public int Hull { get { return Hull; } set { Hull = value; } }

        public int Shields { get { return Shields; } set { Shields = value; } }

        public Bulkheads Bulkheads { get { return Bulkheads; } set { Bulkheads = value; } }

        public bool ReinforcedAlloys { get { return ReinforcedAlloys; } set { ReinforcedAlloys = value; } }

        public WeaponMount[] Weapons { get { return Weapons; } set { Weapons = value; } }

        public UtilityMount[] Utilities { get { return Utilities; } set { Utilities = value; } }

        public FixedMount[] Fixed { get { return Fixed; } set { Fixed = value; } }

        public FixedMount FuelTank { get { return FuelTank; } set { FuelTank = value; } }

        public FixedMount CargoHatch { get { return CargoHatch; } set { CargoHatch = value; } }

        public OptionalMount[] Optionals { get { return Optionals; } set { Optionals = value; } }

        public int ShipCost()
        {
            int sum = CargoHatch.Fixed.Cost + FuelTank.Fixed.Cost;
            if (ReinforcedAlloys) sum += Bulkheads.ReinforcedAlloy;
            else sum += Bulkheads.MilitaryGradeComposite;
            foreach (WeaponMount wm in Weapons)
            {
                if (wm.Weapon != null) sum += wm.Weapon.Cost;
            }
            foreach (UtilityMount um in Utilities)
            {
                if (um.Utility != null) sum += um.Utility.Cost;
            }
            foreach (FixedMount fm in Fixed)
            {
                if (fm.Fixed != null) sum += fm.Fixed.Cost;
            }
            foreach (OptionalMount om in Optionals)
            {
                if (om.Optional != null) sum += om.Optional.Cost;
            }
            return sum;
        }

        public void SwitchBulkheads()
        {
            if (ReinforcedAlloys)
            {
                ReinforcedAlloys = false;
                Hull = 112;
                ApplyHullModifiers();
            }
            else
            {
                ReinforcedAlloys = true;
                Hull = 75;
                ApplyHullModifiers();
            }
        }

        public void ApplyHullModifiers()
        {
            foreach (OptionalMount om in Optionals)
            {
                if (om.Optional.GetType() == typeof(HRPackage))
                {
                    /// Look for cleaner way to do this.
                    HRPackage temp = (HRPackage)om.Optional;
                    Hull += temp.ExtraHullPoints;
                }
            }
        }

        public void ApplyShieldModifiers()
        {
            
        }
    }
}
