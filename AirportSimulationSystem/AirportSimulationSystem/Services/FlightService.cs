namespace AirportSimulationSystem.Services
{
    using AirportSimulationSystem.Database;
    using AirportSimulationSystem.Models.DTOs;
    using AirportSimulationSystem.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class FlightService : IFlightService
    {
        private readonly AirportContext _db;

        public FlightService(AirportContext db)
        {
            _db = db;
        }

        public void AddFlight(FlightDTO dto)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<FlightDTO> GetFlights()
        {
            return _db.Flights
                .Include(x => x.Airplane)
                .Include(x => x.City)
                .OrderBy(x => x.Id)
                .Select(x => (FlightDTO)x)
                .ToList();
        }

        public void RemoveFlight(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
