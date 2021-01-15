namespace AirportSimulationSystem.Services.Interfaces
{
    using AirportSimulationSystem.Models.DTOs;
    using System.Collections.Generic;

    public interface IFlightService
    {
        void AddFlight(FlightDTO dto);

        void UpdateFlight(FlightDTO dto);

        void RemoveFlight(int id);

        ICollection<FlightDTO> GetFlights();
    }
}
