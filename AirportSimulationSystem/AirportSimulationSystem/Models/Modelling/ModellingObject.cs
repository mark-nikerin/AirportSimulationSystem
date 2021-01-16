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

        public void Rotate(float angle)
        {
            var rotatedBmp = new Bitmap(Model.Image.Width, Model.Image.Height);
            var offset = new PointF(Model.Image.Width / 2, Model.Image.Height / 2);
            rotatedBmp.SetResolution(Model.Image.HorizontalResolution, Model.Image.VerticalResolution);
             
            var g = Graphics.FromImage(rotatedBmp);
             
            g.TranslateTransform(offset.X, offset.Y);
             
            g.RotateTransform(angle);
             
            g.TranslateTransform(-offset.X, -offset.Y);
             
            g.DrawImage(Model.Image, new PointF(0, 0));

            Model.Image = rotatedBmp;
        }

        public void MoveTo(Point point)
        {
            Model.Location = point;
        }
    }
}
