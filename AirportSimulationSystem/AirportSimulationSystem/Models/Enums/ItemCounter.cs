using System;
using System.Collections.Generic;
using System.Text;

namespace AirportSimulationSystem.Models.Enums
{
    public static class ItemCounter
    {
        public static int AirportBuilding = 1;

        public static int Runway = 1;

        public static int PassengerTerminal = 1;

        public static int CargoTerminal = 1;

        public static int Garage = 5;

        public static int Hangar = 3;

        public static void reset()
        {
            AirportBuilding = 1;
            Runway = 1;
            PassengerTerminal = 1;
            CargoTerminal = 1;
            Garage = 5;
            Hangar = 3;
        }
    }

}
