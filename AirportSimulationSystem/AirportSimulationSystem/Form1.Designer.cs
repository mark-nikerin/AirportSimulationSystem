namespace AirportSimulationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.goToTopologyButton = new System.Windows.Forms.Button();
            this.LoadTopologyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.topologyName = new System.Windows.Forms.Label();
            this.goToScheduleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backToMainPageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goToSimulationPagebutton = new System.Windows.Forms.Button();
            this.backToTopologyPage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDeskNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Airplane = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoldTicketsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulationPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backToScheduleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.TopologyPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SchedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SimulationPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создайте топологию аэропорта с нуля \nили загрузите готовый файл";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goToTopologyButton
            // 
            this.goToTopologyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.goToTopologyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToTopologyButton.FlatAppearance.BorderSize = 0;
            this.goToTopologyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToTopologyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goToTopologyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.goToTopologyButton.Location = new System.Drawing.Point(365, 462);
            this.goToTopologyButton.Name = "goToTopologyButton";
            this.goToTopologyButton.Size = new System.Drawing.Size(244, 32);
            this.goToTopologyButton.TabIndex = 1;
            this.goToTopologyButton.Text = "Создать";
            this.goToTopologyButton.UseVisualStyleBackColor = false;
            this.goToTopologyButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LoadTopologyButton
            // 
            this.LoadTopologyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.LoadTopologyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadTopologyButton.FlatAppearance.BorderSize = 0;
            this.LoadTopologyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTopologyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadTopologyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoadTopologyButton.Location = new System.Drawing.Point(615, 462);
            this.LoadTopologyButton.Name = "LoadTopologyButton";
            this.LoadTopologyButton.Size = new System.Drawing.Size(244, 32);
            this.LoadTopologyButton.TabIndex = 2;
            this.LoadTopologyButton.Text = "Загрузить";
            this.LoadTopologyButton.UseVisualStyleBackColor = false;
            this.LoadTopologyButton.Click += new System.EventHandler(this.LoadTopologyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 149);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.TopologyPage);
            this.tabControl1.Controls.Add(this.SchedulePage);
            this.tabControl1.Controls.Add(this.SimulationPage);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 688);
            this.tabControl1.TabIndex = 4;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.White;
            this.MainPage.Controls.Add(this.LoadTopologyButton);
            this.MainPage.Controls.Add(this.pictureBox1);
            this.MainPage.Controls.Add(this.goToTopologyButton);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainPage.Location = new System.Drawing.Point(4, 24);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1255, 660);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            // 
            // TopologyPage
            // 
            this.TopologyPage.BackColor = System.Drawing.Color.White;
            this.TopologyPage.Controls.Add(this.topologyName);
            this.TopologyPage.Controls.Add(this.goToScheduleButton);
            this.TopologyPage.Controls.Add(this.panel1);
            this.TopologyPage.Location = new System.Drawing.Point(4, 24);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Size = new System.Drawing.Size(1255, 660);
            this.TopologyPage.TabIndex = 3;
            this.TopologyPage.Text = "Топология";
            // 
            // topologyName
            // 
            this.topologyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topologyName.Location = new System.Drawing.Point(450, 24);
            this.topologyName.Name = "topologyName";
            this.topologyName.Size = new System.Drawing.Size(798, 30);
            this.topologyName.TabIndex = 4;
            this.topologyName.Text = "Название топологии";
            this.topologyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goToScheduleButton
            // 
            this.goToScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.goToScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToScheduleButton.FlatAppearance.BorderSize = 0;
            this.goToScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goToScheduleButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.goToScheduleButton.Location = new System.Drawing.Point(1054, 613);
            this.goToScheduleButton.Name = "goToScheduleButton";
            this.goToScheduleButton.Size = new System.Drawing.Size(134, 32);
            this.goToScheduleButton.TabIndex = 3;
            this.goToScheduleButton.Text = "Далее";
            this.goToScheduleButton.UseVisualStyleBackColor = false;
            this.goToScheduleButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.backToMainPageButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 657);
            this.panel1.TabIndex = 1;
            // 
            // backToMainPageButton
            // 
            this.backToMainPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.backToMainPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainPageButton.FlatAppearance.BorderSize = 0;
            this.backToMainPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainPageButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToMainPageButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backToMainPageButton.Location = new System.Drawing.Point(142, 613);
            this.backToMainPageButton.Name = "backToMainPageButton";
            this.backToMainPageButton.Size = new System.Drawing.Size(134, 32);
            this.backToMainPageButton.TabIndex = 2;
            this.backToMainPageButton.Text = "Назад";
            this.backToMainPageButton.UseVisualStyleBackColor = false;
            this.backToMainPageButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расположите объекты на \r\nсетке топологии аэропорта";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы топологии";
            // 
            // SchedulePage
            // 
            this.SchedulePage.BackColor = System.Drawing.Color.White;
            this.SchedulePage.Controls.Add(this.comboBox1);
            this.SchedulePage.Controls.Add(this.textBox1);
            this.SchedulePage.Controls.Add(this.goToSimulationPagebutton);
            this.SchedulePage.Controls.Add(this.backToTopologyPage);
            this.SchedulePage.Controls.Add(this.dataGridView1);
            this.SchedulePage.Location = new System.Drawing.Point(4, 24);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulePage.Size = new System.Drawing.Size(1255, 660);
            this.SchedulePage.TabIndex = 1;
            this.SchedulePage.Text = "Расписание";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  Город",
            "  № Стойки",
            "  Самолёт"});
            this.comboBox1.Location = new System.Drawing.Point(75, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 25);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "   Город";
            this.comboBox1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(182, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "   Начните печатать для поиска";
            this.textBox1.Size = new System.Drawing.Size(995, 25);
            this.textBox1.TabIndex = 5;
            // 
            // goToSimulationPagebutton
            // 
            this.goToSimulationPagebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.goToSimulationPagebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSimulationPagebutton.FlatAppearance.BorderSize = 0;
            this.goToSimulationPagebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSimulationPagebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goToSimulationPagebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.goToSimulationPagebutton.Location = new System.Drawing.Point(1054, 613);
            this.goToSimulationPagebutton.Name = "goToSimulationPagebutton";
            this.goToSimulationPagebutton.Size = new System.Drawing.Size(134, 32);
            this.goToSimulationPagebutton.TabIndex = 4;
            this.goToSimulationPagebutton.Text = "Далее";
            this.goToSimulationPagebutton.UseVisualStyleBackColor = false;
            this.goToSimulationPagebutton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // backToTopologyPage
            // 
            this.backToTopologyPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.backToTopologyPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToTopologyPage.FlatAppearance.BorderSize = 0;
            this.backToTopologyPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToTopologyPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToTopologyPage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backToTopologyPage.Location = new System.Drawing.Point(142, 613);
            this.backToTopologyPage.Name = "backToTopologyPage";
            this.backToTopologyPage.Size = new System.Drawing.Size(134, 32);
            this.backToTopologyPage.TabIndex = 3;
            this.backToTopologyPage.Text = "Назад";
            this.backToTopologyPage.UseVisualStyleBackColor = false;
            this.backToTopologyPage.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNumber,
            this.Title,
            this.IsArrival,
            this.Time,
            this.RegistrationDeskNumber,
            this.City,
            this.Airplane,
            this.SoldTicketsAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(75, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // FlightNumber
            // 
            this.FlightNumber.HeaderText = "№ Рейса";
            this.FlightNumber.MinimumWidth = 20;
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightNumber.Width = 90;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.Width = 120;
            // 
            // IsArrival
            // 
            this.IsArrival.HeaderText = "Прибытие / Отбытие";
            this.IsArrival.MinimumWidth = 100;
            this.IsArrival.Name = "IsArrival";
            this.IsArrival.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsArrival.Width = 160;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 20;
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.Width = 80;
            // 
            // RegistrationDeskNumber
            // 
            this.RegistrationDeskNumber.HeaderText = "№ Стойки регистрации";
            this.RegistrationDeskNumber.MinimumWidth = 100;
            this.RegistrationDeskNumber.Name = "RegistrationDeskNumber";
            this.RegistrationDeskNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegistrationDeskNumber.Width = 170;
            // 
            // City
            // 
            this.City.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.City.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 100;
            this.City.Name = "City";
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.City.Width = 120;
            // 
            // Airplane
            // 
            this.Airplane.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Airplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Airplane.HeaderText = "Самолёт";
            this.Airplane.Items.AddRange(new object[] {
            "AIRBUS-A320",
            "МиГ-23",
            "МиГ-29 СМТ"});
            this.Airplane.MinimumWidth = 100;
            this.Airplane.Name = "Airplane";
            this.Airplane.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Airplane.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Airplane.Width = 120;
            // 
            // SoldTicketsAmount
            // 
            this.SoldTicketsAmount.HeaderText = "Кол-во проданных билетов";
            this.SoldTicketsAmount.MinimumWidth = 150;
            this.SoldTicketsAmount.Name = "SoldTicketsAmount";
            this.SoldTicketsAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoldTicketsAmount.Width = 200;
            // 
            // SimulationPage
            // 
            this.SimulationPage.BackColor = System.Drawing.Color.White;
            this.SimulationPage.Controls.Add(this.groupBox2);
            this.SimulationPage.Controls.Add(this.backToScheduleButton);
            this.SimulationPage.Location = new System.Drawing.Point(4, 24);
            this.SimulationPage.Name = "SimulationPage";
            this.SimulationPage.Size = new System.Drawing.Size(1255, 660);
            this.SimulationPage.TabIndex = 2;
            this.SimulationPage.Text = "Моделирование";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(197, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 564);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Моделирование";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.34021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.65979F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 430);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 49);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 68);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(15, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "СТАРТ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(515, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "1,0X";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(88, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(422, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(773, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 25);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // backToScheduleButton
            // 
            this.backToScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.backToScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToScheduleButton.FlatAppearance.BorderSize = 0;
            this.backToScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToScheduleButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backToScheduleButton.Location = new System.Drawing.Point(35, 613);
            this.backToScheduleButton.Name = "backToScheduleButton";
            this.backToScheduleButton.Size = new System.Drawing.Size(134, 32);
            this.backToScheduleButton.TabIndex = 4;
            this.backToScheduleButton.Text = "Назад";
            this.backToScheduleButton.UseVisualStyleBackColor = false;
            this.backToScheduleButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASS 1.0 - Airport Simulation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.TopologyPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SchedulePage.ResumeLayout(false);
            this.SchedulePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SimulationPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToTopologyButton;
        private System.Windows.Forms.Button LoadTopologyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage SchedulePage;
        private System.Windows.Forms.TabPage SimulationPage;
        public System.Windows.Forms.TabPage TopologyPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backToMainPageButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goToScheduleButton;
        private System.Windows.Forms.Button backToTopologyPage;
        private System.Windows.Forms.Button goToSimulationPagebutton;
        private System.Windows.Forms.Button backToScheduleButton;
        private System.Windows.Forms.Label topologyName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDeskNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn City;
        private System.Windows.Forms.DataGridViewComboBoxColumn Airplane;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldTicketsAmount;
    }
}