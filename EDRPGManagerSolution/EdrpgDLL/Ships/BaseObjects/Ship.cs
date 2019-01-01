using System;
using EdrpgDLL.Components.FixedComponents;
using EdrpgDLL.Components.OptionalComponents;
using EdrpgDLL.Ships.Abstract;
using EdrpgDLL.Ships.Mounts;
using System.Linq;
using EdrpgDLL.Components.UtilityComponents;

namespace EdrpgDLL.Ships.BaseObjects
{
    public class Ship : iShip
    {
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

        private int BaseHull { get { return BaseHull; } set { BaseHull = value; } }

        private int ReinforcedHull { get { return ReinforcedHull; } set { ReinforcedHull = value; } }

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

        public void SetHullValues(int baseHull, int reinforcedHull)
        {
            BaseHull = baseHull;
            ReinforcedHull = reinforcedHull;
        }

        public void SwitchBulkheads()
        {
            if (ReinforcedAlloys)
            {
                ReinforcedAlloys = false;
                Hull = ReinforcedHull;
                ApplyHullModifiers();
            }
            else
            {
                ReinforcedAlloys = true;
                Hull = BaseHull;
                ApplyHullModifiers();
            }
        }

        public void ApplyHullModifiers()
        {
            foreach (OptionalMount om in Optionals)
            {
                if (om.Optional.GetType() == typeof(HRPackage))
                {
                    Hull += (int)om.Optional.getValue();
                }
            }
        }

        public void ApplyShieldModifiers()
        {
            bool shielded = false;
            foreach (OptionalMount om in Optionals)
            {
                if (om.Optional.GetType() == typeof(ShieldGenerator))
                {
                    Shields = (int)om.Optional.getValue();
                    shielded = true;
                    break;
                }
            }
            if (shielded)
            {
                int tShields = 0;

                foreach (UtilityMount um in Utilities)
                {
                    if (um.Utility.GetType() == typeof(ShieldBooster))
                    {
                        tShields = (int)(Shields * um.Utility.getValue());
                    }
                }
                Shields += tShields;
            }
            else
            {
                Shields = 0;
            }
        }
    }
}
