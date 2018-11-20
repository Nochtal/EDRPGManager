namespace EdrpgDLL.Ships.Abstract
{
    public interface iShip
    {
        /// <summary>
        /// Ships come in one of three categories: small, medium, or large.
        /// </summary>
        string Category { get; set; }
        /// <summary>
        /// Company that designs and manufactures the ship
        /// </summary>
        string Manufacturer { get; set; }
        /// <summary>
        /// Length x Width x Height in meters.
        /// Example: L 31.5m x W 28.8m x H 9.6m
        /// </summary>
        string Dimensions { get; set; }
        /// <summary>
        /// A ship requires a minimum size of landing pad, often corresponding
        /// to the category of the ship: small, medium, or large.
        /// </summary>
        string LandingPad { get; set; }
        /// <summary>
        /// Shows the maximum number of Crew for ship
        /// </summary>
        int Crew { get; set; }
        /// <summary>
        /// Shows maximum number of passengers (not including pilot) without
        /// the addition of crew quarters
        /// </summary>
        int Passengers { get; set; }

        /// <summary>
        /// Agility of ship. Added to Spaceship Piloting score
        /// when determining your ship's defence.
        /// </summary>
        int Agility { get; set; }
        /// <summary>
        /// How fast the ship's thrusters can move the ship.
        /// A score of 0 means the ship can travel about 200 metres per second.
        /// A score of 10 is about 400 metres per second.
        /// </summary>
        int Speed { get; set; }
        /// <summary>
        /// This is the maximum range of the ship's Frame Shift Drive.
        /// Explorer type ship receives a 50% bonus to the range provided by FSD.
        /// Standard ranged ships receive no bonus.
        /// </summary>
        string Range { get; set; }
        /// <summary>
        /// Shows the size of the fuel tank in tonnage and light year range.
        /// One ton of fuel can take you 10LY.
        /// </summary>
        string Fuel { get; set; }
        /// <summary>
        /// The amount of damage a ship can takebefore being destroyed.
        /// </summary>
        int Hull { get; set; }
        /// <summary>
        /// Shields are an optional component. If a Shield Generator is not
        /// equipped, Shields are 0.
        /// </summary>
        int Shields { get; set; }

        int ShipCost();

        void SwitchBulkheads();

        void ApplyHullModifiers();

        void ApplyShieldModifiers();
    }
}
