namespace AirportSimulationSystem.Services
{
    using AirportSimulationSystem.Database;
    using AirportSimulationSystem.Database.Entities;
    using AirportSimulationSystem.Models.DTOs;
    using AirportSimulationSystem.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class AirplaneService : IAirplaneService
    {
        private readonly AirportContext _db;

        public AirplaneService(AirportContext db)
        {
            _db = db;
        }

        public void AddAirplane(AirplaneDTO dto)
        {
            var airplane = new Airplane
            {
                Distance = dto.Distance,
                Model = dto.Model,
                LiftingCapacity = dto.LiftingCapacity,
                PassengerCapacity = dto.PassengerCapacity
            };

            _db.Add(airplane);
            _db.SaveChanges();
        }

        public void UpdateAirplane(AirplaneDTO dto)
        {
            var airplane = _db.Airplanes.FirstOrDefault(x => x.Id == dto.Id);

            if (airplane == null) return;

            airplane.Distance = dto.Distance;
            airplane.Model = dto.Model;
            airplane.LiftingCapacity = dto.LiftingCapacity;
            airplane.PassengerCapacity = dto.PassengerCapacity;

            _db.Airplanes.Update(airplane);
            _db.SaveChanges();
        }

        public void RemoveAirplane(int id)
        {
            var airplane = _db.Airplanes.FirstOrDefault(x => x.Id == id);

            if (airplane == null) return;

            _db.Remove(airplane);
            _db.SaveChanges();
        }

        public ICollection<AirplaneDTO> GetAirplanes()
        {
            return _db.Airplanes
                .OrderBy(x => x.Id)
                .Select(x => (AirplaneDTO)x)
                .ToList();
        }
    }
}
