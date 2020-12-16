﻿using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.goToTopologyButton = new System.Windows.Forms.Button();
            this.LoadTopologyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.extendedPanel = new AirportSimulationSystem.ExtendedPanel();
            this.verGridOutput = new System.Windows.Forms.TextBox();
            this.minusVerBut = new System.Windows.Forms.Button();
            this.plusVerBut = new System.Windows.Forms.Button();
            this.horGridOutput = new System.Windows.Forms.TextBox();
            this.minusHorBut = new System.Windows.Forms.Button();
            this.plusHorBut = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.topologyName = new System.Windows.Forms.Label();
            this.goToScheduleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backToMainPageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.counterPassTerm = new System.Windows.Forms.TextBox();
            this.counterCargoTerm = new System.Windows.Forms.TextBox();
            this.counterHangar = new System.Windows.Forms.TextBox();
            this.counterGarage = new System.Windows.Forms.TextBox();
            this.counterAirport = new System.Windows.Forms.TextBox();
            this.counterVPP = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passengerTerminal = new System.Windows.Forms.PictureBox();
            this.cargoTerminal = new System.Windows.Forms.PictureBox();
            this.vpp = new System.Windows.Forms.PictureBox();
            this.hangar = new System.Windows.Forms.PictureBox();
            this.garage = new System.Windows.Forms.PictureBox();
            this.airport = new System.Windows.Forms.PictureBox();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.airplanesGridView = new System.Windows.Forms.DataGridView();
            this.AirplaneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirplaneModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiftingCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightRegistryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FlightAirplane = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FlightTicketsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citiesGridView = new System.Windows.Forms.DataGridView();
            this.CityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citiesButton = new System.Windows.Forms.Button();
            this.airplanesButton = new System.Windows.Forms.Button();
            this.fligthsButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goToSimulationPagebutton = new System.Windows.Forms.Button();
            this.backToTopologyPage = new System.Windows.Forms.Button();
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
            this.plusHorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.TopologyPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport)).BeginInit();
            this.SchedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).BeginInit();
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
            this.tabControl1.AllowDrop = true;
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
            this.TopologyPage.Controls.Add(this.extendedPanel);
            this.TopologyPage.Controls.Add(this.verGridOutput);
            this.TopologyPage.Controls.Add(this.minusVerBut);
            this.TopologyPage.Controls.Add(this.plusVerBut);
            this.TopologyPage.Controls.Add(this.horGridOutput);
            this.TopologyPage.Controls.Add(this.minusHorBut);
            this.TopologyPage.Controls.Add(this.plusHorBut);
            this.TopologyPage.Controls.Add(this.grid);
            this.TopologyPage.Controls.Add(this.topologyName);
            this.TopologyPage.Controls.Add(this.goToScheduleButton);
            this.TopologyPage.Controls.Add(this.panel1);
            this.TopologyPage.Location = new System.Drawing.Point(4, 24);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Size = new System.Drawing.Size(1255, 660);
            this.TopologyPage.TabIndex = 3;
            this.TopologyPage.Text = "Топология";
            // 
            // extendedPanel
            // 
            this.extendedPanel.Location = new System.Drawing.Point(568, 70);
            this.extendedPanel.Name = "extendedPanel";
            this.extendedPanel.Size = new System.Drawing.Size(521, 521);
            this.extendedPanel.TabIndex = 12;
            this.extendedPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.extendedPanel_DragDrop);
            this.extendedPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.extendedPanel_DragEnter);
            // 
            // verGridOutput
            // 
            this.verGridOutput.BackColor = System.Drawing.Color.White;
            this.verGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verGridOutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verGridOutput.Location = new System.Drawing.Point(1141, 297);
            this.verGridOutput.Name = "verGridOutput";
            this.verGridOutput.ReadOnly = true;
            this.verGridOutput.Size = new System.Drawing.Size(47, 36);
            this.verGridOutput.TabIndex = 11;
            this.verGridOutput.Text = "10";
            // 
            // minusVerBut
            // 
            this.minusVerBut.FlatAppearance.BorderSize = 0;
            this.minusVerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusVerBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusVerBut.Location = new System.Drawing.Point(1135, 347);
            this.minusVerBut.Name = "minusVerBut";
            this.minusVerBut.Size = new System.Drawing.Size(53, 48);
            this.minusVerBut.TabIndex = 10;
            this.minusVerBut.Text = "-";
            this.minusVerBut.UseVisualStyleBackColor = true;
            this.minusVerBut.Click += new System.EventHandler(this.minusVerBut_Click);
            // 
            // plusVerBut
            // 
            this.plusVerBut.FlatAppearance.BorderSize = 0;
            this.plusVerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusVerBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusVerBut.Location = new System.Drawing.Point(1135, 234);
            this.plusVerBut.Name = "plusVerBut";
            this.plusVerBut.Size = new System.Drawing.Size(53, 48);
            this.plusVerBut.TabIndex = 9;
            this.plusVerBut.Text = "+";
            this.plusVerBut.UseVisualStyleBackColor = true;
            this.plusVerBut.Click += new System.EventHandler(this.plusVerBut_Click);
            // 
            // horGridOutput
            // 
            this.horGridOutput.BackColor = System.Drawing.Color.White;
            this.horGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.horGridOutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horGridOutput.Location = new System.Drawing.Point(841, 605);
            this.horGridOutput.Name = "horGridOutput";
            this.horGridOutput.ReadOnly = true;
            this.horGridOutput.Size = new System.Drawing.Size(35, 36);
            this.horGridOutput.TabIndex = 8;
            this.horGridOutput.Text = "10";
            // 
            // minusHorBut
            // 
            this.minusHorBut.FlatAppearance.BorderSize = 0;
            this.minusHorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusHorBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusHorBut.Location = new System.Drawing.Point(782, 598);
            this.minusHorBut.Name = "minusHorBut";
            this.minusHorBut.Size = new System.Drawing.Size(53, 48);
            this.minusHorBut.TabIndex = 7;
            this.minusHorBut.Text = "-";
            this.minusHorBut.UseVisualStyleBackColor = true;
            this.minusHorBut.Click += new System.EventHandler(this.minusHorBut_Click);
            // 
            // plusHorBut
            // 
            this.plusHorBut.FlatAppearance.BorderSize = 0;
            this.plusHorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusHorBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusHorBut.Location = new System.Drawing.Point(882, 598);
            this.plusHorBut.Name = "plusHorBut";
            this.plusHorBut.Size = new System.Drawing.Size(53, 48);
            this.plusHorBut.TabIndex = 6;
            this.plusHorBut.Text = "+";
            this.plusHorBut.UseVisualStyleBackColor = true;
            this.plusHorBut.Click += new System.EventHandler(this.plusHorButton_Click);
            // 
            // grid
            // 
            this.grid.AllowDrop = true;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSize = true;
            this.grid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.grid.ColumnCount = 10;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.grid.Location = new System.Drawing.Point(568, 70);
            this.grid.Name = "grid";
            this.grid.RowCount = 10;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.Size = new System.Drawing.Size(521, 521);
            this.grid.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.counterPassTerm);
            this.groupBox1.Controls.Add(this.counterCargoTerm);
            this.groupBox1.Controls.Add(this.counterHangar);
            this.groupBox1.Controls.Add(this.counterGarage);
            this.groupBox1.Controls.Add(this.counterAirport);
            this.groupBox1.Controls.Add(this.counterVPP);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.passengerTerminal);
            this.groupBox1.Controls.Add(this.cargoTerminal);
            this.groupBox1.Controls.Add(this.vpp);
            this.groupBox1.Controls.Add(this.hangar);
            this.groupBox1.Controls.Add(this.garage);
            this.groupBox1.Controls.Add(this.airport);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы топологии";
            // 
            // counterPassTerm
            // 
            this.counterPassTerm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterPassTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterPassTerm.Location = new System.Drawing.Point(21, 431);
            this.counterPassTerm.Name = "counterPassTerm";
            this.counterPassTerm.ReadOnly = true;
            this.counterPassTerm.Size = new System.Drawing.Size(48, 26);
            this.counterPassTerm.TabIndex = 23;
            this.counterPassTerm.Text = "x1";
            // 
            // counterCargoTerm
            // 
            this.counterCargoTerm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterCargoTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterCargoTerm.Location = new System.Drawing.Point(21, 368);
            this.counterCargoTerm.Name = "counterCargoTerm";
            this.counterCargoTerm.ReadOnly = true;
            this.counterCargoTerm.Size = new System.Drawing.Size(48, 26);
            this.counterCargoTerm.TabIndex = 22;
            this.counterCargoTerm.Text = "x1";
            // 
            // counterHangar
            // 
            this.counterHangar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterHangar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterHangar.Location = new System.Drawing.Point(21, 306);
            this.counterHangar.Name = "counterHangar";
            this.counterHangar.ReadOnly = true;
            this.counterHangar.Size = new System.Drawing.Size(48, 26);
            this.counterHangar.TabIndex = 21;
            this.counterHangar.Text = "x5";
            // 
            // counterGarage
            // 
            this.counterGarage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterGarage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterGarage.Location = new System.Drawing.Point(21, 239);
            this.counterGarage.Name = "counterGarage";
            this.counterGarage.ReadOnly = true;
            this.counterGarage.Size = new System.Drawing.Size(48, 26);
            this.counterGarage.TabIndex = 20;
            this.counterGarage.Text = "x5";
            // 
            // counterAirport
            // 
            this.counterAirport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterAirport.Location = new System.Drawing.Point(21, 153);
            this.counterAirport.Name = "counterAirport";
            this.counterAirport.ReadOnly = true;
            this.counterAirport.Size = new System.Drawing.Size(48, 26);
            this.counterAirport.TabIndex = 19;
            this.counterAirport.Text = "x1";
            // 
            // counterVPP
            // 
            this.counterVPP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterVPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterVPP.Location = new System.Drawing.Point(21, 54);
            this.counterVPP.Name = "counterVPP";
            this.counterVPP.ReadOnly = true;
            this.counterVPP.Size = new System.Drawing.Size(48, 26);
            this.counterVPP.TabIndex = 18;
            this.counterVPP.Text = "x1";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(166, 431);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(222, 26);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Пассажирский терминал";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(166, 368);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(177, 26);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Грузовой терминал";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(166, 306);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(69, 26);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Ангар";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(166, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(69, 26);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Гараж";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(241, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Аэровокзал";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(241, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(48, 26);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "ВПП";
            // 
            // passengerTerminal
            // 
            this.passengerTerminal.Image = ((System.Drawing.Image)(resources.GetObject("passengerTerminal.Image")));
            this.passengerTerminal.Location = new System.Drawing.Point(75, 416);
            this.passengerTerminal.Name = "passengerTerminal";
            this.passengerTerminal.Size = new System.Drawing.Size(85, 55);
            this.passengerTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passengerTerminal.TabIndex = 11;
            this.passengerTerminal.TabStop = false;
            this.passengerTerminal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passengerTerminal_MouseDown);
            // 
            // cargoTerminal
            // 
            this.cargoTerminal.Image = ((System.Drawing.Image)(resources.GetObject("cargoTerminal.Image")));
            this.cargoTerminal.Location = new System.Drawing.Point(75, 355);
            this.cargoTerminal.Name = "cargoTerminal";
            this.cargoTerminal.Size = new System.Drawing.Size(85, 55);
            this.cargoTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cargoTerminal.TabIndex = 10;
            this.cargoTerminal.TabStop = false;
            this.cargoTerminal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cargoTerminal_MouseDown);
            // 
            // vpp
            // 
            this.vpp.Image = ((System.Drawing.Image)(resources.GetObject("vpp.Image")));
            this.vpp.Location = new System.Drawing.Point(75, 32);
            this.vpp.Name = "vpp";
            this.vpp.Size = new System.Drawing.Size(160, 77);
            this.vpp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vpp.TabIndex = 9;
            this.vpp.TabStop = false;
            this.vpp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vpp_MouseDown);
            // 
            // hangar
            // 
            this.hangar.Image = ((System.Drawing.Image)(resources.GetObject("hangar.Image")));
            this.hangar.Location = new System.Drawing.Point(75, 288);
            this.hangar.Name = "hangar";
            this.hangar.Size = new System.Drawing.Size(85, 61);
            this.hangar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangar.TabIndex = 8;
            this.hangar.TabStop = false;
            this.hangar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hangar_MouseDown);
            // 
            // garage
            // 
            this.garage.Image = ((System.Drawing.Image)(resources.GetObject("garage.Image")));
            this.garage.Location = new System.Drawing.Point(75, 221);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(85, 61);
            this.garage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.garage.TabIndex = 7;
            this.garage.TabStop = false;
            this.garage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.garage_MouseDown);
            // 
            // airport
            // 
            this.airport.Image = ((System.Drawing.Image)(resources.GetObject("airport.Image")));
            this.airport.Location = new System.Drawing.Point(75, 115);
            this.airport.Name = "airport";
            this.airport.Size = new System.Drawing.Size(160, 100);
            this.airport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.airport.TabIndex = 6;
            this.airport.TabStop = false;
            this.airport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.airport_MouseDown);
            // 
            // SchedulePage
            // 
            this.SchedulePage.BackColor = System.Drawing.Color.White;
            this.SchedulePage.Controls.Add(this.airplanesGridView);
            this.SchedulePage.Controls.Add(this.flightsGridView);
            this.SchedulePage.Controls.Add(this.citiesGridView);
            this.SchedulePage.Controls.Add(this.citiesButton);
            this.SchedulePage.Controls.Add(this.airplanesButton);
            this.SchedulePage.Controls.Add(this.fligthsButton);
            this.SchedulePage.Controls.Add(this.comboBox1);
            this.SchedulePage.Controls.Add(this.textBox1);
            this.SchedulePage.Controls.Add(this.goToSimulationPagebutton);
            this.SchedulePage.Controls.Add(this.backToTopologyPage);
            this.SchedulePage.Location = new System.Drawing.Point(4, 24);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulePage.Size = new System.Drawing.Size(1255, 660);
            this.SchedulePage.TabIndex = 1;
            this.SchedulePage.Text = "Расписание";
            // 
            // airplanesGridView
            // 
            this.airplanesGridView.AllowUserToOrderColumns = true;
            this.airplanesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.airplanesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airplanesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.airplanesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.airplanesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplanesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AirplaneNumber,
            this.AirplaneModel,
            this.FlightRange,
            this.PassengerCapacity,
            this.LiftingCapacity});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airplanesGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.airplanesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.airplanesGridView.Location = new System.Drawing.Point(75, 110);
            this.airplanesGridView.Name = "airplanesGridView";
            this.airplanesGridView.RowTemplate.Height = 25;
            this.airplanesGridView.Size = new System.Drawing.Size(1102, 459);
            this.airplanesGridView.TabIndex = 10;
            this.airplanesGridView.Visible = false;
            // 
            // AirplaneNumber
            // 
            this.AirplaneNumber.HeaderText = "№ Самолёта";
            this.AirplaneNumber.MinimumWidth = 20;
            this.AirplaneNumber.Name = "AirplaneNumber";
            this.AirplaneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AirplaneNumber.Width = 120;
            // 
            // AirplaneModel
            // 
            this.AirplaneModel.HeaderText = "Модель";
            this.AirplaneModel.Name = "AirplaneModel";
            this.AirplaneModel.Width = 120;
            // 
            // FlightRange
            // 
            this.FlightRange.HeaderText = "Дальность полёта";
            this.FlightRange.MinimumWidth = 100;
            this.FlightRange.Name = "FlightRange";
            this.FlightRange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightRange.Width = 180;
            // 
            // PassengerCapacity
            // 
            this.PassengerCapacity.HeaderText = "Пассажировместимость";
            this.PassengerCapacity.MinimumWidth = 20;
            this.PassengerCapacity.Name = "PassengerCapacity";
            this.PassengerCapacity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PassengerCapacity.Width = 180;
            // 
            // LiftingCapacity
            // 
            this.LiftingCapacity.HeaderText = "Грузоподъёмность";
            this.LiftingCapacity.MinimumWidth = 100;
            this.LiftingCapacity.Name = "LiftingCapacity";
            this.LiftingCapacity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LiftingCapacity.Width = 170;
            // 
            // flightsGridView
            // 
            this.flightsGridView.AllowUserToOrderColumns = true;
            this.flightsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.flightsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNumber,
            this.FlightTitle,
            this.FlightTime,
            this.FlightRegistryNumber,
            this.FlightCity,
            this.FlightAirplane,
            this.FlightTicketsAmount});
            this.flightsGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.flightsGridView.Location = new System.Drawing.Point(75, 110);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowTemplate.Height = 25;
            this.flightsGridView.Size = new System.Drawing.Size(1102, 459);
            this.flightsGridView.TabIndex = 0;
            // 
            // FlightNumber
            // 
            this.FlightNumber.HeaderText = "№ Рейса";
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Width = 90;
            // 
            // FlightTitle
            // 
            this.FlightTitle.HeaderText = "Рейс";
            this.FlightTitle.Name = "FlightTitle";
            // 
            // FlightTime
            // 
            this.FlightTime.HeaderText = "Время";
            this.FlightTime.Name = "FlightTime";
            // 
            // FlightRegistryNumber
            // 
            this.FlightRegistryNumber.HeaderText = "№ Стойки регистрации";
            this.FlightRegistryNumber.Name = "FlightRegistryNumber";
            this.FlightRegistryNumber.Width = 180;
            // 
            // FlightCity
            // 
            this.FlightCity.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.FlightCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightCity.HeaderText = "Город";
            this.FlightCity.Items.AddRange(new object[] {
            "Москва",
            "Санкт-Петербург",
            "Лондон"});
            this.FlightCity.Name = "FlightCity";
            this.FlightCity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FlightCity.Width = 150;
            // 
            // FlightAirplane
            // 
            this.FlightAirplane.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.FlightAirplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightAirplane.HeaderText = "Самолёт";
            this.FlightAirplane.Items.AddRange(new object[] {
            "Airbus A320",
            "Airbus A330",
            "Boeining 707",
            "Boening 520"});
            this.FlightAirplane.Name = "FlightAirplane";
            this.FlightAirplane.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightAirplane.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FlightAirplane.Width = 150;
            // 
            // FlightTicketsAmount
            // 
            this.FlightTicketsAmount.HeaderText = "Кол-во проданных билетов";
            this.FlightTicketsAmount.Name = "FlightTicketsAmount";
            this.FlightTicketsAmount.Width = 200;
            // 
            // citiesGridView
            // 
            this.citiesGridView.AllowUserToOrderColumns = true;
            this.citiesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.citiesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citiesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.citiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityNumber,
            this.CityName,
            this.Distance});
            this.citiesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.citiesGridView.Location = new System.Drawing.Point(75, 110);
            this.citiesGridView.Name = "citiesGridView";
            this.citiesGridView.RowTemplate.Height = 25;
            this.citiesGridView.Size = new System.Drawing.Size(1102, 459);
            this.citiesGridView.TabIndex = 10;
            this.citiesGridView.Visible = false;
            // 
            // CityNumber
            // 
            this.CityNumber.HeaderText = "№ Города";
            this.CityNumber.Name = "CityNumber";
            // 
            // CityName
            // 
            this.CityName.HeaderText = "Название";
            this.CityName.Name = "CityName";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Расстояние до города";
            this.Distance.Name = "Distance";
            this.Distance.Width = 200;
            // 
            // citiesButton
            // 
            this.citiesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.citiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citiesButton.FlatAppearance.BorderSize = 0;
            this.citiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citiesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citiesButton.Location = new System.Drawing.Point(355, 15);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(134, 32);
            this.citiesButton.TabIndex = 9;
            this.citiesButton.Text = "Города";
            this.citiesButton.UseVisualStyleBackColor = false;
            this.citiesButton.Click += new System.EventHandler(this.citiesButton_Click);
            // 
            // airplanesButton
            // 
            this.airplanesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.airplanesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airplanesButton.FlatAppearance.BorderSize = 0;
            this.airplanesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airplanesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplanesButton.Location = new System.Drawing.Point(215, 15);
            this.airplanesButton.Name = "airplanesButton";
            this.airplanesButton.Size = new System.Drawing.Size(134, 32);
            this.airplanesButton.TabIndex = 8;
            this.airplanesButton.Text = "Самолёты";
            this.airplanesButton.UseVisualStyleBackColor = false;
            this.airplanesButton.Click += new System.EventHandler(this.airplanesButton_Click);
            // 
            // fligthsButton
            // 
            this.fligthsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.fligthsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fligthsButton.FlatAppearance.BorderSize = 0;
            this.fligthsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fligthsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fligthsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fligthsButton.Location = new System.Drawing.Point(75, 15);
            this.fligthsButton.Name = "fligthsButton";
            this.fligthsButton.Size = new System.Drawing.Size(134, 32);
            this.fligthsButton.TabIndex = 7;
            this.fligthsButton.Text = "Рейсы";
            this.fligthsButton.UseVisualStyleBackColor = false;
            this.fligthsButton.Click += new System.EventHandler(this.fligthsButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  Название",
            "  Рейс",
            "  Модель"});
            this.comboBox1.Location = new System.Drawing.Point(75, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 25);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "   Рейс";
            this.comboBox1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(207, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "   Начните печатать для поиска";
            this.textBox1.Size = new System.Drawing.Size(970, 25);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
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
            // plusHorButton
            // 
            this.plusHorButton.FlatAppearance.BorderSize = 0;
            this.plusHorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusHorButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusHorButton.Location = new System.Drawing.Point(792, 597);
            this.plusHorButton.Name = "plusHorButton";
            this.plusHorButton.Size = new System.Drawing.Size(53, 48);
            this.plusHorButton.TabIndex = 6;
            this.plusHorButton.Text = "+";
            this.plusHorButton.UseVisualStyleBackColor = true;
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
            this.TopologyPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport)).EndInit();
            this.SchedulePage.ResumeLayout(false);
            this.SchedulePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).EndInit();
            this.SimulationPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button goToTopologyButton;
        private Button LoadTopologyButton;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage MainPage;
        private TabPage SchedulePage;
        private TabPage SimulationPage;
        private DataGridView flightsGridView;
        private DataGridView airplanesGridView;
        private DataGridView citiesGridView;
        private Button backToTopologyPage;
        private Button goToSimulationPagebutton;
        private Button backToScheduleButton;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private TrackBar trackBar1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button citiesButton;
        private Button airplanesButton;
        private Button fligthsButton;
        private DataGridViewTextBoxColumn AirplaneNumber;
        private DataGridViewTextBoxColumn AirplaneModel;
        private DataGridViewTextBoxColumn FlightRange;
        private DataGridViewTextBoxColumn PassengerCapacity;
        private DataGridViewTextBoxColumn LiftingCapacity;
        private DataGridViewTextBoxColumn CityNumber;
        private DataGridViewTextBoxColumn CityName;
        private DataGridViewTextBoxColumn Distance;
        private DataGridViewTextBoxColumn FlightNumber;
        private DataGridViewTextBoxColumn FlightTitle;
        private DataGridViewTextBoxColumn FlightTime;
        private DataGridViewTextBoxColumn FlightRegistryNumber;
        private DataGridViewComboBoxColumn FlightCity;
        private DataGridViewComboBoxColumn FlightAirplane;
        private DataGridViewTextBoxColumn FlightTicketsAmount;
        public TabPage TopologyPage;
        private TextBox verGridOutput;
        private Button minusVerBut;
        private Button plusVerBut;
        private TextBox horGridOutput;
        private Button minusHorBut;
        private Button plusHorBut;
        private TableLayoutPanel grid;
        private Label topologyName;
        private Button goToScheduleButton;
        private Panel panel1;
        private Button backToMainPageButton;
        private Label label2;
        private GroupBox groupBox1;
        private Button plusHorButton;
        private PictureBox passengerTerminal;
        private PictureBox cargoTerminal;
        private PictureBox vpp;
        private PictureBox hangar;
        private PictureBox garage;
        private PictureBox airport;
        private TextBox counterVPP;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox counterPassTerm;
        private TextBox counterCargoTerm;
        private TextBox counterHangar;
        private TextBox counterGarage;
        private TextBox counterAirport;
        private ExtendedPanel extendedPanel;
    }
}