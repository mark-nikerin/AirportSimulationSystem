using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form1() {
            InitializeComponent();
            DoubleBuffered = true;
            Width = 1280;
            Height = 720;
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Выберите файл с топологией",
                Filter = "Файлы JSON (*.json)|*.json"
            };
        }

        private void LoadTopologyButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //var topologyContent = new StreamReader(openFileDialog1.FileName);
                    tabControl1.SelectedIndex++;
                    this.topologyName.Text = openFileDialog1.SafeFileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        } 




        /*private Rectangle _rec = new Rectangle(0, 0, 50, 50);

        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.FillRectangle(Brushes.Aquamarine, _rec);
        }
        protected override void OnMouseDown(MouseEventArgs e) {
            if (e.Button != MouseButtons.Left && IsInsideWindow(e)) return;
            _rec = new Rectangle(e.X, e.Y, 50, 50);
            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            if (e.Button != MouseButtons.Left && IsInsideWindow(e)) return;
            _rec = new Rectangle(e.X - _rec.Width / 2, e.Y - _rec.Height / 2, 50, 50);
            Invalidate();
        }

        private bool IsInsideWindow(MouseEventArgs e)
        {
            var cursor = new Tuple<int,int>(e.X, e.Y);

            return cursor switch
            {
                var (x, y) when x <= Width && y <= Height => true,
                var (x, y) when x >= 0 && y >= 0 => true,
                var (_, _) => false 
            };
        }*/
    }
}