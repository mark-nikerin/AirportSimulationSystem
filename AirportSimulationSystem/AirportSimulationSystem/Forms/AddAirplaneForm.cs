using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddAirplaneForm : Form
    {
        public AirplaneDTO AirplaneDTO { get; private set; }
        private ICollection<string> _errorMessagesList = new List<string>();

        private IEnumerable<AirplaneDTO> _airplanes;

        public AddAirplaneForm(ICollection<AirplaneDTO> airplanes)
        {
            InitializeComponent();
            AirplaneDistanceNumeric.Controls[0].Visible = false;
            LiftingCapacityNumeric.Controls[0].Visible = false;
            PassengerCapacityNumeric.Controls[0].Visible = false;

            _airplanes = airplanes.ToArray();
        }

        private void AddAirplaneButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                AirplaneDTO = new AirplaneDTO
                {
                    Model = AirplaneModelTextBox.Text,
                    Distance = (int)AirplaneDistanceNumeric.Value,
                    PassengerCapacity = (int)PassengerCapacityNumeric.Value,
                    LiftingCapacity = (int)LiftingCapacityNumeric.Value
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

        private void CancelAirplaneButton_Click(object sender, EventArgs e)
        {
            AirplaneDTO = null;
            _errorMessagesList = new List<string>();
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidForm()
        {
            if (_airplanes.Any(x => x.Model.Equals(AirplaneModelTextBox.Text, StringComparison.OrdinalIgnoreCase)))
            {
                _errorMessagesList.Add("Самолёт такой модели уже существует");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AirplaneModelTextBox.Text)) _errorMessagesList.Add("Не указана модель самолёта");

            if (AirplaneDistanceNumeric.Value == 0) _errorMessagesList.Add("Не указана дальность полёта");

            if (PassengerCapacityNumeric.Value == 0) _errorMessagesList.Add("Не указана пассажировместимость");

            if (LiftingCapacityNumeric.Value == 0) _errorMessagesList.Add("Не указана грузоподъемность");

            return _errorMessagesList.Count == 0;
        }
    }
}
