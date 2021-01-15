using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddCityForm : Form
    {
        public CityDTO CityDTO { get; private set; }
        private ICollection<string> _errorMessagesList = new List<string>();

        private IEnumerable<CityDTO> _cities;

        public AddCityForm(ICollection<CityDTO> cities)
        {
            InitializeComponent();
            CityDistanceNumeric.Controls[0].Visible = false;

            _cities = cities.ToArray();
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                CityDTO = new CityDTO
                {
                    Name = CityNameTextBox.Text,
                    Distance = (int) CityDistanceNumeric.Value
                };

                DialogResult = DialogResult.OK;
            }
            else
            {
                var errorTextBuilder = new StringBuilder();
                errorTextBuilder.AppendJoin("\n", _errorMessagesList).ToString();
                errorTextBuilder.AppendLine("\n\nПроверьте вводимые значения и попробуйте еще раз.");
                var errorText = errorTextBuilder.ToString();
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _errorMessagesList = new List<string>();
            }
        }

        private void CancelCityButton_Click(object sender, EventArgs e)
        {
            CityDTO = null;
            _errorMessagesList = new List<string>();
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidForm()
        {
            if (_cities.Any(x => x.Name.Equals(CityNameTextBox.Text, StringComparison.OrdinalIgnoreCase)))
            {
                _errorMessagesList.Add("Город с таким названием уже существует");
                return false;
            }

            if (string.IsNullOrWhiteSpace(CityNameTextBox.Text)) _errorMessagesList.Add("Не указано название города");

            if (CityDistanceNumeric.Value == 0) _errorMessagesList.Add("Не указано расстояние до города");

            return _errorMessagesList.Count == 0;
        }
    }
}
