
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
            this.FlightNameTextBox = new System.Windows.Forms.TextBox();
            this.FlightDistanceTextBox = new System.Windows.Forms.TextBox();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.CancelFlightButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddFlightTittle
            // 
            this.AddFlightTittle.AutoSize = true;
            this.AddFlightTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFlightTittle.Location = new System.Drawing.Point(33, 2);
            this.AddFlightTittle.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.AddFlightTittle.Name = "AddFlightTittle";
            this.AddFlightTittle.Size = new System.Drawing.Size(167, 30);
            this.AddFlightTittle.TabIndex = 1;
            this.AddFlightTittle.Text = "Добавить город";
            // 
            // FlightNameTextBox
            // 
            this.FlightNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightNameTextBox.Location = new System.Drawing.Point(49, 79);
            this.FlightNameTextBox.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.FlightNameTextBox.Name = "FlightNameTextBox";
            this.FlightNameTextBox.PlaceholderText = "Введите название города";
            this.FlightNameTextBox.Size = new System.Drawing.Size(262, 29);
            this.FlightNameTextBox.TabIndex = 0;
            // 
            // FlightDistanceTextBox
            // 
            this.FlightDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightDistanceTextBox.Location = new System.Drawing.Point(49, 151);
            this.FlightDistanceTextBox.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.FlightDistanceTextBox.Name = "FlightDistanceTextBox";
            this.FlightDistanceTextBox.PlaceholderText = "Введите расстояние";
            this.FlightDistanceTextBox.Size = new System.Drawing.Size(262, 29);
            this.FlightDistanceTextBox.TabIndex = 2;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddFlightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlightButton.FlatAppearance.BorderSize = 0;
            this.AddFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFlightButton.Location = new System.Drawing.Point(33, 207);
            this.AddFlightButton.Margin = new System.Windows.Forms.Padding(24, 3, 3, 20);
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
            this.CancelFlightButton.Location = new System.Drawing.Point(193, 207);
            this.CancelFlightButton.Margin = new System.Windows.Forms.Padding(3, 3, 24, 20);
            this.CancelFlightButton.Name = "CancelFlightButton";
            this.CancelFlightButton.Size = new System.Drawing.Size(134, 32);
            this.CancelFlightButton.TabIndex = 10;
            this.CancelFlightButton.Text = "Отмена";
            this.CancelFlightButton.UseVisualStyleBackColor = false;
            this.CancelFlightButton.Click += new System.EventHandler(this.CancelFlightButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Название";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(49, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Расстояние, км";
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelFlightButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.FlightDistanceTextBox);
            this.Controls.Add(this.FlightNameTextBox);
            this.Controls.Add(this.AddFlightTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlightForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddFlightTittle;
        private System.Windows.Forms.TextBox FlightNameTextBox;
        private System.Windows.Forms.TextBox FlightDistanceTextBox;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button CancelFlightButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}