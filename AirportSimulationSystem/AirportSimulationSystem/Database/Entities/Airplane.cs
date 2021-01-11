namespace AirportSimulationSystem.Database.Entities
{
    using System.Collections.Generic;

    public class Airplane
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int Distance { get; set; }

        public int PassengerCapacity { get; set; }

        public int LiftingCapacity { get; set; }

        public virtual HashSet<Flight> Flights { get; set; }

        public Airplane()
        {
            Flights = new HashSet<Flight>();
        }
    }
}
