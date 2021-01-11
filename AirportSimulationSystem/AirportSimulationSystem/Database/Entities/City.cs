namespace AirportSimulationSystem.Database.Entities
{
    using System.Collections.Generic; 

    public class City
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Distance { get; set; }

        public virtual HashSet<Flight> Flights { get; set; }

        public City()
        {
            Flights = new HashSet<Flight>();
        }
    }
}
