using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddFlightForm : Form
    {
        public FlightDTO FlightDTO { get; private set; }
        private ICollection<string> _errorMessagesList = new List<string>();
        private IEnumerable<CityDTO> _cities;
        private IEnumerable<AirplaneDTO> _airplanes;


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

            _cities = cities.OrderBy(x => x.Id).ToArray();
            _airplanes = airplanes.OrderBy(x => x.Id).ToArray();

            FlightCityComboBox.DisplayMember = "Name";
            FlightCityComboBox.ValueMember = "Id";
            FlightCityComboBox.DataSource = _cities;

            FlightAirplaneComboBox.DisplayMember = "Model";
            FlightAirplaneComboBox.ValueMember = "Id";
            FlightAirplaneComboBox.DataSource = _airplanes;

            RegistryNumberComboBox.DataSource = new object[]
            {
                "Не выбрано",
                1,
                2,
                3,
                4
            };

            FlightCityComboBox.SelectedItem = emptyCity;
            FlightAirplaneComboBox.SelectedItem = emptyAirplane;
            RegistryNumberComboBox.SelectedIndex = 0;

            SoldTicketsAmountNumeric.Controls[0].Hide();
            FlightAirplaneComboBox.Enabled = false;
            SoldTicketsAmountNumeric.Enabled = false;
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            var selectedCity = (CityDTO)FlightCityComboBox.SelectedItem;
            var selectedAirplane = (AirplaneDTO)FlightAirplaneComboBox.SelectedItem;
            var currentCityName = ConfigurationManager.AppSettings["CurrentCityName"];

            if (IsValidForm())
            {
                FlightDTO = new FlightDTO
                {
                    AirplaneId = selectedAirplane.Id,
                    CityId = selectedCity.Id,
                    FlightNumber = FlightNumberTextBox.Text,
                    IsArrival = !IsDepartureCheckBox.Checked,
                    RegistryNumber = (int)RegistryNumberComboBox.SelectedItem,
                    SoldTicketsAmount = (int)SoldTicketsAmountNumeric.Value,
                    Time = FlightTimePicker.Value.ToString("H:mm"),
                    Title = IsDepartureCheckBox.Checked
                    ? $"{currentCityName} - {selectedCity.Name}"
                    : $"{selectedCity.Name} - {currentCityName}"
                };

                DialogResult = DialogResult.OK;
            }
            else
            {
                var errorTextBuilder = new StringBuilder();
                errorTextBuilder.AppendJoin("\n", _errorMessagesList).ToString();
                errorTextBuilder.AppendLine("\n\nПроверьте вводимые значения и попробуйте еще раз.");
                var errorText = errorTextBuilder.ToString();
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK);
                _errorMessagesList = new List<string>();
            }
        }

        private void CancelFlightButton_Click(object sender, EventArgs e)
        {
            FlightDTO = null;
            _errorMessagesList = new List<string>();
            DialogResult = DialogResult.Cancel;
        }

        private void IsDepartureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FlightTimeTittle.Text = IsDepartureCheckBox.Checked
                ? "Время вылета"
                : "Время прибытия";

            FlightCityTittle.Text = IsDepartureCheckBox.Checked
                ? "Город назначения"
                : "Город отправления";
        }

        private bool IsValidForm()
        {
            if (string.IsNullOrWhiteSpace(FlightNumberTextBox.Text)) _errorMessagesList.Add("Не указан код рейса");
            if (FlightCityComboBox.SelectedIndex == 0) _errorMessagesList.Add("Не выбран город прибытия");
            if (FlightAirplaneComboBox.SelectedIndex == 0) _errorMessagesList.Add("Не выбран самолёт");
            if (RegistryNumberComboBox.SelectedIndex == 0) _errorMessagesList.Add("Не выбрана стойка регистрации");
            if (SoldTicketsAmountNumeric.Value == 0) _errorMessagesList.Add("Не указано количество проданных билетов");

            if (_errorMessagesList.Count > 0) return false;

            return true;
        }

        private void FlightCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightAirplaneComboBox.DataSource == null) return;

            var selectedCity = (CityDTO)FlightCityComboBox.SelectedItem;

            if (selectedCity.Id == -1)
            {
                FlightAirplaneComboBox.Enabled = false;
                return;
            }
            else
            {
                FlightAirplaneComboBox.Enabled = true;
            }

            var goodPlanes = selectedCity.Id == -1
                ? _airplanes.Select(x => x).ToList()
                : _airplanes
                    .Where(x => x.Distance >= selectedCity.Distance || x.Id == -1)
                    .ToList();

            goodPlanes[0].Model = goodPlanes.Count == 1
                ? "Нет подходящих самолётов"
                : "Не выбрано";

            FlightAirplaneComboBox.DataSource = goodPlanes;
            FlightAirplaneComboBox.Refresh();
        }

        private void FlightAirplaneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAirplane = (AirplaneDTO)FlightAirplaneComboBox.SelectedItem;
            if (selectedAirplane.Id == -1)
            {
                SoldTicketsAmountNumeric.Enabled = false;
            }
            else
            {
                SoldTicketsAmountNumeric.Enabled = true;
                SoldTicketsAmountNumeric.Maximum = selectedAirplane.PassengerCapacity;
            }
            SoldTicketsAmountNumeric.Refresh();
        }
    }
}
