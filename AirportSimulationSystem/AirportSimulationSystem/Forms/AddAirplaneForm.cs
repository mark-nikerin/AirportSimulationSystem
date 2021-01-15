using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddAirplaneForm : Form
    {
        public AirplaneDTO AirplaneDTO { get; private set; }
        public ICollection<string> ErrorMessagesList { get; private set; } = new List<string>();

        public AddAirplaneForm()
        {
            InitializeComponent();
            AirplaneDistanceNumeric.Controls[0].Visible = false;
            LiftingCapacityNumeric.Controls[0].Visible = false;
            PassengerCapacityNumeric.Controls[0].Visible = false;
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
                errorTextBuilder.AppendJoin("\n", ErrorMessagesList).ToString();
                errorTextBuilder.AppendLine("\n\nПроверьте вводимые значения и попробуйте еще раз.");
                var errorText = errorTextBuilder.ToString();
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK);
                ErrorMessagesList = new List<string>();
            }
        }

        private void CancelAirplaneButton_Click(object sender, EventArgs e)
        {
            AirplaneDTO = null;
            ErrorMessagesList = new List<string>();
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidForm()
        {
            if (string.IsNullOrWhiteSpace(AirplaneModelTextBox.Text)) ErrorMessagesList.Add("Не указана модель самолёта");

            if (AirplaneDistanceNumeric.Value == 0) ErrorMessagesList.Add("Не указана дальность полёта");

            if (PassengerCapacityNumeric.Value == 0) ErrorMessagesList.Add("Не указана пассажировместимость");

            if (LiftingCapacityNumeric.Value == 0) ErrorMessagesList.Add("Не указана грузоподъемность");

            return ErrorMessagesList.Count == 0;
        }
    }
}
