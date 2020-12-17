namespace AirportSimulationSystem.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class TopologyModel
    {
        public string Name { get; set; }

        public ICollection<TopologyItemModel> Items { get; set; } = new List<TopologyItemModel>();

        public Size Size { get; set; } = new Size { Height = 0, Width = 0 };
    }
}
