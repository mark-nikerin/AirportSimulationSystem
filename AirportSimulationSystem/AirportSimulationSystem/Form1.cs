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
using System.Data.SqlClient;
using System.Globalization;

namespace AirportSimulationSystem
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView2 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private const int gridSize = 10;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Выберите файл с топологией",
                Filter = "Файлы JSON (*.json)|*.json"
            };

            createGrid(gridSize, gridSize);

            flightsGridView.Visible = true;
            citiesGridView.Visible = false;
            airplanesGridView.Visible = false;
            SetButtonActive(fligthsButton);
            SetButtonInactive(airplanesButton);
            SetButtonInactive(citiesButton);
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

        private void createGrid(int ver, int hor)
        {
            horGridOutput.Text = hor.ToString();
            verGridOutput.Text = ver.ToString();
            grid.RowCount = ver;
            grid.ColumnCount = hor;

            for (int i = 0; i < 10; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / grid.ColumnCount));
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / grid.RowCount));
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

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString =
                    "Data source=DELL-INSPIRON-5\\SQLEXPRESS;Initial Catalog=AirportDatabase;" +
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bindingSource1;
            //GetData("select FlightNumber '№ Рейса', Title 'Название', Time 'Время', RegistryNumber '№ стойки регистрации', SoldTicketsAmount 'Количество проданных билетов' from Flights");
        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            int[] widths = grid.GetColumnWidths();
            int[] heights = grid.GetRowHeights();

            int col = -1;
            int left = e.X;
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

            int row = -1;
            int top = e.Y;
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
            PictureBox pb = new PictureBox();
            pb.BackColor = Color.Red;
            grid.Controls.Add(pb, col, row);

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

        private void plusHorButton_Click(object sender, EventArgs e)
        {
            if (grid.ColumnCount < 25)
            {
                grid.ColumnCount++;
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / grid.ColumnCount));
                horGridOutput.Text = grid.ColumnCount.ToString();
            }
        }

        private void minusHorBut_Click(object sender, EventArgs e)
        {
            if (grid.ColumnCount > 10)
            {
                grid.ColumnCount--;
                horGridOutput.Text = grid.ColumnCount.ToString();
            }
        }

        private void plusVerBut_Click(object sender, EventArgs e)
        {
            if (grid.RowCount < 25)
            {
                grid.RowCount++;
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / grid.RowCount));
                verGridOutput.Text = grid.RowCount.ToString();
            }
        }

        private void minusVerBut_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 10)
            {
                grid.RowCount--;
                verGridOutput.Text = grid.RowCount.ToString();
            }
        }


        /*private Rectangle _rec = new Rectangle(0, 0, 50, 50);

    //    protected override void OnPaint(PaintEventArgs e) {
    //        e.Graphics.FillRectangle(Brushes.Aquamarine, _rec);
    //    }
    //    protected override void OnMouseDown(MouseEventArgs e) {
    //        if (e.Button != MouseButtons.Left && IsInsideWindow(e)) return;
    //        _rec = new Rectangle(e.X, e.Y, 50, 50);
    //        Invalidate();
    //    }
    //    protected override void OnMouseMove(MouseEventArgs e) {
    //        if (e.Button != MouseButtons.Left && IsInsideWindow(e)) return;
    //        _rec = new Rectangle(e.X - _rec.Width / 2, e.Y - _rec.Height / 2, 50, 50);
    //        Invalidate();
    //    }

    //    private bool IsInsideWindow(MouseEventArgs e)
    //    {
    //        var cursor = new Tuple<int,int>(e.X, e.Y);

    //        return cursor switch
    //        {
    //            var (x, y) when x <= Width && y <= Height => true,
    //            var (x, y) when x >= 0 && y >= 0 => true,
    //            var (_, _) => false
    //        };
    //    }*/
    }
}