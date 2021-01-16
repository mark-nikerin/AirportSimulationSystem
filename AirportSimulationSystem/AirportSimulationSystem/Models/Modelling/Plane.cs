using System.Drawing;

namespace AirportSimulationSystem.Models.Modelling
{
    public class Plane : ModellingObject
    {
        public Plane(System.Drawing.Size size, Point startPoint) : base("plane", size, startPoint)
        {

        }
    }
}
