using AirportSimulationSystem.Models.DTOs;
using System.Collections.Generic;

namespace AirportSimulationSystem.Services.Interfaces
{
    public interface ICityService
    {
        void AddCity(CityDTO dto);

        void UpdateCity(CityDTO dto);

        void RemoveCity(int id);

        ICollection<CityDTO> GetCities();
    }
}
