using System;
using System.Data;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using AirportSimulationSystem.Models;
using AirportSimulationSystem.Models.Enums;
using Size = System.Drawing.Size;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace AirportSimulationSystem
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private DataGridView dataGridView2 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private const int gridSize = 10;
        private static TopologyModel Topology = new TopologyModel(); 
        private static TopologyItemModel CurrentDraggableItem = new TopologyItemModel();

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            openFileDialog = new OpenFileDialog()
            {
                Title = "Выберите файл с топологией",
                Filter = "Файлы JSON (*.json)|*.json"
            };
            saveFileDialog = new SaveFileDialog()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bindingSource1;
            //GetData("select FlightNumber '№ Рейса', Title 'Название', Time 'Время', RegistryNumber '№ стойки регистрации', SoldTicketsAmount 'Количество проданных билетов' from Flights");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString =
                    "Data source=.\\SQLEXPRESS;Initial Catalog=AirportDatabase;" +
                    "Integrated Security=True";

                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                flightsGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #region Navigation

        #region Button Click Events

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        }

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

        #endregion

        #region Topology Builder

        #region Mouse Events 

        private void airport_MouseDown(object sender, MouseEventArgs e)
        { 
            CurrentDraggableItem.Type = TopologyItemType.AirportBuilding;
            CurrentDraggableItem.Size = ItemSizes.AirportBuilding; 

            airport.DoDragDrop(airport.Image, DragDropEffects.Copy);
        }

        private void vpp_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentDraggableItem.Type = TopologyItemType.Runway;
            CurrentDraggableItem.Size = ItemSizes.Runway;

            vpp.DoDragDrop(vpp.Image, DragDropEffects.Copy);

        }

        private void garage_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentDraggableItem.Type = TopologyItemType.Garage;
            CurrentDraggableItem.Size = ItemSizes.Garage; 

            garage.DoDragDrop(garage.Image, DragDropEffects.Copy);
        }

        private void hangar_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentDraggableItem.Type = TopologyItemType.Hangar;
            CurrentDraggableItem.Size = ItemSizes.Hangar;

            hangar.DoDragDrop(hangar.Image, DragDropEffects.Copy);
        }

        private void cargoTerminal_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentDraggableItem.Type = TopologyItemType.CargoTerminal;
            CurrentDraggableItem.Size = ItemSizes.CargoTerminal;

            cargoTerminal.DoDragDrop(cargoTerminal.Image, DragDropEffects.Copy);
        }

        private void passengerTerminal_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentDraggableItem.Type = TopologyItemType.PassengerTerminal;
            CurrentDraggableItem.Size = ItemSizes.PassengerTerminal;

            passengerTerminal.DoDragDrop(passengerTerminal.Image, DragDropEffects.Copy);
        }
         
        #endregion

        #region Drag Events

        private void extendedPanel_DragDrop(object sender, DragEventArgs e)
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
                else
                    left -= widths[i];
            }

            var row = -1;
            var top = clientPoint.Y;
            for (int i = 0; i < heights.Length; i++)
            {
                if (top < heights[i])
                {
                    row = i;
                    break;
                }
                else
                    top -= heights[i];
            }

            CurrentDraggableItem.Coordinates.X = col;
            CurrentDraggableItem.Coordinates.Y = row;
            AddCurrentItemToTopology();

            e.Effect = DragDropEffects.Copy;

            PictureBox pb = new PictureBox();

            var width = widths[col];
            var height = heights[row];

            var itemWidth = CurrentDraggableItem.Size.Width;
            var itemHeight = CurrentDraggableItem.Size.Height;

            pb.Size = new Size(itemWidth * width - 1, itemHeight * height - 1);
            pb.Location = new Point(col * width + 1, row * height + 1);
            pb.Image = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
            if (CurrentDraggableItem.Type == TopologyItemType.Runway) pb.SizeMode = PictureBoxSizeMode.StretchImage;
            else pb.SizeMode = PictureBoxSizeMode.Zoom;

            extendedPanel.Controls.Add(pb);
        }

        private void extendedPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion

        #region Button Click Events

        private void plusHorButton_Click(object sender, EventArgs e)
        {
            if (grid.ColumnCount < 25)
            {
                grid.ColumnCount++;
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
                Topology.Size.Width--;
                horGridOutput.Text = grid.ColumnCount.ToString();
            }
        }

        private void plusVerBut_Click(object sender, EventArgs e)
        {
            if (grid.RowCount < 25)
            {
                grid.RowCount++;
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

                    Topology = JsonSerializer.Deserialize<TopologyModel>(topologyJson, new JsonSerializerOptions()
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
            }
        }

        private void saveTopology_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream;
                try
                {
                    if ((fileStream = saveFileDialog.OpenFile()) != null)
                    {
                        var pathParts = saveFileDialog.FileName.Split('\\');
                        Topology.Name = pathParts[pathParts.Length - 1].Split('.')[0];

                        var topologyJson = JsonSerializer.Serialize(Topology, new JsonSerializerOptions()
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
                var pictureBox = new PictureBox();

                pictureBox.Image = item.Type switch
                {
                    TopologyItemType.AirportBuilding => airport.Image,
                    TopologyItemType.Garage => garage.Image,
                    TopologyItemType.Hangar => hangar.Image,
                    TopologyItemType.Runway => vpp.Image,
                    TopologyItemType.PassengerTerminal => passengerTerminal.Image,
                    TopologyItemType.CargoTerminal => cargoTerminal.Image,
                    _ => null
                };

                var X = item.Coordinates.X;
                var Y = item.Coordinates.Y;

                var width = grid.GetColumnWidths()[X];
                var height = grid.GetRowHeights()[Y];

                pictureBox.Size = new Size(item.Size.Width * width - 1, item.Size.Height * height - 1);
                pictureBox.Location = new Point(X * width + 1, Y * height + 1);

                if (item.Type == TopologyItemType.Runway)
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                else pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                extendedPanel.Controls.Add(pictureBox);
            } 
        }

        private void ResetTopology()
        {
            Topology.Name = "Название топологии";
            Topology.Items = new List<TopologyItemModel>();
            Topology.Size.Width = gridSize;
            Topology.Size.Height = gridSize;
            ApplyTopology();
        }

        private void AddCurrentItemToTopology()
        {
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

        #endregion

    }
}