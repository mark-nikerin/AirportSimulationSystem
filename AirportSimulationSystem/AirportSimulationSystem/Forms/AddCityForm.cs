using AirportSimulationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    public partial class AddCityForm : Form
    {
        public CityDTO CityDTO { get; private set; }
        public ICollection<string> ErrorMessagesList { get; private set; } = new List<string>();

        public AddCityForm()
        {
            InitializeComponent();
            CityDistanceNumeric.Controls[0].Visible = false;
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
                errorTextBuilder.AppendJoin("\n", ErrorMessagesList).ToString();
                errorTextBuilder.AppendLine("\n\nПроверьте вводимые значения и попробуйте еще раз.");
                var errorText = errorTextBuilder.ToString();
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK);
                ErrorMessagesList = new List<string>();
            }
        }

        private void CancelCityButton_Click(object sender, EventArgs e)
        {
            CityDTO = null;
            ErrorMessagesList = new List<string>();
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidForm()
        {
            if (string.IsNullOrWhiteSpace(CityNameTextBox.Text)) ErrorMessagesList.Add("Не указано название города");

            if (CityDistanceNumeric.Value == 0) ErrorMessagesList.Add("Не указано расстояние до города");

            return ErrorMessagesList.Count == 0;
        }
    }
}
