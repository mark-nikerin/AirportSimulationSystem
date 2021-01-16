using System.Drawing;
using System.Windows.Forms;

namespace AirportSimulationSystem.Models.Modelling
{
    public class ModellingObject
    {
        public PictureBox Model;

        public ModellingObject(string type, System.Drawing.Size size, Point startPoint)
        {
            if (Model == null )
                Model = new PictureBox();

            Model.Image = Image.FromFile(Application.StartupPath + $@"\Resources\{type}.png");
            Model.SizeMode = PictureBoxSizeMode.Zoom;
            Model.Size = size;
            Model.Location = startPoint;
        }
    }
}
