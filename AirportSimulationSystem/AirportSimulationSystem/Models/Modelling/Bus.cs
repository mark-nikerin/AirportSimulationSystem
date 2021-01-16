using System.Drawing;

namespace AirportSimulationSystem.Models.Modelling
{
    public class Bus : ModellingObject
    {
        public int Capacity { get; set; } = 100;

        public Bus(System.Drawing.Size size, Point startPoint) : base("bus", size, startPoint)
        {

        }
    }
}
