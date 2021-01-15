namespace AirportSimulationSystem.Services
{
    using AirportSimulationSystem.Database;
    using AirportSimulationSystem.Database.Entities;
    using AirportSimulationSystem.Models.DTOs;
    using AirportSimulationSystem.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class CityService : ICityService
    {
        private readonly AirportContext _db;

        public CityService(AirportContext db)
        {
            _db = db;
        }

        public void AddCity(CityDTO dto)
        {
            var city = new City
            {
                Name = dto.Name,
                Distance = dto.Distance
            };

            _db.Add(city);
            _db.SaveChanges();
        }

        public void UpdateCity(CityDTO dto)
        {
            var city = _db.Cities.FirstOrDefault(x => x.Id == dto.Id);

            if (city == null) return;

            city.Name = dto.Name;
            city.Distance = dto.Distance;

            _db.Cities.Update(city);
            _db.SaveChanges();
        }

        public void RemoveCity(int id)
        {
            var city = _db.Cities.FirstOrDefault(x => x.Id == id);

            if (city == null) return;

            _db.Remove(city);
            _db.SaveChanges();
        }

        public ICollection<CityDTO> GetCities()
        {
            return _db.Cities
                .OrderBy(x => x.Id)
                .Select(x => (CityDTO)x)
                .ToList();
        }
    }
}
