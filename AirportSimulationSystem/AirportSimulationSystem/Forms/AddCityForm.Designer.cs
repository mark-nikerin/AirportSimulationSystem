
namespace AirportSimulationSystem
{
    partial class AddCityForm
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
            this.AddCityTittle = new System.Windows.Forms.Label();
            this.CityNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.CancelCityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CityDistanceNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CityDistanceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCityTittle
            // 
            this.AddCityTittle.AutoSize = true;
            this.AddCityTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCityTittle.Location = new System.Drawing.Point(33, 2);
            this.AddCityTittle.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.AddCityTittle.Name = "AddCityTittle";
            this.AddCityTittle.Size = new System.Drawing.Size(167, 30);
            this.AddCityTittle.TabIndex = 1;
            this.AddCityTittle.Text = "Добавить город";
            // 
            // CityNameTextBox
            // 
            this.CityNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityNameTextBox.Location = new System.Drawing.Point(49, 79);
            this.CityNameTextBox.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.CityNameTextBox.Name = "CityNameTextBox";
            this.CityNameTextBox.PlaceholderText = "Введите название города";
            this.CityNameTextBox.Size = new System.Drawing.Size(262, 29);
            this.CityNameTextBox.TabIndex = 0;
            // 
            // AddCityButton
            // 
            this.AddCityButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCityButton.FlatAppearance.BorderSize = 0;
            this.AddCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCityButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCityButton.Location = new System.Drawing.Point(33, 207);
            this.AddCityButton.Margin = new System.Windows.Forms.Padding(24, 3, 3, 20);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(134, 32);
            this.AddCityButton.TabIndex = 9;
            this.AddCityButton.Text = "ОК";
            this.AddCityButton.UseVisualStyleBackColor = false;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // CancelCityButton
            // 
            this.CancelCityButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelCityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelCityButton.FlatAppearance.BorderSize = 0;
            this.CancelCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelCityButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelCityButton.Location = new System.Drawing.Point(193, 207);
            this.CancelCityButton.Margin = new System.Windows.Forms.Padding(3, 3, 24, 20);
            this.CancelCityButton.Name = "CancelCityButton";
            this.CancelCityButton.Size = new System.Drawing.Size(134, 32);
            this.CancelCityButton.TabIndex = 10;
            this.CancelCityButton.Text = "Отмена";
            this.CancelCityButton.UseVisualStyleBackColor = false;
            this.CancelCityButton.Click += new System.EventHandler(this.CancelCityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Расстояние, км";
            // 
            // CityDistanceNumeric
            // 
            this.CityDistanceNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityDistanceNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityDistanceNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CityDistanceNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CityDistanceNumeric.Location = new System.Drawing.Point(49, 151);
            this.CityDistanceNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.CityDistanceNumeric.Name = "CityDistanceNumeric";
            this.CityDistanceNumeric.Size = new System.Drawing.Size(262, 29);
            this.CityDistanceNumeric.TabIndex = 29;
            this.CityDistanceNumeric.ThousandsSeparator = true;
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.CityDistanceNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelCityButton);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.CityNameTextBox);
            this.Controls.Add(this.AddCityTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.CityDistanceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCityTittle;
        private System.Windows.Forms.TextBox CityNameTextBox;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.Button CancelCityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CityDistanceNumeric;
    }
}