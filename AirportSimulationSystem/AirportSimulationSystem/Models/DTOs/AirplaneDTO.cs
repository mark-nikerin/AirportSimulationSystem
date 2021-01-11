namespace AirportSimulationSystem.Models.DTOs
{
    using AirportSimulationSystem.Database.Entities;
    using System.ComponentModel;

    public class AirplaneDTO
    {
        [DisplayName("№ самолёта")]
        public int Id { get; set; }

        [DisplayName("Модель")]
        public string Model { get; set; }

        [DisplayName("Дальность")]
        public int Distance { get; set; }

        [DisplayName("Пассажировместимость")]
        public int PassengerCapacity { get; set; }

        [DisplayName("Грузоподъёмность, кг")]
        public int LiftingCapacity { get; set; }

        public static explicit operator AirplaneDTO(Airplane entity)
        {
            return new AirplaneDTO
            {
                Id = entity.Id,
                Model = entity.Model,
                Distance = entity.Distance,
                PassengerCapacity = entity.PassengerCapacity,
                LiftingCapacity = entity.LiftingCapacity
            };
        }
    }
}
