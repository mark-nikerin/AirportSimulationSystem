using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.Json;
using System.Windows.Forms;
using AirportSimulationSystem.Database;
using AirportSimulationSystem.Models;
using AirportSimulationSystem.Models.Enums;
using AirportSimulationSystem.Services.Interfaces;
using Size = System.Drawing.Size;

namespace AirportSimulationSystem
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private const int gridSize = 10;
        private static TopologyModel Topology = new TopologyModel();
        private static TopologyItemModel CurrentDraggableItem = new TopologyItemModel();

        private static AirportContext _db;
        private static IAirplaneService _airplaneService;
        private static ICityService _cityService;
        private static IFlightService _flightService;

        public MainForm(AirportContext db, IAirplaneService airplaneService, ICityService cityService, IFlightService flightService)
        {
            InitializeComponent();

            DoubleBuffered = true;
            openFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл с топологией",
                Filter = "Файлы JSON (*.json)|*.json"
            };
            saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                RestoreDirectory = true,
                Title = "Сохраните файл с топологией",
                DefaultExt = ".json",
                Filter = "Файлы JSON (*.json)|*.json"
            };

            CreateGrid(gridSize, gridSize);
            Topology.Size.Height = gridSize;
            Topology.Size.Width = gridSize;

            flightsGridView.Visible = true;
            citiesGridView.Visible = false;
            airplanesGridView.Visible = false;
            SetButtonActive(fligthsButton);
            SetButtonInactive(airplanesButton);
            SetButtonInactive(citiesButton);

            extendedPanel.AllowDrop = true;
            groupBox1.AllowDrop = true;

            _db = db;
            _airplaneService = airplaneService;
            _cityService = cityService;
            _flightService = flightService;
        }

        #region Navigation 

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        }

        #endregion

        #region Topology Builder

        #region Mouse Events

        private void airport_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.AirportBuilding <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.AirportBuilding;
            CurrentDraggableItem.Size = ItemSizes.AirportBuilding;
            currentEffect = DragDropEffects.Copy;

            airport.DoDragDrop(airport.Image, DragDropEffects.Copy);
        }

        private void vpp_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.Runway <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.Runway;
            CurrentDraggableItem.Size = ItemSizes.Runway;
            currentEffect = DragDropEffects.Copy;

            vpp.DoDragDrop(vpp.Image, DragDropEffects.Copy);
        }

        private void garage_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.Garage <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.Garage;
            CurrentDraggableItem.Size = ItemSizes.Garage;
            currentEffect = DragDropEffects.Copy;

            garage.DoDragDrop(garage.Image, DragDropEffects.Copy);
        }

        private void hangar_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.Hangar <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.Hangar;
            CurrentDraggableItem.Size = ItemSizes.Hangar;
            currentEffect = DragDropEffects.Copy;

            hangar.DoDragDrop(hangar.Image, DragDropEffects.Copy);
        }

        private void cargoTerminal_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.CargoTerminal <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.CargoTerminal;
            CurrentDraggableItem.Size = ItemSizes.CargoTerminal;
            currentEffect = DragDropEffects.Copy;

            cargoTerminal.DoDragDrop(cargoTerminal.Image, DragDropEffects.Copy);
        }

        private void passengerTerminal_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemCounter.PassengerTerminal <= 0) return;
            CurrentDraggableItem.Type = TopologyItemType.PassengerTerminal;
            CurrentDraggableItem.Size = ItemSizes.PassengerTerminal;
            currentEffect = DragDropEffects.Copy;

            passengerTerminal.DoDragDrop(passengerTerminal.Image, DragDropEffects.Copy);
        }

        #endregion

        #region Drag Events

        private void calculateCoordinates(DragEventArgs e)
        {
            var clientPoint = grid.PointToClient(new Point(e.X, e.Y));
            var widths = grid.GetColumnWidths();
            var heights = grid.GetRowHeights();

            var col = -1;
            var left = clientPoint.X;
            for (int i = 0; i < widths.Length; i++)
            {
                if (left < widths[i])
                {
                    col = i;
                    break;
                }

                left -= widths[i];
            }

            var row = -1;
            var top = clientPoint.Y;
            for (var i = 0; i < heights.Length; i++)
            {
                if (top < heights[i])
                {
                    row = i;
                    break;
                }

                top -= heights[i];
            }


            CurrentDraggableItem.Coordinates.X = col;
            CurrentDraggableItem.Coordinates.Y = row;
        }

        private int prevCol;
        private int prevRow;
        private PictureBox prevPB;
        private void dragDropCopy(object sender, DragEventArgs e)
        {
            calculateCoordinates(e);
            var col = CurrentDraggableItem.Coordinates.X;
            var row = CurrentDraggableItem.Coordinates.Y;

            currentEffect = DragDropEffects.Copy;
            e.Effect = DragDropEffects.Copy;

            PictureBox pb = new PictureBox();

            var widths = grid.GetColumnWidths();
            var heights = grid.GetRowHeights();

            var type = CurrentDraggableItem.Type;
            var width = widths[col];
            var height = heights[row];

            pb.Size = new Size(CurrentDraggableItem.Size.Width * width - 1, CurrentDraggableItem.Size.Height * height - 1);
            pb.Location = new Point(col * width + 1, row * height + 1);
            pb.Image = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
            pb.SizeMode = CurrentDraggableItem.Type == TopologyItemType.Runway
                ? PictureBoxSizeMode.StretchImage
                : PictureBoxSizeMode.Zoom;
            AddCurrentItemToTopology();
            var item = Topology.Items.First(model => model.Coordinates.X == col && model.Coordinates.Y == row);

            pb.GotFocus += (o, args) => pb.BackColor = Color.Aquamarine;
            pb.LostFocus += (o, args) => pb.ResetBackColor();
            pb.MouseClick += (o, args) =>
            {
                pb.Focus();
                CurrentDraggableItem.Type = type;
            };
            pb.AllowDrop = true;
            pb.MouseDown += (o, args) =>
            {
                if (!pb.Focused) return;
                prevPB = pb;
                currentEffect = DragDropEffects.Move;
                pb.DoDragDrop(item, DragDropEffects.Move);
            };
            pb.KeyDown += (o, args) =>
            {
                if (args.KeyCode == Keys.Delete && pb.Focused)
                {
                    ActiveControl = null;
                    RemoveItemFromTopology(item, pb);
                }
            };
            pb.MouseWheel += (o, args) =>
            {
                if (!pb.Focused) return;

                var c = item.Size.Height;
                var itemHeight = item.Size.Width;
                var itemWidth = c;
                prevCol = item.Coordinates.X;
                prevRow = item.Coordinates.Y;
                
                Debug.Write("ItemHeight: " + itemHeight + ". ItemWidth: " + itemWidth);

                if (prevCol + itemWidth > grid.ColumnCount
                    || prevRow + itemHeight > grid.RowCount)
                {
                    getErrorBox();
                    return;
                }
                
                if (placeIsNotFree(item.Coordinates.X, item.Coordinates.Y, itemHeight, itemWidth))
                {
                    getErrorBox();
                    return;
                }

                item.Size.Height = itemHeight;
                item.Size.Width = itemWidth;
                
                pb.Size = new Size(pb.Size.Height, pb.Size.Width);

                if (args.Delta > 0)
                {
                    item.Angle++;
                    pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), 90f);
                }

                if (args.Delta < 0)
                {
                    item.Angle--;
                    pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), -90f);
                }

                grid.Refresh();
                extendedPanel.Refresh();
            };

            extendedPanel.Controls.Add(pb);
        }

        private DragDropEffects currentEffect;

        private void dragDropMove(object sender, DragEventArgs e)
        {
            calculateCoordinates(e);
            var widths = grid.GetColumnWidths();
            var heights = grid.GetRowHeights();

            var col = CurrentDraggableItem.Coordinates.X;
            var row = CurrentDraggableItem.Coordinates.Y;

            currentEffect = DragDropEffects.Move;
            e.Effect = DragDropEffects.Move;

            if (e.Data.GetData(typeof(TopologyItemModel)) is TopologyItemModel item)
            {
                var tmp = item;
                tmp.Coordinates.X = col;
                tmp.Coordinates.Y = row;
                Topology.Items.First(model => model == tmp).Coordinates = item.Coordinates;
                prevPB.Location = new Point(col * widths[col] + 1, row * heights[row] + 1);
            }

            grid.Refresh();
            extendedPanel.Refresh();
        }

        private bool placeIsNotFree(int col, int row, int height, int width)
        {
            var key = false;
            foreach (var topologyItemModel in Topology.Items)
            {
                if (topologyItemModel.Coordinates.X == prevCol && topologyItemModel.Coordinates.Y == prevRow)
                    continue;

                if (IndexOfInnerRectangle(new Rectangle(col, row, width, height),
                    new Rectangle(topologyItemModel.Coordinates.X, topologyItemModel.Coordinates.Y,
                        topologyItemModel.Size.Width, topologyItemModel.Size.Height)))
                {
                    key = true;
                }
            }

            return key;
        }

        private bool IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            return r1.IntersectsWith(r2) || r2.IntersectsWith(r1);
        }

        private void getErrorBox()
        {
            const string message = "Объект нельзя расположить в данной области";
            const string caption = "Ошибка";
            var result = MessageBox.Show(message, caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void extendedPanel_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("----");
            if (e.Effect == DragDropEffects.Move)
            {
                var item = (TopologyItemModel)e.Data.GetData(typeof(TopologyItemModel));
                prevCol = item.Coordinates.X;
                prevRow = item.Coordinates.Y;
                CurrentDraggableItem.Size = item.Size;
                Debug.WriteLine("PrevCol: " + prevCol + ". PrevRow: " + prevRow);
            }

            calculateCoordinates(e);

            var col = CurrentDraggableItem.Coordinates.X;
            var row = CurrentDraggableItem.Coordinates.Y;

            Debug.WriteLine(col + CurrentDraggableItem.Size.Width > grid.ColumnCount);
            Debug.WriteLine(row + CurrentDraggableItem.Size.Height > grid.RowCount);
            Debug.WriteLine(placeIsNotFree(col, row, CurrentDraggableItem.Size.Height, CurrentDraggableItem.Size.Width));

            if (col + CurrentDraggableItem.Size.Width > grid.ColumnCount
                || row + CurrentDraggableItem.Size.Height > grid.RowCount)
            {
                getErrorBox();

                if (e.Effect == DragDropEffects.Copy)
                {
                    PlusCounter();
                }

                return;
            }

            if (placeIsNotFree(col, row, CurrentDraggableItem.Size.Height, CurrentDraggableItem.Size.Width))
            {
                getErrorBox();

                if (e.Effect == DragDropEffects.Copy)
                {
                    PlusCounter();
                }

                return;
            }

            ActiveControl = null;
            switch (e.Effect)
            {
                case DragDropEffects.Copy:
                    dragDropCopy(sender, e);
                    break;
                case DragDropEffects.Move:
                    dragDropMove(sender, e);
                    break;
            }
        }

        private void extendedPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = currentEffect;
        }

        #endregion

        private Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        #region Button Click Events

        private void plusHorButton_Click(object sender, EventArgs e)
        {
            if (grid.ColumnCount < 25 && extendedPanel.Controls.Count == 0)
            {
                grid.ColumnCount++;
                extendedPanel.Size = grid.Size;
                Topology.Size.Width++;
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / grid.ColumnCount));
                horGridOutput.Text = grid.ColumnCount.ToString();
                ApplyTopology();
            }
        }

        private void minusHorBut_Click(object sender, EventArgs e)
        {
            if (grid.ColumnCount > 10 && extendedPanel.Controls.Count == 0)
            {
                grid.ColumnCount--;
                extendedPanel.Size = grid.Size;
                Topology.Size.Width--;
                horGridOutput.Text = grid.ColumnCount.ToString();
            }
        }

        private void plusVerBut_Click(object sender, EventArgs e)
        {
            if (grid.RowCount < 25 && extendedPanel.Controls.Count == 0)
            {
                grid.RowCount++;
                extendedPanel.Size = grid.Size;
                Topology.Size.Height++;
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / grid.RowCount));
                verGridOutput.Text = grid.RowCount.ToString();
                ApplyTopology();
            }
        }

        private void minusVerBut_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 10 && extendedPanel.Controls.Count == 0)
            {
                grid.RowCount--;
                extendedPanel.Size = grid.Size;
                Topology.Size.Height--;
                verGridOutput.Text = grid.RowCount.ToString();
            }
        }

        private void CreateTopologyButton_click(object sender, EventArgs e)
        {
            ResetTopology();
            extendedPanel.Controls.Clear();
            tabControl1.SelectedIndex++;
        }

        private void LoadTopologyButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var streamReader = new StreamReader(openFileDialog.FileName);

                    var topologyJson = streamReader.ReadToEnd();

                    streamReader.Close();

                    Topology = JsonSerializer.Deserialize<TopologyModel>(topologyJson, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true
                    });

                    ApplyTopology();

                    tabControl1.SelectedIndex++;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (JsonException)
                {
                    const string message =
                        "Файл поврежден или топология имеет неверный формат. \nПопробуйте загрузить другой файл.";
                    const string caption = "Ошибка файла топологии";
                    var result = MessageBox.Show(message, caption,
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                    if (result == DialogResult.Retry)
                    {
                        LoadTopologyButton.PerformClick();
                    }
                }
            }
        }

        private void saveTopology_Click(object sender, EventArgs e)
        {
            if (Topology.Items.Count == 0)
            {
                const string message =
                    "Топология не содержит элементов. \nВы уверены, что хотите сохранить пустой файл?";
                const string caption = "Внимание";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream;
                try
                {
                    if ((fileStream = saveFileDialog.OpenFile()) != null)
                    {
                        var pathParts = saveFileDialog.FileName.Split('\\');
                        Topology.Name = pathParts[pathParts.Length - 1].Split('.')[0];

                        var topologyJson = JsonSerializer.Serialize(Topology, new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        });

                        topologyName.Text = Topology.Name;

                        var streamWriter = new StreamWriter(fileStream);
                        streamWriter.Write(topologyJson);
                        streamWriter.Close();
                        fileStream.Close();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        #endregion

        private void CreateGrid(int ver, int hor)
        {
            horGridOutput.Text = hor.ToString();
            verGridOutput.Text = ver.ToString();
            grid.RowCount = ver;
            grid.ColumnCount = hor;

            for (int i = 0; i < gridSize; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / grid.ColumnCount));
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / grid.RowCount));
            }
        }

        private void ApplyTopology()
        {
            ResetCounters();
            extendedPanel.Controls.Clear();
            topologyName.Text = Topology.Name;

            while (grid.ColumnCount != Topology.Size.Width && grid.RowCount != Topology.Size.Height)
            {
                if (grid.ColumnCount < Topology.Size.Width)
                {
                    grid.ColumnCount++;
                    grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / grid.ColumnCount));
                    horGridOutput.Text = grid.ColumnCount.ToString();
                }

                if (grid.ColumnCount > Topology.Size.Width)
                {
                    grid.ColumnCount--;
                    horGridOutput.Text = grid.ColumnCount.ToString();
                }

                if (grid.RowCount < Topology.Size.Height)
                {
                    grid.RowCount++;
                    grid.ColumnStyles.Add(new RowStyle(SizeType.Percent, 100 / grid.RowCount));
                    verGridOutput.Text = grid.RowCount.ToString();
                }

                if (grid.RowCount > Topology.Size.Height)
                {
                    grid.RowCount--;
                    verGridOutput.Text = grid.RowCount.ToString();
                }
            }

            foreach (var item in Topology.Items)
            {
                PictureBox pb = new PictureBox();

                var X = item.Coordinates.X;
                var Y = item.Coordinates.Y;

                var width = grid.GetColumnWidths()[X];
                var height = grid.GetRowHeights()[Y];

                pb.Size = new Size(item.Size.Width * width - 1, item.Size.Height * height - 1);
                pb.Location = new Point(X * width + 1, Y * height + 1);
                pb.Image = item.Type switch {
                    TopologyItemType.AirportBuilding => airport.Image,
                    TopologyItemType.CargoTerminal => cargoTerminal.Image,
                    TopologyItemType.Garage => garage.Image,
                    TopologyItemType.Hangar => hangar.Image,
                    TopologyItemType.PassengerTerminal => passengerTerminal.Image,
                    TopologyItemType.Runway => vpp.Image,
                    _ => null
                };

                CurrentDraggableItem.Type = item.Type;
                MinusCounter();

                if (item.Angle != 0)
                {
                    if (item.Angle > 0)
                    {
                        while (item.Angle > 0)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), 90f);
                            item.Angle--;
                        }
                    }
                    else if (item.Angle < 0)
                    {
                        while (item.Angle < 0)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), -90f);
                            item.Angle++;
                        }
                    }
                }
                
                pb.SizeMode = item.Type == TopologyItemType.Runway
                    ? PictureBoxSizeMode.StretchImage
                    : PictureBoxSizeMode.Zoom;

                pb.GotFocus += (o, args) => pb.BackColor = Color.Aquamarine;
                pb.LostFocus += (o, args) => pb.ResetBackColor();
                pb.MouseClick += (o, args) =>
                {
                    pb.Focus();
                    CurrentDraggableItem.Type = item.Type;
                };
                pb.AllowDrop = true;
                pb.MouseDown += (o, args) =>
                {
                    if (!pb.Focused) return;
                    prevPB = pb;
                    currentEffect = DragDropEffects.Move;
                    pb.DoDragDrop(item, DragDropEffects.Move);
                };
                pb.KeyDown += (o, args) =>
                {
                    if (args.KeyCode == Keys.Delete && pb.Focused)
                    {
                        ActiveControl = null;
                        RemoveItemFromTopology(item, pb);
                    }
                };
                pb.MouseWheel += (o, args) =>
                {
                    if (!pb.Focused) return;
                    var c = item.Size.Height;
                    item.Size.Height = item.Size.Width;
                    item.Size.Width = c;
                    pb.Size = new Size(pb.Size.Height, pb.Size.Width);
                    if (args.Delta > 0)
                    {
                        item.Angle++;
                        pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), 90f);
                    }

                    if (args.Delta < 0)
                    {
                        item.Angle--;
                        pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), -90f);
                    }

                    grid.Refresh();
                    extendedPanel.Refresh();
                };

                extendedPanel.Controls.Add(pb);
            }
        }

        private void ResetTopology()
        {
            Topology.Name = "Название топологии";
            Topology.Items = new List<TopologyItemModel>();
            Topology.Size.Width = gridSize;
            Topology.Size.Height = gridSize;
            ResetCounters();
            ApplyTopology();
        }

        private void RemoveItemFromTopology(TopologyItemModel item, PictureBox pb)
        {
            Topology.Items.Remove(item);
            extendedPanel.Controls.Remove(pb);
            grid.Refresh();
            extendedPanel.Refresh();
            PlusCounter();
        }

        private void PlusCounter()
        {
            switch (CurrentDraggableItem.Type)
            {
                case TopologyItemType.AirportBuilding:
                    if (ItemCounter.AirportBuilding < 1) ItemCounter.AirportBuilding++;
                    counterAirport.Text = "x" + ItemCounter.AirportBuilding;
                    break;
                case TopologyItemType.CargoTerminal:
                    if (ItemCounter.CargoTerminal < 1) ItemCounter.CargoTerminal++;
                    counterCargoTerm.Text = "x" + ItemCounter.CargoTerminal;
                    break;
                case TopologyItemType.Garage:
                    if (ItemCounter.Garage < 5) ItemCounter.Garage++;
                    counterGarage.Text = "x" + ItemCounter.Garage;
                    break;
                case TopologyItemType.Hangar:
                    if (ItemCounter.Hangar < 3) ItemCounter.Hangar++;
                    counterHangar.Text = "x" + ItemCounter.Hangar;
                    break;
                case TopologyItemType.PassengerTerminal:
                    if (ItemCounter.PassengerTerminal < 1) ItemCounter.PassengerTerminal++;
                    counterPassTerm.Text = "x" + ItemCounter.PassengerTerminal;
                    break;
                case TopologyItemType.Runway:
                    if (ItemCounter.Runway < 1) ItemCounter.Runway++;
                    counterVPP.Text = "x" + ItemCounter.Runway;
                    break;
            }
        }

        private void MinusCounter()
        {
            switch (CurrentDraggableItem.Type)
            {
                case TopologyItemType.AirportBuilding:
                    ItemCounter.AirportBuilding--;
                    counterAirport.Text = "x" + ItemCounter.AirportBuilding;
                    break;
                case TopologyItemType.CargoTerminal:
                    ItemCounter.CargoTerminal--;
                    counterCargoTerm.Text = "x" + ItemCounter.CargoTerminal;
                    break;
                case TopologyItemType.Garage:
                    ItemCounter.Garage--;
                    counterGarage.Text = "x" + ItemCounter.Garage;
                    break;
                case TopologyItemType.Hangar:
                    ItemCounter.Hangar--;
                    counterHangar.Text = "x" + ItemCounter.Hangar;
                    break;
                case TopologyItemType.PassengerTerminal:
                    ItemCounter.PassengerTerminal--;
                    counterPassTerm.Text = "x" + ItemCounter.PassengerTerminal;
                    break;
                case TopologyItemType.Runway:
                    ItemCounter.Runway--;
                    counterVPP.Text = "x" + ItemCounter.Runway;
                    break;
            }
        }

        private void ResetCounters()
        {
            ItemCounter.Reset();
            counterAirport.Text = "x" + ItemCounter.AirportBuilding;
            counterCargoTerm.Text = "x" + ItemCounter.CargoTerminal;
            counterGarage.Text = "x" + ItemCounter.Garage;
            counterHangar.Text = "x" + ItemCounter.Hangar;
            counterPassTerm.Text = "x" + ItemCounter.PassengerTerminal;
            counterVPP.Text = "x" + ItemCounter.Runway;
        }

        private void AddCurrentItemToTopology()
        {
            MinusCounter();
            Topology.Items.Add(new TopologyItemModel
            {
                Type = CurrentDraggableItem.Type,
                Size = new Models.Size
                {
                    Width = CurrentDraggableItem.Size.Width,
                    Height = CurrentDraggableItem.Size.Height
                },
                Coordinates = new Coordinates
                {
                    X = CurrentDraggableItem.Coordinates.X,
                    Y = CurrentDraggableItem.Coordinates.Y
                },
            });
        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            RemoveItemFromTopology((TopologyItemModel)e.Data.GetData(typeof(TopologyItemModel)), prevPB);
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = currentEffect;
        }

        #endregion

        #region Schedule

        #region Button Click Events

        private void fligthsButton_Click(object sender, EventArgs e)
        {
            if (!flightsGridView.Visible)
            {
                comboBox1.SelectedIndex = 1;
                flightsGridView.Visible = true;
                citiesGridView.Visible = false;
                airplanesGridView.Visible = false;
                SetButtonActive(fligthsButton);
                SetButtonInactive(airplanesButton);
                SetButtonInactive(citiesButton);
                flightsGridView.DataSource = _db.Flights.ToList();
                flightsGridView.Refresh();
            }
        }

        private void airplanesButton_Click(object sender, EventArgs e)
        {
            if (!airplanesGridView.Visible)
            {
                comboBox1.SelectedIndex = 2;
                airplanesGridView.Visible = true;
                citiesGridView.Visible = false;
                flightsGridView.Visible = false;
                SetButtonActive(airplanesButton);
                SetButtonInactive(fligthsButton);
                SetButtonInactive(citiesButton);
                airplanesGridView.DataSource = _airplaneService.GetAirplanes();
                airplanesGridView.Refresh();
            }
        }

        private void citiesButton_Click(object sender, EventArgs e)
        {
            if (!citiesGridView.Visible)
            {
                comboBox1.SelectedIndex = 0;
                citiesGridView.Visible = true;
                flightsGridView.Visible = false;
                airplanesGridView.Visible = false;
                SetButtonActive(citiesButton);
                SetButtonInactive(airplanesButton);
                SetButtonInactive(fligthsButton);
                citiesGridView.DataSource = _cityService.GetCities();
                citiesGridView.Refresh();
            }
        }

        private void SetButtonActive(Button button)
        {
            button.BackColor = Color.FromArgb(0, 120, 212);
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button.ForeColor = SystemColors.HighlightText;
        }

        private void SetButtonInactive(Button button)
        {
            button.UseVisualStyleBackColor = true;
            button.BackColor = Color.FromArgb(0, 120, 212);
            button.Cursor = Cursors.Hand;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = SystemColors.ControlText;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (citiesGridView.Visible)
            {
                using var addCityForm = new AddCityForm();

                dialogResult = addCityForm.ShowDialog();
                if (dialogResult == DialogResult.OK && addCityForm.CityDTO != null)
                {
                    _cityService.AddCity(addCityForm.CityDTO);
                    citiesGridView.DataSource = _cityService.GetCities();
                    citiesGridView.Refresh();
                }
            }

            if (airplanesGridView.Visible)
            {
                using var addAirplaneForm = new AddAirplaneForm();

                dialogResult = addAirplaneForm.ShowDialog();
                if (dialogResult == DialogResult.OK && addAirplaneForm.AirplaneDTO != null)
                {
                    _airplaneService.AddAirplane(addAirplaneForm.AirplaneDTO);
                    airplanesGridView.DataSource = _airplaneService.GetAirplanes();
                    airplanesGridView.Refresh();
                }
            }

            if (flightsGridView.Visible)
            {
                //TODO Добавить реализацию
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить объект?",
                                     "Подтвеждение удаления",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No) return;

            if (citiesGridView.Visible && citiesGridView.SelectedCells.Count > 0 )
            {
                var selectedRowIndex = citiesGridView.SelectedCells[0].RowIndex;
                var selectedRow = citiesGridView.Rows[selectedRowIndex];
                var cityId = int.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));

                _cityService.RemoveCity(cityId);
                citiesGridView.DataSource = _cityService.GetCities();
                citiesGridView.Refresh();
            }

            if (airplanesGridView.Visible && airplanesGridView.SelectedCells.Count > 0)
            {
                var selectedRowIndex = airplanesGridView.SelectedCells[0].RowIndex;
                var selectedRow = airplanesGridView.Rows[selectedRowIndex];
                var airplaneId = int.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));

                _airplaneService.RemoveAirplane(airplaneId);
                airplanesGridView.DataSource = _airplaneService.GetAirplanes();
                airplanesGridView.Refresh();
            }
        }

        #endregion

        #endregion

    }
}