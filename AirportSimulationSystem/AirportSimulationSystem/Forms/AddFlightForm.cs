using AirportSimulationSystem.Models.DTOs;
using System;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddFlightForm : Form
    {
        public CityDTO CityDTO;
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FlightDistanceTextBox.Text, out var distance) && !string.IsNullOrWhiteSpace(FlightNameTextBox.Text))
            {
                CityDTO = new CityDTO
                {
                    Name = FlightNameTextBox.Text,
                    Distance = distance
                };

                DialogResult = DialogResult.OK;
            }
        }

        private void CancelFlightButton_Click(object sender, EventArgs e)
        {
            CityDTO = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
