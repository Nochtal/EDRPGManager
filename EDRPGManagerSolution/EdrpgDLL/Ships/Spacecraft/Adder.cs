using EdrpgDLL.Components.FixedComponents;
using EdrpgDLL.Concret;
using EdrpgDLL.FixedComponents;
using EdrpgDLL.Ships.BaseObjects;
using EdrpgDLL.Ships.Mounts;

namespace EdrpgDLL.Ships.Spacecraft
{
    public class Adder : Ship
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
            SetHullValues(75, 112);
            Shields = 0;

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
    }
}
