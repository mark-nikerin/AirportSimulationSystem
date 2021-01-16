using System.ComponentModel;

namespace AirportSimulationSystem.Models.DTOs
{
    public class ModellingFlightDTO
    {
        [DisplayName("Рейс")]
        public string FlightNumber { get; set; }

        [DisplayName("Название")]
        public string Tittle { get; set; }

        [DisplayName("Тип")]
        public string FlightType { get; set; }

        [DisplayName("Время")]
        public string Time { get; set; }

        public static explicit operator ModellingFlightDTO(FlightDTO flightDTO)
        {
            return new ModellingFlightDTO
            {
                FlightNumber = flightDTO.FlightNumber,
                Tittle = flightDTO.Tittle,
                FlightType = flightDTO.FlightType,
                Time = flightDTO.Time
            };
        }
    }
}
