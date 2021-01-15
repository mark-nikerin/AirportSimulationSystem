
using AirportSimulationSystem.Helpers;

namespace AirportSimulationSystem
{
    partial class AddFlightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddFlightTittle = new System.Windows.Forms.Label();
            this.FlightNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.CancelFlightButton = new System.Windows.Forms.Button();
            this.FightNumberTittle = new System.Windows.Forms.Label();
            this.FlightTimeTittle = new System.Windows.Forms.Label();
            this.RegistryNumberTittle = new System.Windows.Forms.Label();
            this.FlightCityTittle = new System.Windows.Forms.Label();
            this.FlightAirplaneModelTittle = new System.Windows.Forms.Label();
            this.SoldTicketsAmountTittle = new System.Windows.Forms.Label();
            this.FlightCityComboBox = new AirportSimulationSystem.Helpers.FlatComboWithBorder();
            this.FlightAirplaneComboBox = new AirportSimulationSystem.Helpers.FlatComboWithBorder();
            this.RegistryNumberComboBox = new AirportSimulationSystem.Helpers.FlatComboWithBorder();
            this.IsDepartureCheckBox = new System.Windows.Forms.CheckBox();
            this.FlightTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SoldTicketsAmountNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SoldTicketsAmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFlightTittle
            // 
            this.AddFlightTittle.AutoSize = true;
            this.AddFlightTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFlightTittle.Location = new System.Drawing.Point(33, 2);
            this.AddFlightTittle.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.AddFlightTittle.Name = "AddFlightTittle";
            this.AddFlightTittle.Size = new System.Drawing.Size(157, 30);
            this.AddFlightTittle.TabIndex = 1;
            this.AddFlightTittle.Text = "Добавить рейс";
            // 
            // FlightNumberTextBox
            // 
            this.FlightNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightNumberTextBox.Location = new System.Drawing.Point(49, 79);
            this.FlightNumberTextBox.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.FlightNumberTextBox.Name = "FlightNumberTextBox";
            this.FlightNumberTextBox.PlaceholderText = "Введите код рейса";
            this.FlightNumberTextBox.Size = new System.Drawing.Size(262, 29);
            this.FlightNumberTextBox.TabIndex = 0;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddFlightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlightButton.FlatAppearance.BorderSize = 0;
            this.AddFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFlightButton.Location = new System.Drawing.Point(177, 285);
            this.AddFlightButton.Margin = new System.Windows.Forms.Padding(24, 30, 3, 20);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(134, 32);
            this.AddFlightButton.TabIndex = 9;
            this.AddFlightButton.Text = "ОК";
            this.AddFlightButton.UseVisualStyleBackColor = false;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // CancelFlightButton
            // 
            this.CancelFlightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelFlightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelFlightButton.FlatAppearance.BorderSize = 0;
            this.CancelFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFlightButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelFlightButton.Location = new System.Drawing.Point(391, 285);
            this.CancelFlightButton.Margin = new System.Windows.Forms.Padding(3, 20, 24, 20);
            this.CancelFlightButton.Name = "CancelFlightButton";
            this.CancelFlightButton.Size = new System.Drawing.Size(134, 32);
            this.CancelFlightButton.TabIndex = 10;
            this.CancelFlightButton.Text = "Отмена";
            this.CancelFlightButton.UseVisualStyleBackColor = false;
            this.CancelFlightButton.Click += new System.EventHandler(this.CancelFlightButton_Click);
            // 
            // FightNumberTittle
            // 
            this.FightNumberTittle.AutoSize = true;
            this.FightNumberTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FightNumberTittle.Location = new System.Drawing.Point(49, 59);
            this.FightNumberTittle.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.FightNumberTittle.Name = "FightNumberTittle";
            this.FightNumberTittle.Size = new System.Drawing.Size(35, 17);
            this.FightNumberTittle.TabIndex = 11;
            this.FightNumberTittle.Text = "Рейс";
            // 
            // FlightTimeTittle
            // 
            this.FlightTimeTittle.AutoSize = true;
            this.FlightTimeTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightTimeTittle.Location = new System.Drawing.Point(391, 59);
            this.FlightTimeTittle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.FlightTimeTittle.Name = "FlightTimeTittle";
            this.FlightTimeTittle.Size = new System.Drawing.Size(108, 17);
            this.FlightTimeTittle.TabIndex = 13;
            this.FlightTimeTittle.Text = "Время прибытия";
            // 
            // RegistryNumberTittle
            // 
            this.RegistryNumberTittle.AutoSize = true;
            this.RegistryNumberTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistryNumberTittle.Location = new System.Drawing.Point(391, 203);
            this.RegistryNumberTittle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.RegistryNumberTittle.Name = "RegistryNumberTittle";
            this.RegistryNumberTittle.Size = new System.Drawing.Size(170, 17);
            this.RegistryNumberTittle.TabIndex = 15;
            this.RegistryNumberTittle.Text = "Номер стойки регистрации";
            // 
            // FlightCityTittle
            // 
            this.FlightCityTittle.AutoSize = true;
            this.FlightCityTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightCityTittle.Location = new System.Drawing.Point(49, 131);
            this.FlightCityTittle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.FlightCityTittle.Name = "FlightCityTittle";
            this.FlightCityTittle.Size = new System.Drawing.Size(126, 17);
            this.FlightCityTittle.TabIndex = 17;
            this.FlightCityTittle.Text = "Город отправления";
            // 
            // FlightAirplaneModelTittle
            // 
            this.FlightAirplaneModelTittle.AutoSize = true;
            this.FlightAirplaneModelTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightAirplaneModelTittle.Location = new System.Drawing.Point(391, 131);
            this.FlightAirplaneModelTittle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.FlightAirplaneModelTittle.Name = "FlightAirplaneModelTittle";
            this.FlightAirplaneModelTittle.Size = new System.Drawing.Size(59, 17);
            this.FlightAirplaneModelTittle.TabIndex = 19;
            this.FlightAirplaneModelTittle.Text = "Самолёт";
            // 
            // SoldTicketsAmountTittle
            // 
            this.SoldTicketsAmountTittle.AutoSize = true;
            this.SoldTicketsAmountTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoldTicketsAmountTittle.Location = new System.Drawing.Point(49, 203);
            this.SoldTicketsAmountTittle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.SoldTicketsAmountTittle.Name = "SoldTicketsAmountTittle";
            this.SoldTicketsAmountTittle.Size = new System.Drawing.Size(168, 17);
            this.SoldTicketsAmountTittle.TabIndex = 21;
            this.SoldTicketsAmountTittle.Text = "Число проданных билетов";
            // 
            // FlightCityComboBox
            // 
            this.FlightCityComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.FlightCityComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlightCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightCityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightCityComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightCityComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FlightCityComboBox.FormattingEnabled = true;
            this.FlightCityComboBox.Location = new System.Drawing.Point(49, 151);
            this.FlightCityComboBox.MaxDropDownItems = 100;
            this.FlightCityComboBox.Name = "FlightCityComboBox";
            this.FlightCityComboBox.Size = new System.Drawing.Size(262, 29);
            this.FlightCityComboBox.TabIndex = 23;
            this.FlightCityComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightCityComboBox_SelectedIndexChanged);
            // 
            // FlightAirplaneComboBox
            // 
            this.FlightAirplaneComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlightAirplaneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightAirplaneComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightAirplaneComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightAirplaneComboBox.FormattingEnabled = true;
            this.FlightAirplaneComboBox.Location = new System.Drawing.Point(391, 151);
            this.FlightAirplaneComboBox.MaxDropDownItems = 100;
            this.FlightAirplaneComboBox.Name = "FlightAirplaneComboBox";
            this.FlightAirplaneComboBox.Size = new System.Drawing.Size(262, 29);
            this.FlightAirplaneComboBox.TabIndex = 24;
            this.FlightAirplaneComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightAirplaneComboBox_SelectedIndexChanged);
            // 
            // RegistryNumberComboBox
            // 
            this.RegistryNumberComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistryNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegistryNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistryNumberComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistryNumberComboBox.FormattingEnabled = true;
            this.RegistryNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RegistryNumberComboBox.Location = new System.Drawing.Point(391, 223);
            this.RegistryNumberComboBox.MaxDropDownItems = 100;
            this.RegistryNumberComboBox.Name = "RegistryNumberComboBox";
            this.RegistryNumberComboBox.Size = new System.Drawing.Size(262, 29);
            this.RegistryNumberComboBox.TabIndex = 25;
            // 
            // IsDepartureCheckBox
            // 
            this.IsDepartureCheckBox.AutoSize = true;
            this.IsDepartureCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsDepartureCheckBox.Location = new System.Drawing.Point(577, 83);
            this.IsDepartureCheckBox.Name = "IsDepartureCheckBox";
            this.IsDepartureCheckBox.Size = new System.Drawing.Size(76, 25);
            this.IsDepartureCheckBox.TabIndex = 26;
            this.IsDepartureCheckBox.Text = " Вылет";
            this.IsDepartureCheckBox.UseVisualStyleBackColor = true;
            this.IsDepartureCheckBox.CheckedChanged += new System.EventHandler(this.IsDepartureCheckBox_CheckedChanged);
            // 
            // FlightTimePicker
            // 
            this.FlightTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightTimePicker.CustomFormat = "HH:mm";
            this.FlightTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightTimePicker.Location = new System.Drawing.Point(391, 79);
            this.FlightTimePicker.Name = "FlightTimePicker";
            this.FlightTimePicker.ShowUpDown = true;
            this.FlightTimePicker.Size = new System.Drawing.Size(153, 29);
            this.FlightTimePicker.TabIndex = 27;
            this.FlightTimePicker.Value = new System.DateTime(2021, 1, 15, 12, 0, 0, 0);
            // 
            // SoldTicketsAmountNumeric
            // 
            this.SoldTicketsAmountNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoldTicketsAmountNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoldTicketsAmountNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SoldTicketsAmountNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SoldTicketsAmountNumeric.Location = new System.Drawing.Point(49, 224);
            this.SoldTicketsAmountNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SoldTicketsAmountNumeric.Name = "SoldTicketsAmountNumeric";
            this.SoldTicketsAmountNumeric.Size = new System.Drawing.Size(262, 29);
            this.SoldTicketsAmountNumeric.TabIndex = 28;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(702, 346);
            this.Controls.Add(this.SoldTicketsAmountNumeric);
            this.Controls.Add(this.FlightTimePicker);
            this.Controls.Add(this.IsDepartureCheckBox);
            this.Controls.Add(this.RegistryNumberComboBox);
            this.Controls.Add(this.FlightAirplaneComboBox);
            this.Controls.Add(this.FlightCityComboBox);
            this.Controls.Add(this.SoldTicketsAmountTittle);
            this.Controls.Add(this.FlightAirplaneModelTittle);
            this.Controls.Add(this.FlightCityTittle);
            this.Controls.Add(this.RegistryNumberTittle);
            this.Controls.Add(this.FlightTimeTittle);
            this.Controls.Add(this.FightNumberTittle);
            this.Controls.Add(this.CancelFlightButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.FlightNumberTextBox);
            this.Controls.Add(this.AddFlightTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlightForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.SoldTicketsAmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddFlightTittle;
        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button CancelFlightButton;
        private System.Windows.Forms.Label FightNumberTittle;
        private System.Windows.Forms.Label FlightTimeTittle;
        private System.Windows.Forms.Label RegistryNumberTittle;
        private System.Windows.Forms.Label FlightCityTittle;
        private System.Windows.Forms.Label FlightAirplaneModelTittle;
        private System.Windows.Forms.Label SoldTicketsAmountTittle;
        private FlatComboWithBorder FlightCityComboBox;
        private FlatComboWithBorder FlightAirplaneComboBox;
        private FlatComboWithBorder RegistryNumberComboBox;
        private System.Windows.Forms.CheckBox IsDepartureCheckBox;
        private System.Windows.Forms.DateTimePicker FlightTimePicker;
        private System.Windows.Forms.NumericUpDown SoldTicketsAmountNumeric;
    }
}