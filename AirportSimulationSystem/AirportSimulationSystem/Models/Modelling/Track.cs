using System.Drawing;

namespace AirportSimulationSystem.Models.Modelling
{
    public class Track : ModellingObject
    {
        public int Capacity { get; set; } = 100;

        public Track(System.Drawing.Size size, Point startPoint) : base("track", size, startPoint)
        {

        }
    }
}
