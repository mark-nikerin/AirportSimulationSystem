namespace AirportSimulationSystem.Models.DTOs
{
    using AirportSimulationSystem.Database.Entities;
    using System.ComponentModel;

    public class FlightDTO
    {
        [DisplayName("№ рейса")]
        public int Id { get; set; }

        [DisplayName("Рейс")]
        public string FlightNumber { get; set; }

        [Browsable(false)]
        public bool IsArrival { get; set; }

        [DisplayName("Тип")]
        public string FlightType { get; set; }

        [DisplayName("Название")]
        public string Tittle { get; set; }

        [DisplayName("Время")]
        public string Time { get; set; }

        [DisplayName("Стойка\nрегистрации")]
        public int RegistryNumber { get; set; }

        [DisplayName("Проданные\nбилеты")]
        public int SoldTicketsAmount { get; set; }

        [Browsable(false)]
        public int CityId { get; set; }

        [Browsable(false)]
        public int AirplaneId { get; set; }

        [Browsable(false)]
        public string AirplaneModel { get; set; }

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
                Tittle = entity.Tittle,
                Time = entity.Time.ToString("H:mm"),
                RegistryNumber = entity.RegistryNumber,
                SoldTicketsAmount = entity.SoldTicketsAmount,
                CityId = entity.CityId,
                AirplaneId = entity.AirplaneId,
                AirplaneModel = entity.Airplane.Model
            };
        }
    }
}
