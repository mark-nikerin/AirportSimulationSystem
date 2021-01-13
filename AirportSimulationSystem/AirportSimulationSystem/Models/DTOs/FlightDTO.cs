namespace AirportSimulationSystem.Models.DTOs
{
    using AirportSimulationSystem.Database.Entities;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Windows.Forms;

    public class FlightDTO
    {
        [DisplayName("№ рейса")]
        public int Id { get; set; }

        [DisplayName("Рейс")]
        public string FlightNumber { get; set; }

        [Browsable(false)]
        public bool IsArrival { get; set; }

        [DisplayName("Вылет/Прибытие")]
        public string FlightType { get; set; }

        [DisplayName("Название")]
        public string Title { get; set; }

        [DisplayName("Время")]
        public DateTime Time { get; set; }

        [DisplayName("№ стойки регистрации")]
        public int RegistryNumber { get; set; }

        [DisplayName("Число проданных билетов")]
        public int SoldTicketsAmount { get; set; }

        [Browsable(false)]
        public int CityId { get; set; }

        [Browsable(false)]
        public int AirplaneId { get; set; }

        public static explicit operator FlightDTO(Flight entity)
        {
            return new FlightDTO
            {
                Id = entity.Id,
                FlightNumber = entity.FlightNumber,
                IsArrival = entity.IsArrival,
                FlightType = entity.IsArrival 
                ? "Прибытие" 
                : "Вылет",
                Title = entity.Tittle,
                Time = entity.Time,
                RegistryNumber = entity.RegistryNumber,
                SoldTicketsAmount = entity.SoldTicketsAmount,
                CityId = entity.CityId,
                AirplaneId = entity.AirplaneId
            };
        }
    }
}
