

namespace AirportSimulationSystem.Database.Entities
{
    using System;

    public class Flight
    { 
        public int Id { get; set; }

        public string FlightNumber { get; set; }

        public string Tittle { get; set; }

        public bool IsArrival { get; set; }

        public DateTime Time { get; set; }

        public int RegistryNumber { get; set; }

        public int CityId { get; set; }

        public int AirplaneId { get; set; }

        public int SoldTicketsAmount { get; set; }

        public virtual City City { get; set; }

        public virtual Airplane Airplane { get; set; }
    }
}
