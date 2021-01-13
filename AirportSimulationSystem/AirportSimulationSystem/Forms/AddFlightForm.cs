using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddFlightForm : Form
    {
        public FlightDTO FlightDTO;

        public AddFlightForm(ICollection<CityDTO> cities, ICollection<AirplaneDTO> airplanes)
        {
            InitializeComponent();

            var emptyCity = new CityDTO
            {
                Id = -1,
                Name = "Не выбрано"
            };

            var emptyAirplane = new AirplaneDTO
            {
                Id = -1,
                Model = "Не выбрано"
            };

            cities.Add(emptyCity);
            airplanes.Add(emptyAirplane);

            FlightCityComboBox.DisplayMember = "Name";
            FlightCityComboBox.ValueMember = "Id";
            FlightCityComboBox.DataSource = cities.OrderBy(x => x.Id).ToArray();
            FlightCityComboBox.SelectedItem = emptyCity;

            FlightAirplaneComboBox.DisplayMember = "Model";
            FlightAirplaneComboBox.ValueMember = "Id";
            FlightAirplaneComboBox.DataSource = airplanes.OrderBy(x => x.Id).ToArray();
            FlightAirplaneComboBox.SelectedItem = emptyAirplane;

            RegistryNumberComboBox.DataSource = new object[]
            {
                "Не выбрано",
                1,
                2,
                3,
                4
            };
            RegistryNumberComboBox.SelectedIndex = 0;

            SoldTicketsAmountNumeric.Controls[0].Visible = false;
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            var selectedCity = (CityDTO) FlightCityComboBox.SelectedItem;
            var selectedAirplane = (AirplaneDTO) FlightAirplaneComboBox.SelectedItem;
            var currentCityName = ConfigurationManager.AppSettings["CurrentCityName"];

            if (IsValidForm())
            {
                FlightDTO = new FlightDTO
                {
                    AirplaneId = selectedAirplane.Id,
                    CityId = selectedCity.Id,
                    FlightNumber = FlightNumberTextBox.Text,
                    IsArrival = !IsDepartureCheckBox.Checked,
                    RegistryNumber = (int) RegistryNumberComboBox.SelectedItem,
                    SoldTicketsAmount = (int) SoldTicketsAmountNumeric.Value,
                    Time = FlightTimePicker.Value,
                    Title = IsDepartureCheckBox.Checked
                    ? $"{currentCityName} - {selectedCity.Name}"
                    : $"{selectedCity.Name} - {currentCityName}"
                };

                DialogResult = DialogResult.OK;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelFlightButton_Click(object sender, EventArgs e)
        {
            FlightDTO = null;
            DialogResult = DialogResult.Cancel;
        }

        private void IsDepartureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FlightTimeTittle.Text = IsDepartureCheckBox.Checked
                ? "Время вылета"
                : "Время прибытия";
        }

        private bool IsValidForm()
        {
            return true;
        }
    }
}
