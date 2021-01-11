using AirportSimulationSystem.Models.DTOs;
using System;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddAirplaneForm : Form
    {
        public AirplaneDTO AirplaneDTO;
        public AddAirplaneForm()
        {
            InitializeComponent();
        }

        private void AddAirplaneButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AirplaneDistanceTextBox.Text, out var distance)
                && int.TryParse(PassengerCapacityTextBox.Text, out var passengerCapacity)
                && int.TryParse(LiftingCapacityTextBox.Text, out var liftingCapacity)
                && !string.IsNullOrWhiteSpace(AirplaneModelTextBox.Text)
                )
            {
                AirplaneDTO = new AirplaneDTO
                {
                    Model = AirplaneModelTextBox.Text,
                    Distance = distance,
                    PassengerCapacity = passengerCapacity,
                    LiftingCapacity = liftingCapacity
                };

                DialogResult = DialogResult.OK;
            }
        }

        private void CancelAirplaneButton_Click(object sender, EventArgs e)
        {
            AirplaneDTO = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
