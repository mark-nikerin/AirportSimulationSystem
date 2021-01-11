namespace AirportSimulationSystem.Services.Interfaces
{
    using AirportSimulationSystem.Models.DTOs;
    using System.Collections.Generic;

    public interface IAirplaneService
    {
        void AddAirplane(AirplaneDTO dto);

        void RemoveAirplane(int airplaneId);

        ICollection<AirplaneDTO> GetAirplanes();
    }
}
