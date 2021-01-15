using AirportSimulationSystem.Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace AirportSimulationSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTopologyButton = new System.Windows.Forms.Button();
            this.LoadTopologyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.saveTopology = new System.Windows.Forms.Button();
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
            this.PassengerTerminalTittle = new System.Windows.Forms.TextBox();
            this.CargoTerminalTittle = new System.Windows.Forms.TextBox();
            this.HangarTittle = new System.Windows.Forms.TextBox();
            this.GarageTittle = new System.Windows.Forms.TextBox();
            this.AirportBuildingTittle = new System.Windows.Forms.TextBox();
            this.RunwayTittle = new System.Windows.Forms.TextBox();
            this.passengerTerminal = new System.Windows.Forms.PictureBox();
            this.cargoTerminal = new System.Windows.Forms.PictureBox();
            this.vpp = new System.Windows.Forms.PictureBox();
            this.hangar = new System.Windows.Forms.PictureBox();
            this.garage = new System.Windows.Forms.PictureBox();
            this.airport = new System.Windows.Forms.PictureBox();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.citiesGridView = new System.Windows.Forms.DataGridView();
            this.citiesButton = new System.Windows.Forms.Button();
            this.airplanesButton = new System.Windows.Forms.Button();
            this.fligthsButton = new System.Windows.Forms.Button();
            this.goToSimulationPagebutton = new System.Windows.Forms.Button();
            this.backToTopologyPage = new System.Windows.Forms.Button();
            this.airplanesGridView = new System.Windows.Forms.DataGridView();
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchComboBox = new AirportSimulationSystem.Helpers.FlatComboWithBorder();
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
            this.MainTabControl.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
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
            // CreateTopologyButton
            // 
            this.CreateTopologyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CreateTopologyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTopologyButton.FlatAppearance.BorderSize = 0;
            this.CreateTopologyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTopologyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTopologyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateTopologyButton.Location = new System.Drawing.Point(365, 462);
            this.CreateTopologyButton.Name = "CreateTopologyButton";
            this.CreateTopologyButton.Size = new System.Drawing.Size(244, 32);
            this.CreateTopologyButton.TabIndex = 1;
            this.CreateTopologyButton.Text = "Создать";
            this.CreateTopologyButton.UseVisualStyleBackColor = false;
            this.CreateTopologyButton.Click += new System.EventHandler(this.CreateTopologyButton_click);
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
            // MainTabControl
            // 
            this.MainTabControl.AllowDrop = true;
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.TopologyPage);
            this.MainTabControl.Controls.Add(this.SchedulePage);
            this.MainTabControl.Controls.Add(this.SimulationPage);
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTabControl.ItemSize = new System.Drawing.Size(90, 20);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1267, 688);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.White;
            this.MainPage.Controls.Add(this.LoadTopologyButton);
            this.MainPage.Controls.Add(this.pictureBox1);
            this.MainPage.Controls.Add(this.CreateTopologyButton);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainPage.Location = new System.Drawing.Point(4, 24);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1259, 660);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            // 
            // TopologyPage
            // 
            this.TopologyPage.BackColor = System.Drawing.Color.White;
            this.TopologyPage.Controls.Add(this.saveTopology);
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
            this.TopologyPage.Size = new System.Drawing.Size(1259, 660);
            this.TopologyPage.TabIndex = 3;
            this.TopologyPage.Text = "Топология";
            // 
            // saveTopology
            // 
            this.saveTopology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.saveTopology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTopology.FlatAppearance.BorderSize = 0;
            this.saveTopology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTopology.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveTopology.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveTopology.Location = new System.Drawing.Point(497, 613);
            this.saveTopology.Name = "saveTopology";
            this.saveTopology.Size = new System.Drawing.Size(134, 32);
            this.saveTopology.TabIndex = 13;
            this.saveTopology.Text = "Сохранить";
            this.saveTopology.UseVisualStyleBackColor = false;
            this.saveTopology.Click += new System.EventHandler(this.saveTopology_Click);
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
            this.verGridOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.horGridOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 657);
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
            this.groupBox1.Controls.Add(this.PassengerTerminalTittle);
            this.groupBox1.Controls.Add(this.CargoTerminalTittle);
            this.groupBox1.Controls.Add(this.HangarTittle);
            this.groupBox1.Controls.Add(this.GarageTittle);
            this.groupBox1.Controls.Add(this.AirportBuildingTittle);
            this.groupBox1.Controls.Add(this.RunwayTittle);
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
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
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
            // PassengerTerminalTittle
            // 
            this.PassengerTerminalTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PassengerTerminalTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassengerTerminalTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassengerTerminalTittle.Location = new System.Drawing.Point(166, 431);
            this.PassengerTerminalTittle.Name = "PassengerTerminalTittle";
            this.PassengerTerminalTittle.ReadOnly = true;
            this.PassengerTerminalTittle.Size = new System.Drawing.Size(222, 26);
            this.PassengerTerminalTittle.TabIndex = 17;
            this.PassengerTerminalTittle.Text = "Пассажирский терминал";
            // 
            // CargoTerminalTittle
            // 
            this.CargoTerminalTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CargoTerminalTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CargoTerminalTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CargoTerminalTittle.Location = new System.Drawing.Point(166, 368);
            this.CargoTerminalTittle.Name = "CargoTerminalTittle";
            this.CargoTerminalTittle.ReadOnly = true;
            this.CargoTerminalTittle.Size = new System.Drawing.Size(177, 26);
            this.CargoTerminalTittle.TabIndex = 16;
            this.CargoTerminalTittle.Text = "Грузовой терминал";
            // 
            // HangarTittle
            // 
            this.HangarTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HangarTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HangarTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HangarTittle.Location = new System.Drawing.Point(166, 306);
            this.HangarTittle.Name = "HangarTittle";
            this.HangarTittle.ReadOnly = true;
            this.HangarTittle.Size = new System.Drawing.Size(69, 26);
            this.HangarTittle.TabIndex = 15;
            this.HangarTittle.Text = "Ангар";
            // 
            // GarageTittle
            // 
            this.GarageTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GarageTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GarageTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GarageTittle.Location = new System.Drawing.Point(166, 239);
            this.GarageTittle.Name = "GarageTittle";
            this.GarageTittle.ReadOnly = true;
            this.GarageTittle.Size = new System.Drawing.Size(69, 26);
            this.GarageTittle.TabIndex = 14;
            this.GarageTittle.Text = "Гараж";
            // 
            // AirportBuildingTittle
            // 
            this.AirportBuildingTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AirportBuildingTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AirportBuildingTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AirportBuildingTittle.Location = new System.Drawing.Point(241, 153);
            this.AirportBuildingTittle.Name = "AirportBuildingTittle";
            this.AirportBuildingTittle.ReadOnly = true;
            this.AirportBuildingTittle.Size = new System.Drawing.Size(121, 26);
            this.AirportBuildingTittle.TabIndex = 13;
            this.AirportBuildingTittle.Text = "Аэровокзал";
            // 
            // RunwayTittle
            // 
            this.RunwayTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RunwayTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunwayTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RunwayTittle.Location = new System.Drawing.Point(241, 54);
            this.RunwayTittle.Name = "RunwayTittle";
            this.RunwayTittle.ReadOnly = true;
            this.RunwayTittle.Size = new System.Drawing.Size(48, 26);
            this.RunwayTittle.TabIndex = 12;
            this.RunwayTittle.Text = "ВПП";
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
            this.SchedulePage.Controls.Add(this.DeleteItemButton);
            this.SchedulePage.Controls.Add(this.AddItemButton);
            this.SchedulePage.Controls.Add(this.citiesGridView);
            this.SchedulePage.Controls.Add(this.citiesButton);
            this.SchedulePage.Controls.Add(this.airplanesButton);
            this.SchedulePage.Controls.Add(this.fligthsButton);
            this.SchedulePage.Controls.Add(this.goToSimulationPagebutton);
            this.SchedulePage.Controls.Add(this.backToTopologyPage);
            this.SchedulePage.Controls.Add(this.airplanesGridView);
            this.SchedulePage.Controls.Add(this.flightsGridView);
            this.SchedulePage.Controls.Add(this.SearchTextBox);
            this.SchedulePage.Controls.Add(this.SearchComboBox);
            this.SchedulePage.Location = new System.Drawing.Point(4, 24);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulePage.Size = new System.Drawing.Size(1259, 660);
            this.SchedulePage.TabIndex = 1;
            this.SchedulePage.Text = "Расписание";
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DeleteItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemButton.FlatAppearance.BorderSize = 0;
            this.DeleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteItemButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteItemButton.Location = new System.Drawing.Point(704, 537);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(134, 32);
            this.DeleteItemButton.TabIndex = 12;
            this.DeleteItemButton.Text = "Х Удалить";
            this.DeleteItemButton.UseVisualStyleBackColor = false;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AddItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemButton.FlatAppearance.BorderSize = 0;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddItemButton.Location = new System.Drawing.Point(479, 537);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(134, 32);
            this.AddItemButton.TabIndex = 11;
            this.AddItemButton.Text = "+ Добавить";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // citiesGridView
            // 
            this.citiesGridView.AllowUserToOrderColumns = true;
            this.citiesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.citiesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.citiesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citiesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.citiesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.citiesGridView.Location = new System.Drawing.Point(75, 64);
            this.citiesGridView.Name = "citiesGridView";
            this.citiesGridView.RowHeadersVisible = false;
            this.citiesGridView.RowTemplate.Height = 25;
            this.citiesGridView.Size = new System.Drawing.Size(1102, 430);
            this.citiesGridView.TabIndex = 10;
            this.citiesGridView.Visible = false;
            this.citiesGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.citiesGridView_KeyUp);
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
            // airplanesGridView
            // 
            this.airplanesGridView.AllowUserToOrderColumns = true;
            this.airplanesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.airplanesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.airplanesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airplanesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airplanesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.airplanesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airplanesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.airplanesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.airplanesGridView.Location = new System.Drawing.Point(75, 64);
            this.airplanesGridView.Name = "airplanesGridView";
            this.airplanesGridView.RowHeadersVisible = false;
            this.airplanesGridView.RowTemplate.Height = 25;
            this.airplanesGridView.Size = new System.Drawing.Size(1102, 430);
            this.airplanesGridView.TabIndex = 10;
            this.airplanesGridView.Visible = false;
            // 
            // flightsGridView
            // 
            this.flightsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.flightsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.flightsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.flightsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.flightsGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.flightsGridView.Location = new System.Drawing.Point(75, 110);
            this.flightsGridView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowHeadersVisible = false;
            this.flightsGridView.RowTemplate.Height = 25;
            this.flightsGridView.Size = new System.Drawing.Size(1102, 384);
            this.flightsGridView.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchTextBox.Location = new System.Drawing.Point(207, 64);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "   Начните печатать для поиска";
            this.SearchTextBox.Size = new System.Drawing.Size(970, 25);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            " Город",
            " Самолёт",
            " Рейс"});
            this.SearchComboBox.Location = new System.Drawing.Point(75, 64);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(126, 25);
            this.SearchComboBox.TabIndex = 6;
            // 
            // SimulationPage
            // 
            this.SimulationPage.BackColor = System.Drawing.Color.White;
            this.SimulationPage.Controls.Add(this.groupBox2);
            this.SimulationPage.Controls.Add(this.backToScheduleButton);
            this.SimulationPage.Location = new System.Drawing.Point(4, 24);
            this.SimulationPage.Name = "SimulationPage";
            this.SimulationPage.Size = new System.Drawing.Size(1259, 660);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASS 1.0 - Airport Simulation System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainTabControl.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            this.SimulationPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button CreateTopologyButton;
        private Button LoadTopologyButton;
        private PictureBox pictureBox1;
        private TabControl MainTabControl;
        private TabPage MainPage;
        private TabPage SchedulePage;
        private TabPage SimulationPage;
        private DataGridView flightsGridView;
        private DataGridView airplanesGridView;
        private DataGridView citiesGridView;
        private Button backToTopologyPage;
        private Button goToSimulationPagebutton;
        private Button backToScheduleButton;
        private FlatComboWithBorder SearchComboBox;
        private TextBox SearchTextBox;
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
        private TextBox PassengerTerminalTittle;
        private TextBox CargoTerminalTittle;
        private TextBox HangarTittle;
        private TextBox GarageTittle;
        private TextBox AirportBuildingTittle;
        private TextBox RunwayTittle;
        private TextBox counterPassTerm;
        private TextBox counterCargoTerm;
        private TextBox counterHangar;
        private TextBox counterGarage;
        private TextBox counterAirport;
        private ExtendedPanel extendedPanel;
        private Button saveTopology;
        private Button DeleteItemButton;
        private Button AddItemButton;
    }
}