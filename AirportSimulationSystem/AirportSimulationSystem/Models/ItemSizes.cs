using System;
using System.Collections.Generic;
using System.Text;

namespace AirportSimulationSystem.Models
{
    public static class ItemSizes
    {
        public static Size AirportBuilding = new Size
        {
            Height = 5,
            Width = 8
        };

        public static Size Runway = new Size
        {
            Height = 2,
            Width = 10
        };

        public static Size PassengerTerminal = new Size
        {
            Height = 2,
            Width = 2
        };

        public static Size CargoTerminal = new Size
        {
            Height = 2,
            Width = 2
        };

        public static Size Garage = new Size
        {
            Height = 4,
            Width = 4
        };

        public static Size Hangar = new Size
        {
            Height = 4,
            Width = 4
        };
    }
}
