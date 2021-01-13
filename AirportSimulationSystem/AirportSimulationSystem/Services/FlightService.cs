﻿namespace AirportSimulationSystem.Services
{
    using AirportSimulationSystem.Database;
    using AirportSimulationSystem.Database.Entities;
    using AirportSimulationSystem.Models.DTOs;
    using AirportSimulationSystem.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Configuration;
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
            var city = _db.Cities.FirstOrDefault(x => x.Id == dto.CityId);

            var currentCityName = ConfigurationManager.AppSettings["CurrentCityName"];

            var flight = new Flight
            {
                FlightNumber = dto.FlightNumber,
                IsArrival = dto.IsArrival,
                Tittle = dto.IsArrival
                    ? $"{city.Name} - {currentCityName}"
                    : $"{currentCityName} - {city.Name}",
                Time = dto.Time,
                RegistryNumber = dto.RegistryNumber,
                CityId = dto.CityId,
                AirplaneId = dto.AirplaneId,
                SoldTicketsAmount = dto.SoldTicketsAmount
            };

            _db.Flights.Add(flight);
            _db.SaveChanges();
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
            var flight = _db.Flights.FirstOrDefault(x => x.Id == id);

            if (flight == null) return;

            _db.Flights.Remove(flight);
            _db.SaveChanges();
        }
    }
}
