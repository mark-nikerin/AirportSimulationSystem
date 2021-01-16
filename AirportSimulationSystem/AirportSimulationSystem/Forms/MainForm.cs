using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.Json;
using System.Windows.Forms;
using AirportSimulationSystem.Models;
using AirportSimulationSystem.Models.DTOs;
using AirportSimulationSystem.Models.Enums;
using AirportSimulationSystem.Models.Modelling;
using AirportSimulationSystem.Services.Interfaces;
using Size = System.Drawing.Size;

namespace AirportSimulationSystem
{
    public partial class MainForm : Form
    {
        private const int MinGridSize = 10;
        private const int MaxGridSize = 25;
        private static TopologyModel Topology = new TopologyModel();
        private static TopologyItemModel CurrentDraggableItem = new TopologyItemModel();
        private static int TopologyCellWidth = 0;
        private static int TopologyCellHeight = 0;

        private static IAirplaneService _airplaneService;
        private static ICityService _cityService;
        private static IFlightService _flightService;

        private int timeScale = 1;

        public MainForm(IAirplaneService airplaneService, ICityService cityService, IFlightService flightService)
        {
            InitializeComponent();
            DoubleBuffered = true;

            _airplaneService = airplaneService;
            _cityService = cityService;
            _flightService = flightService;

            flightsGridView.DataSource = _flightService.GetFlights();
            citiesGridView.DataSource = _cityService.GetCities();
            airplanesGridView.DataSource = _airplaneService.GetAirplanes();

            citiesGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            airplanesGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            flightsGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flightsGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewComboBoxColumn
                {
                    Name = "City",
                    HeaderText = "Город",
                    DataSource = citiesGridView.DataSource,
                    DataPropertyName = "Name",
                    DisplayMember = "Name",
                    ValueType = typeof(int),
                    ValueMember = "Id",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                    FlatStyle = FlatStyle.Flat,
                    Resizable = DataGridViewTriState.True,
                    SortMode = DataGridViewColumnSortMode.Automatic,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewComboBoxColumn
                {
                    Name = "Airplane",
                    HeaderText = "Самолёт",
                    DataSource = airplanesGridView.DataSource,
                    DataPropertyName = "Model",
                    DisplayMember = "Model",
                    ValueType = typeof(int),
                    ValueMember = "Id",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                    FlatStyle = FlatStyle.Flat,
                    Resizable = DataGridViewTriState.True,
                    SortMode = DataGridViewColumnSortMode.Automatic,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
            });
            RefreshFlightComboBoxValues();
            flightsGridView.Refresh();

            flightsGridView.Columns[0].ReadOnly = true;
            flightsGridView.Columns["FlightType"].ReadOnly = true;
            flightsGridView.Columns["RegistryNumber"].ReadOnly = true;
            flightsGridView.Columns["Tittle"].ReadOnly = true;
            citiesGridView.Columns[0].ReadOnly = true;
            airplanesGridView.Columns[0].ReadOnly = true;

            CreateGrid(MinGridSize, MinGridSize);
            CreateModellingGrid(MinGridSize, MinGridSize);
            Topology.Size.Height = MinGridSize;
            Topology.Size.Width = MinGridSize;

            SearchComboBox.SelectedIndex = 0;

            extendedPanel.AllowDrop = true;
            groupBox1.AllowDrop = true;

            timer1.Interval = 1000;
            trackBar1.Value = 1;
        }

        #region Navigation

        private void NextButton_Click(object sender, EventArgs e)
        {

            if (ItemCounter.AirportBuilding < 1
            && ItemCounter.CargoTerminal < 1
            && ItemCounter.PassengerTerminal < 1
            && ItemCounter.Garage < 5
            && ItemCounter.Hangar < 3
            && ItemCounter.Runway < 1)
            {
                MainTabControl.SelectedIndex++;
            }
            else
            {
                const string message = "При создании топологии были использованы не все типы объектов.";
                const string caption = "Ошибка";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex--;
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

        private void CalculateCoordinates(DragEventArgs e)
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
        private void DragDropCopy(object sender, DragEventArgs e)
        {
            CalculateCoordinates(e);
            var col = CurrentDraggableItem.Coordinates.X;
            var row = CurrentDraggableItem.Coordinates.Y;

            currentEffect = DragDropEffects.Copy;
            e.Effect = DragDropEffects.Copy;

            PictureBox pb = new PictureBox();

            var widths = grid.GetColumnWidths();
            var heights = grid.GetRowHeights();

            var width = widths[col];
            var height = heights[row];

            if (CurrentDraggableItem.Type == TopologyItemType.Runway)
            {
                if (grid.ColumnCount == grid.RowCount)
                    ItemSizes.Runway.Width = grid.ColumnCount - 3;
                else if (grid.ColumnCount > grid.RowCount)
                {
                    ItemSizes.Runway.Width = grid.RowCount - 1;
                }
                else if (grid.ColumnCount < grid.RowCount)
                {
                    ItemSizes.Runway.Width = grid.ColumnCount - 1;
                }
            }

            var type = CurrentDraggableItem.Type;
            pb.Size = new Size(CurrentDraggableItem.Size.Width * width - 1, CurrentDraggableItem.Size.Height * height - 1);
            pb.Location = new Point(col * width + 1, row * height + 1);
            pb.Image = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
            pb.SizeMode = CurrentDraggableItem.Type == TopologyItemType.Runway
                ? PictureBoxSizeMode.StretchImage
                : PictureBoxSizeMode.Zoom;
            AddCurrentItemToTopology();
            var item = Topology.Items.First(model => model.Coordinates.X == col && model.Coordinates.Y == row);
            pb.GotFocus += (o, args) => pb.BackColor = Color.FromArgb(110, 191, 255);
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

                const string message = "Объект невозможно повернуть";
                const string caption = "Ошибка";
                if (prevCol + itemWidth > grid.ColumnCount
                    || prevRow + itemHeight > grid.RowCount)
                {
                    var result = MessageBox.Show(message, caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (placeIsNotFree(item.Coordinates.X, item.Coordinates.Y, itemHeight, itemWidth))
                {
                    var result = MessageBox.Show(message, caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                item.Size.Height = itemHeight;
                item.Size.Width = itemWidth;

                pb.Size = new Size(item.Size.Width * width - 1, item.Size.Height * height - 1);

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

        private void DragDropMove(object sender, DragEventArgs e)
        {
            CalculateCoordinates(e);
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

            CalculateCoordinates(e);

            var col = CurrentDraggableItem.Coordinates.X;
            var row = CurrentDraggableItem.Coordinates.Y;

            Debug.WriteLine(col + CurrentDraggableItem.Size.Width > grid.ColumnCount);
            Debug.WriteLine(col + " " + CurrentDraggableItem.Size.Width);
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
                    DragDropCopy(sender, e);
                    break;
                case DragDropEffects.Move:
                    DragDropMove(sender, e);
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
            if (grid.ColumnCount < MaxGridSize && extendedPanel.Controls.Count == 0)
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
            if (grid.RowCount < MaxGridSize && extendedPanel.Controls.Count == 0)
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
            MainTabControl.SelectedIndex++;
        }

        private void LoadTopologyButton_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл с топологией",
                Filter = "Файлы JSON (*.json)|*.json"
            };

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

                    MainTabControl.SelectedIndex++;
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

            using var saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                RestoreDirectory = true,
                Title = "Сохраните файл с топологией",
                FileName = topologyName.Text,
                DefaultExt = ".json",
                Filter = "Файлы JSON (*.json)|*.json"
            };

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

            for (int i = 0; i < MinGridSize; i++)
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

            if (grid.ColumnCount == grid.RowCount)
                ItemSizes.Runway.Width = grid.ColumnCount - 3;
            else if (grid.ColumnCount > grid.RowCount)
            {
                ItemSizes.Runway.Width = grid.RowCount - 1;
            }
            else if (grid.ColumnCount < grid.RowCount)
            {
                ItemSizes.Runway.Width = grid.ColumnCount - 1;
            }

            TopologyCellWidth = grid.GetColumnWidths()[0];
            TopologyCellHeight = grid.GetRowHeights()[0];

            foreach (var item in Topology.Items)
            {
                PictureBox pb = new PictureBox();

                var X = item.Coordinates.X;
                var Y = item.Coordinates.Y; 

                pb.Size = new Size(item.Size.Width * TopologyCellWidth - 1, item.Size.Height * TopologyCellHeight - 1);
                pb.Location = new Point(X * TopologyCellWidth + 1, Y * TopologyCellHeight + 1);
                pb.Image = item.Type switch
                {
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
                        for (int i = item.Angle; i > 0; i--)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), 90f);
                        }
                    }
                    else if (item.Angle < 0)
                    {
                        for (int i = item.Angle; i < 0; i++)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), -90f);
                        }
                    }
                }

                pb.SizeMode = item.Type == TopologyItemType.Runway
                    ? PictureBoxSizeMode.StretchImage
                    : PictureBoxSizeMode.Zoom;

                pb.GotFocus += (o, args) => pb.BackColor = Color.FromArgb(110, 191, 255);
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
                    var itemHeight = item.Size.Width;
                    var itemWidth = c;
                    prevCol = item.Coordinates.X;
                    prevRow = item.Coordinates.Y;

                    const string message = "Объект невозможно повернуть";
                    const string caption = "Ошибка";
                    if (prevCol + itemWidth > grid.ColumnCount
                        || prevRow + itemHeight > grid.RowCount)
                    {
                        var result = MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (placeIsNotFree(item.Coordinates.X, item.Coordinates.Y, itemHeight, itemWidth))
                    {
                        var result = MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    item.Size.Height = itemHeight;
                    item.Size.Width = itemWidth;

                    pb.Size = new Size(item.Size.Width * TopologyCellWidth - 1, item.Size.Height * TopologyCellHeight - 1);

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
            Topology.Size.Width = MinGridSize;
            Topology.Size.Height = MinGridSize;
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
            var item = (TopologyItemModel)e.Data.GetData(typeof(TopologyItemModel));
            if (Topology.Items.FirstOrDefault(model => model == item) == null) return;
            RemoveItemFromTopology(item, prevPB);
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
                SearchComboBox.SelectedIndex = 1;
                flightsGridView.Visible = true;
                citiesGridView.Visible = false;
                airplanesGridView.Visible = false;
                SetButtonActive(fligthsButton);
                SetButtonInactive(airplanesButton);
                SetButtonInactive(citiesButton);
                flightsGridView.DataSource = _flightService.GetFlights();
                RefreshFlightComboBoxValues();
                flightsGridView.Refresh();
            }
        }

        private void airplanesButton_Click(object sender, EventArgs e)
        {
            if (!airplanesGridView.Visible)
            {
                SearchComboBox.SelectedIndex = 2;
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
                SearchComboBox.SelectedIndex = 0;
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

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (citiesGridView.Visible)
            {
                using var addCityForm = new AddCityForm(_cityService.GetCities());

                dialogResult = addCityForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _cityService.AddCity(addCityForm.CityDTO);
                    citiesGridView.DataSource = _cityService.GetCities();
                    citiesGridView.Refresh();
                }
            }

            if (airplanesGridView.Visible)
            {
                using var addAirplaneForm = new AddAirplaneForm(_airplaneService.GetAirplanes());

                dialogResult = addAirplaneForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _airplaneService.AddAirplane(addAirplaneForm.AirplaneDTO);
                    airplanesGridView.DataSource = _airplaneService.GetAirplanes();
                    airplanesGridView.Refresh();
                }
            }

            if (flightsGridView.Visible)
            {
                using var addFlightForm = new AddFlightForm(_cityService.GetCities(), _airplaneService.GetAirplanes(), _flightService.GetFlights());
                dialogResult = addFlightForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _flightService.AddFlight(addFlightForm.FlightDTO);
                    flightsGridView.DataSource = _flightService.GetFlights();
                    RefreshFlightComboBoxValues();
                    flightsGridView.Refresh();
                }
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (citiesGridView.Visible && citiesGridView.SelectedCells.Count > 0)
            {
                var selectedRowIndex = citiesGridView.SelectedCells[0].RowIndex;
                var selectedRow = citiesGridView.Rows[selectedRowIndex];
                var cityId = int.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));
                var cityName = (string)selectedRow.Cells["Name"].Value;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить город '{cityName}'?",
                                     "Подтвеждение удаления",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.No) return;

                _cityService.RemoveCity(cityId);
                citiesGridView.DataSource = _cityService.GetCities();
                citiesGridView.Refresh();
            }

            if (airplanesGridView.Visible && airplanesGridView.SelectedCells.Count > 0)
            {
                var selectedRowIndex = airplanesGridView.SelectedCells[0].RowIndex;
                var selectedRow = airplanesGridView.Rows[selectedRowIndex];
                var airplaneId = int.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));
                var airplaneModel = (string)selectedRow.Cells["Model"].Value;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить самолёт '{airplaneModel}'?",
                                     "Подтвеждение удаления",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.No) return;



                _airplaneService.RemoveAirplane(airplaneId);
                airplanesGridView.DataSource = _airplaneService.GetAirplanes();
                airplanesGridView.Refresh();
            }

            if (flightsGridView.Visible && flightsGridView.SelectedCells.Count > 0)
            {
                var selectedRowIndex = flightsGridView.SelectedCells[0].RowIndex;
                var selectedRow = flightsGridView.Rows[selectedRowIndex];
                var flightId = int.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));
                var flightTittle = (string)selectedRow.Cells["Tittle"].Value;
                var flightNumber = (string)selectedRow.Cells["FlightNumber"].Value;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить рейс {flightNumber} '{flightTittle}'?",
                                     "Подтвеждение удаления",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.No) return;



                _flightService.RemoveFlight(flightId);
                flightsGridView.DataSource = _flightService.GetFlights();
                RefreshFlightComboBoxValues();
                flightsGridView.Refresh();
            }
        }

        #endregion

        #region Key Press Events

        private void citiesGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (citiesGridView.Visible && citiesGridView.SelectedCells.Count > 0)
                {
                    var rowIndex = citiesGridView.SelectedCells[0].RowIndex;

                    var selectedRowIndex = rowIndex == citiesGridView.RowCount - 1
                       ? rowIndex
                       : rowIndex - 1;

                    var selectedRow = citiesGridView.Rows[selectedRowIndex];

                    var cityId = (int)selectedRow.Cells["Id"].Value;
                    var cityName = (string)selectedRow.Cells["Name"].Value;
                    var cityDistance = (int)selectedRow.Cells["Distance"].Value;

                    citiesGridView.EndEdit();

                    var cityDTO = new CityDTO
                    {
                        Id = cityId,
                        Name = cityName,
                        Distance = cityDistance
                    };

                    _cityService.UpdateCity(cityDTO);
                }
            }
        }

        private void airplanesGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                airplanesGridView.EndEdit();
                if (airplanesGridView.Visible && airplanesGridView.SelectedCells.Count > 0)
                {
                    var rowIndex = airplanesGridView.SelectedCells[0].RowIndex;

                    var selectedRowIndex = rowIndex == airplanesGridView.RowCount - 1
                        ? rowIndex
                        : rowIndex - 1;

                    var selectedRow = airplanesGridView.Rows[selectedRowIndex];

                    var airplaneId = (int)selectedRow.Cells["Id"].Value;
                    var airplaneModel = (string)selectedRow.Cells["Model"].Value;
                    var airplaneDistance = (int)selectedRow.Cells["Distance"].Value;
                    var airplaneLiftingCapacity = (int)selectedRow.Cells["LiftingCapacity"].Value;
                    var airplanePassengerCapacity = (int)selectedRow.Cells["PassengerCapacity"].Value;

                    var airplaneDTO = new AirplaneDTO
                    {
                        Id = airplaneId,
                        Model = airplaneModel,
                        Distance = airplaneDistance,
                        LiftingCapacity = airplaneLiftingCapacity,
                        PassengerCapacity = airplanePassengerCapacity
                    };

                    _airplaneService.UpdateAirplane(airplaneDTO);
                }
            }
        }

        private void flightsGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flightsGridView.EndEdit();
                if (flightsGridView.Visible && flightsGridView.SelectedCells.Count > 0)
                {
                    var rowIndex = flightsGridView.SelectedCells[0].RowIndex;

                    var selectedRowIndex = rowIndex == flightsGridView.RowCount - 1
                       ? rowIndex
                       : rowIndex - 1;

                    var selectedRow = flightsGridView.Rows[selectedRowIndex];

                    var flightId = (int)selectedRow.Cells["Id"].Value;
                    var flightNumber = (string)selectedRow.Cells["FlightNumber"].Value;
                    var time = (string)selectedRow.Cells["Time"].Value;
                    var soldTicketsAmount = (int)selectedRow.Cells["SoldTicketsAmount"].Value;
                    var cityId = (int)selectedRow.Cells["City"].Value;
                    var airplaneId = (int)selectedRow.Cells["Airplane"].Value;

                    var flightDTO = new FlightDTO
                    {
                        Id = flightId,
                        FlightNumber = flightNumber,
                        SoldTicketsAmount = soldTicketsAmount,
                        CityId = cityId,
                        AirplaneId = airplaneId,
                        Time = time
                    };
                    _flightService.UpdateFlight(flightDTO);
                    flightsGridView.DataSource = _flightService.GetFlights();
                    RefreshFlightComboBoxValues();
                }
            }
        }

        #endregion

        #region Error Events

        private void airplanesGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введённые данные имели неверный формат\nПопробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void citiesGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введённые данные имели неверный формат\nПопробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void flightsGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введённые данные имели неверный формат\nПопробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = SearchTextBox.Text;
            switch (SearchComboBox.SelectedItem)
            {
                case " Город":
                    {
                        flightsGridView.DataSource = _flightService
                            .GetFlights()
                            .Where(x => x.Tittle.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                        break;
                    }
                case " Самолёт":
                    {
                        flightsGridView.DataSource = _flightService
                            .GetFlights()
                            .Where(x => x.AirplaneModel.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                        break;
                    }
                case " Рейс":
                    {
                        flightsGridView.DataSource = _flightService
                            .GetFlights()
                            .Where(x => x.FlightNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                        break;
                    }
            }
            flightsGridView.Refresh();
            RefreshFlightComboBoxValues();
        }

        private void RefreshFlightComboBoxValues()
        {
            var counter = 0;
            foreach (FlightDTO item in (List<FlightDTO>)flightsGridView.DataSource)
            {
                flightsGridView.Rows[counter].Cells["City"].Value = item.CityId;
                flightsGridView.Rows[counter].Cells["Airplane"].Value = item.AirplaneId;
                counter++;
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

        #endregion

        #region Modelling

        private void CreateModellingGrid(int ver, int hor)
        {
            modellingGrid.RowCount = ver;
            modellingGrid.ColumnCount = hor;

            for (int i = 0; i < MinGridSize; i++)
            {
                modellingGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / modellingGrid.ColumnCount));
                modellingGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / modellingGrid.RowCount));
            }
        }

        private void ApplyTopologyModeling()
        {
            extendedModellingPanel.Controls.Clear();

            while (modellingGrid.ColumnCount != Topology.Size.Width && modellingGrid.RowCount != Topology.Size.Height)
            {
                if (modellingGrid.ColumnCount < Topology.Size.Width)
                {
                    modellingGrid.ColumnCount++;
                    modellingGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / modellingGrid.ColumnCount));
                }

                if (modellingGrid.ColumnCount > Topology.Size.Width)
                {
                    modellingGrid.ColumnCount--;
                }

                if (modellingGrid.RowCount < Topology.Size.Height)
                {
                    modellingGrid.RowCount++;
                    modellingGrid.ColumnStyles.Add(new RowStyle(SizeType.Percent, 100 / modellingGrid.RowCount));
                }

                if (modellingGrid.RowCount > Topology.Size.Height)
                {
                    modellingGrid.RowCount--;
                }
            }

            if (modellingGrid.ColumnCount == modellingGrid.RowCount)
                ItemSizes.Runway.Width = modellingGrid.ColumnCount - 3;
            else if (modellingGrid.ColumnCount > modellingGrid.RowCount)
            {
                ItemSizes.Runway.Width = modellingGrid.RowCount - 1;
            }
            else if (modellingGrid.ColumnCount < modellingGrid.RowCount)
            {
                ItemSizes.Runway.Width = modellingGrid.ColumnCount - 1;
            } 

            foreach (var item in Topology.Items)
            {
                PictureBox pb = new PictureBox();

                var X = item.Coordinates.X;
                var Y = item.Coordinates.Y;

                pb.Size = new Size(item.Size.Width * TopologyCellWidth - 1, item.Size.Height * TopologyCellHeight - 1);
                pb.Location = new Point(X * TopologyCellWidth + 1, Y * TopologyCellHeight + 1);
                pb.Image = item.Type switch
                {
                    TopologyItemType.AirportBuilding => airport.Image,
                    TopologyItemType.CargoTerminal => cargoTerminal.Image,
                    TopologyItemType.Garage => garage.Image,
                    TopologyItemType.Hangar => hangar.Image,
                    TopologyItemType.PassengerTerminal => passengerTerminal.Image,
                    TopologyItemType.Runway => vpp.Image,
                    _ => null
                };

                if (item.Angle != 0)
                {
                    if (item.Angle > 0)
                    {
                        for (int i = item.Angle; i > 0; i--)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), 90f);
                        }
                    }
                    else if (item.Angle < 0)
                    {
                        for (int i = item.Angle; i < 0; i++)
                        {
                            pb.Image = RotateImage(pb.Image, new PointF(pb.Image.Width / 2, pb.Image.Height / 2), -90f);
                        }
                    }
                }

                pb.SizeMode = item.Type == TopologyItemType.Runway
                    ? PictureBoxSizeMode.StretchImage
                    : PictureBoxSizeMode.Zoom;


                extendedModellingPanel.Controls.Add(pb);
            }
        }
            #endregion

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab.Text.Equals("Расписание"))
            {
                RefreshFlightComboBoxValues();
            }
            if (MainTabControl.SelectedTab.Text.Equals("Моделирование"))
            {
                CreateModellingGrid(Topology.Size.Height, Topology.Size.Width);
                ApplyTopologyModeling();

                modellingGridView.DefaultCellStyle = new DataGridViewCellStyle
                {
                    WrapMode = DataGridViewTriState.True
                };

                modellingGridView.DataSource = _flightService
                  .GetFlights()
                  .Select(x => (ModellingFlightDTO)x)
                  .OrderBy(x => DateTime.Parse(x.Time))
                  .ToArray();
                modellingGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                modellingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Tuple<int, int> start = new Tuple<int, int>(4, 12);
                Tuple<int, int> end = new Tuple<int, int>(4, 12);
                 
                var plane = new Plane(new Size(TopologyCellWidth - 1, TopologyCellHeight - 1), new Point(0 * TopologyCellWidth + 1, 0 * TopologyCellHeight + 1));
                var track = new Track(new Size(TopologyCellWidth - 1, TopologyCellHeight - 1), new Point(0 * TopologyCellWidth + 1, 0 * TopologyCellHeight + 1));
                var bus = new Bus(new Size(TopologyCellWidth - 1, TopologyCellHeight - 1), new Point(0 * TopologyCellWidth + 1, 0 * TopologyCellHeight + 1));

                plane.Rotate(90F);

                List<Tuple<int, int>> path = findpath(start, end);
                MoveObject(path, plane);

                start = new Tuple<int, int>(6, 13);
                end = new Tuple<int, int>(6, 13);
                path = findpath(start, end);
                MoveObject(path, track);

                start = new Tuple<int, int>(13, 3);
                end = new Tuple<int, int>(13, 3);
                path = findpath(start, end);
                MoveObject(path, bus);
            }
        }

        private static Tuple<int, int> takestartpointPlane()
        {
            Tuple<int, int> start = new Tuple<int, int>(Topology.Items.Where(x => x.Type == TopologyItemType.Runway).FirstOrDefault().Coordinates.X, Topology.Items.Where(x => x.Type == TopologyItemType.Runway).FirstOrDefault().Coordinates.Y - 1);

            return start;
        }

        private static List<Tuple<int, int>> createclosed()
        {
            List<Tuple<int, int>> closedlist = new List<Tuple<int, int>>();
            foreach (var item in Topology.Items)
            {
                for (int i = item.Coordinates.X; i < (item.Coordinates.X + item.Size.Width); i++)
                {
                    for (int j = item.Coordinates.Y; j < (item.Coordinates.Y + item.Size.Height); j++)
                    {
                        closedlist.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            return closedlist;
        }

        private static int getheuristicpathlength(Tuple<int, int> current, Tuple<int, int> goal)
        {
            return Math.Abs(current.Item1 - goal.Item1) + Math.Abs(current.Item2 - goal.Item2);
        }

        private static List<Tuple<int, int>> findpath(Tuple<int, int> start, Tuple<int, int> goal)
        {
            List<Tuple<int, int>> pathlist = new List<Tuple<int, int>>();
            List<Tuple<int, int>> closedlist = createclosed();
            Tuple<int, int> current = start;
            pathlist.Add(current);
            bool yee = false;
            while (yee == false)
            {
                Tuple<int, int> next = getNext(current, goal, closedlist);
                pathlist.Add(next);
                current = next;
                if (current.Item1 == goal.Item1 & current.Item2 == goal.Item2)
                {
                    yee = true;
                }
            }

            Debug.WriteLine(pathlist);
            return pathlist;
        }

        private static Tuple<int, int> getNext(Tuple<int, int> current, Tuple<int, int> goal, List<Tuple<int, int>> closedlist)
        {
            List<Tuple<int, int>> neighbourslist = getneighbours(current, closedlist);
            int currentcost = 100;
            foreach (var neighbours in neighbourslist)
            {
                int neighbourscost = getheuristicpathlength(neighbours, goal);
                if (neighbourscost <= currentcost)
                {
                    currentcost = neighbourscost;
                    current = neighbours;
                }
            }
            return current;
        }

        private static List<Tuple<int, int>> getneighbours(Tuple<int, int> current, List<Tuple<int, int>> closedlist)
        {
            var result = new List<Tuple<int, int>>();

            // соседними точками являются соседние по стороне клетки.
            Tuple<int, int> neighbour_1 = new Tuple<int, int>(current.Item1 + 1, current.Item2);
            Tuple<int, int> neighbour_2 = new Tuple<int, int>(current.Item1 - 1, current.Item2);
            Tuple<int, int> neighbour_3 = new Tuple<int, int>(current.Item1, current.Item2 + 1);
            Tuple<int, int> neighbour_4 = new Tuple<int, int>(current.Item1, current.Item2 - 1);
            if (!closedlist.Contains(neighbour_1))
            {
                result.Add(neighbour_1);
            }
            if (!closedlist.Contains(neighbour_2))
            {
                result.Add(neighbour_2);
            }
            if (!closedlist.Contains(neighbour_3))
            {
                result.Add(neighbour_3);
            }
            if (!closedlist.Contains(neighbour_4))
            {
                result.Add(neighbour_4);
            }
            return result;
        }

        private void MoveObject(List<Tuple<int, int>> path, ModellingObject @object)
        {
            var width = modellingGrid.GetColumnWidths()[0];
            var height = modellingGrid.GetRowHeights()[0];

            extendedModellingPanel.Controls.Add(@object.Model);
            foreach (var position in path)
            {
                var X = position.Item1;
                var Y = position.Item2;

                @object.MoveTo(new Point(X * width + 1, Y * height + 1));

                extendedModellingPanel.Refresh();
            }
        }

        private void MainPage_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Debug.Write(Application.StartupPath);
            Help.ShowHelp(this, Application.StartupPath + @"\Resources\info.chm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            modellingTime.Value = modellingTime.Value.AddMinutes(timeScale);
            modellingTime.Refresh();

            var flights = (ICollection<ModellingFlightDTO>)modellingGridView.DataSource;

            modellingGridView.DataSource = flights
                .Where(x => DateTime.Parse(x.Time).Hour > modellingTime.Value.Hour
                || DateTime.Parse(x.Time).Hour == modellingTime.Value.Hour && DateTime.Parse(x.Time).Minute > modellingTime.Value.Minute)
                .ToArray();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (ItemCounter.AirportBuilding < 1
                && ItemCounter.CargoTerminal < 1
                && ItemCounter.PassengerTerminal < 1
                && ItemCounter.Garage < 5
                && ItemCounter.Hangar < 3
                && ItemCounter.Runway < 1)
            {
                if (timer1.Enabled)
                {
                    startButton.Text = "СТАРТ";
                    timer1.Stop(); 
                    trackBar1.Value = 1;
                    timeScale = trackBar1.Value;
                    label3.Text = string.Format("{0}x", trackBar1.Value);
                }
                else
                {
                    timer1.Start();
                    startButton.Text = "СТОП";
                }
            }
            else
            {
                const string message = "При создании топологии были использованы не все типы объектов.";
                const string caption = "Ошибка";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timeScale = trackBar1.Value;
            label3.Text = string.Format("{0}x", trackBar1.Value);
        }

        private void modellingTime_ValueChanged(object sender, EventArgs e)
        {
            var flights = _flightService
                  .GetFlights()
                  .Select(x => (ModellingFlightDTO)x)
                  .OrderBy(x => DateTime.Parse(x.Time))
                  .ToArray(); 

            modellingGridView.DataSource = flights
                .Where(x => DateTime.Parse(x.Time).Hour >= modellingTime.Value.Hour
                || DateTime.Parse(x.Time).Hour == modellingTime.Value.Hour && DateTime.Parse(x.Time).Minute >= modellingTime.Value.Minute)
                .ToArray();
        }
    }
}