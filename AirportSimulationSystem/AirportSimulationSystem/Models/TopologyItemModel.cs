using System.Drawing;

namespace AirportSimulationSystem.Models
{
    using AirportSimulationSystem.Models.Enums;

    public class TopologyItemModel
    {
        public TopologyItemType Type { get; set; }

        public Size Size { get; set; } = new Size();

        public Coordinates Coordinates { get; set; } = new Coordinates();

        public int Angle { get; set; } = 0;
    }
}
