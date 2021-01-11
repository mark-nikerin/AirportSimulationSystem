namespace AirportSimulationSystem.Models.DTOs
{
    using AirportSimulationSystem.Database.Entities;
    using System.ComponentModel;

    public class CityDTO
    {
        [DisplayName("№ города")]
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Расстояние до города, км")]
        public int Distance { get; set; }

        public static explicit operator CityDTO(City entity)
        {
            return new CityDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Distance = entity.Distance
            };
        }
    }
}
