﻿
namespace AirportSimulationSystem
{
    partial class AddAirplaneForm
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
            this.AddAirplaneTittle = new System.Windows.Forms.Label();
            this.AirplaneModelTextBox = new System.Windows.Forms.TextBox();
            this.AddAirplaneButton = new System.Windows.Forms.Button();
            this.CancelAirplaneButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AirplaneDistanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.LiftingCapacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.PassengerCapacityNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneDistanceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftingCapacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerCapacityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAirplaneTittle
            // 
            this.AddAirplaneTittle.AutoSize = true;
            this.AddAirplaneTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAirplaneTittle.Location = new System.Drawing.Point(33, 2);
            this.AddAirplaneTittle.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.AddAirplaneTittle.Name = "AddAirplaneTittle";
            this.AddAirplaneTittle.Size = new System.Drawing.Size(191, 30);
            this.AddAirplaneTittle.TabIndex = 1;
            this.AddAirplaneTittle.Text = "Добавить самолёт";
            // 
            // AirplaneModelTextBox
            // 
            this.AirplaneModelTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AirplaneModelTextBox.Location = new System.Drawing.Point(49, 79);
            this.AirplaneModelTextBox.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.AirplaneModelTextBox.Name = "AirplaneModelTextBox";
            this.AirplaneModelTextBox.PlaceholderText = "Введите модель самолёта";
            this.AirplaneModelTextBox.Size = new System.Drawing.Size(262, 29);
            this.AirplaneModelTextBox.TabIndex = 0;
            // 
            // AddAirplaneButton
            // 
            this.AddAirplaneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddAirplaneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAirplaneButton.FlatAppearance.BorderSize = 0;
            this.AddAirplaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAirplaneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAirplaneButton.Location = new System.Drawing.Point(33, 360);
            this.AddAirplaneButton.Margin = new System.Windows.Forms.Padding(24, 3, 3, 20);
            this.AddAirplaneButton.Name = "AddAirplaneButton";
            this.AddAirplaneButton.Size = new System.Drawing.Size(134, 32);
            this.AddAirplaneButton.TabIndex = 9;
            this.AddAirplaneButton.Text = "ОК";
            this.AddAirplaneButton.UseVisualStyleBackColor = false;
            this.AddAirplaneButton.Click += new System.EventHandler(this.AddAirplaneButton_Click);
            // 
            // CancelAirplaneButton
            // 
            this.CancelAirplaneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelAirplaneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAirplaneButton.FlatAppearance.BorderSize = 0;
            this.CancelAirplaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAirplaneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelAirplaneButton.Location = new System.Drawing.Point(193, 360);
            this.CancelAirplaneButton.Margin = new System.Windows.Forms.Padding(3, 3, 24, 20);
            this.CancelAirplaneButton.Name = "CancelAirplaneButton";
            this.CancelAirplaneButton.Size = new System.Drawing.Size(134, 32);
            this.CancelAirplaneButton.TabIndex = 10;
            this.CancelAirplaneButton.Text = "Отмена";
            this.CancelAirplaneButton.UseVisualStyleBackColor = false;
            this.CancelAirplaneButton.Click += new System.EventHandler(this.CancelAirplaneButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дальность полёта, км";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Количество пассажирских мест";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Грузоподъёмность, кг";
            // 
            // AirplaneDistanceNumeric
            // 
            this.AirplaneDistanceNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AirplaneDistanceNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AirplaneDistanceNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AirplaneDistanceNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AirplaneDistanceNumeric.Location = new System.Drawing.Point(49, 151);
            this.AirplaneDistanceNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.AirplaneDistanceNumeric.Name = "AirplaneDistanceNumeric";
            this.AirplaneDistanceNumeric.Size = new System.Drawing.Size(262, 29);
            this.AirplaneDistanceNumeric.TabIndex = 30;
            this.AirplaneDistanceNumeric.ThousandsSeparator = true;
            // 
            // LiftingCapacityNumeric
            // 
            this.LiftingCapacityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiftingCapacityNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LiftingCapacityNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LiftingCapacityNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LiftingCapacityNumeric.Location = new System.Drawing.Point(49, 295);
            this.LiftingCapacityNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.LiftingCapacityNumeric.Name = "LiftingCapacityNumeric";
            this.LiftingCapacityNumeric.Size = new System.Drawing.Size(262, 29);
            this.LiftingCapacityNumeric.TabIndex = 31;
            this.LiftingCapacityNumeric.ThousandsSeparator = true;
            // 
            // PassengerCapacityNumeric
            // 
            this.PassengerCapacityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerCapacityNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerCapacityNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PassengerCapacityNumeric.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PassengerCapacityNumeric.Location = new System.Drawing.Point(49, 223);
            this.PassengerCapacityNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PassengerCapacityNumeric.Name = "PassengerCapacityNumeric";
            this.PassengerCapacityNumeric.Size = new System.Drawing.Size(262, 29);
            this.PassengerCapacityNumeric.TabIndex = 32;
            this.PassengerCapacityNumeric.ThousandsSeparator = true;
            // 
            // AddAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(360, 421);
            this.Controls.Add(this.PassengerCapacityNumeric);
            this.Controls.Add(this.LiftingCapacityNumeric);
            this.Controls.Add(this.AirplaneDistanceNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelAirplaneButton);
            this.Controls.Add(this.AddAirplaneButton);
            this.Controls.Add(this.AirplaneModelTextBox);
            this.Controls.Add(this.AddAirplaneTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAirplaneForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneDistanceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftingCapacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerCapacityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddAirplaneTittle;
        private System.Windows.Forms.TextBox AirplaneModelTextBox;
        private System.Windows.Forms.Button AddAirplaneButton;
        private System.Windows.Forms.Button CancelAirplaneButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AirplaneDistanceNumeric;
        private System.Windows.Forms.NumericUpDown LiftingCapacityNumeric;
        private System.Windows.Forms.NumericUpDown PassengerCapacityNumeric;
    }
}