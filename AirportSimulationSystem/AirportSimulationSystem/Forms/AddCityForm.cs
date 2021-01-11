using AirportSimulationSystem.Models.DTOs;
using System;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddCityForm : Form
    {
        public CityDTO CityDTO;
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CityDistanceTextBox.Text, out var distance) && !string.IsNullOrWhiteSpace(CityNameTextBox.Text))
            {
                CityDTO = new CityDTO
                {
                    Name = CityNameTextBox.Text,
                    Distance = distance
                };

                DialogResult = DialogResult.OK;
            }
        }

        private void CancelCityButton_Click(object sender, EventArgs e)
        {
            CityDTO = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
