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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTopologyButton = new System.Windows.Forms.Button();
            this.LoadTopologyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.extendedPanel = new AirportSimulationSystem.ExtendedPanel();
            this.saveTopology = new System.Windows.Forms.Button();
            this.verGridOutput = new System.Windows.Forms.TextBox();
            this.minusVerBut = new System.Windows.Forms.Button();
            this.plusVerBut = new System.Windows.Forms.Button();
            this.horGridOutput = new System.Windows.Forms.TextBox();
            this.minusHorBut = new System.Windows.Forms.Button();
            this.plusHorBut = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.topologyName = new System.Windows.Forms.TextBox();
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
            this.extendedModellingPanel = new AirportSimulationSystem.ExtendedPanel();
            this.modellingGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.modellingTime = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ModellingScheduleLabel = new System.Windows.Forms.Label();
            this.modellingGridView = new System.Windows.Forms.DataGridView();
            this.backToScheduleButton = new System.Windows.Forms.Button();
            this.plusHorButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modellingGridView)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(417, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 81);
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
            this.CreateTopologyButton.Location = new System.Drawing.Point(417, 616);
            this.CreateTopologyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateTopologyButton.Name = "CreateTopologyButton";
            this.CreateTopologyButton.Size = new System.Drawing.Size(279, 43);
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
            this.LoadTopologyButton.Location = new System.Drawing.Point(703, 616);
            this.LoadTopologyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadTopologyButton.Name = "LoadTopologyButton";
            this.LoadTopologyButton.Size = new System.Drawing.Size(279, 43);
            this.LoadTopologyButton.TabIndex = 2;
            this.LoadTopologyButton.Text = "Загрузить";
            this.LoadTopologyButton.UseVisualStyleBackColor = false;
            this.LoadTopologyButton.Click += new System.EventHandler(this.LoadTopologyButton_Click);
            //
            // pictureBox1
            //
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 199);
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
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1448, 917);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            this.MainTabControl.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainPage_HelpRequested);
            //
            // MainPage
            //
            this.MainPage.BackColor = System.Drawing.Color.White;
            this.MainPage.Controls.Add(this.LoadTopologyButton);
            this.MainPage.Controls.Add(this.pictureBox1);
            this.MainPage.Controls.Add(this.CreateTopologyButton);
            this.MainPage.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this.MainPage, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MainPage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainPage.Location = new System.Drawing.Point(4, 24);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpProvider1.SetShowHelp(this.MainPage, true);
            this.MainPage.Size = new System.Drawing.Size(1440, 889);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            this.MainPage.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainPage_HelpRequested);
            //
            // TopologyPage
            //
            this.TopologyPage.BackColor = System.Drawing.Color.White;
            this.TopologyPage.Controls.Add(this.extendedPanel);
            this.TopologyPage.Controls.Add(this.saveTopology);
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
            this.TopologyPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Size = new System.Drawing.Size(1440, 889);
            this.TopologyPage.TabIndex = 3;
            this.TopologyPage.Text = "Топология";
            //
            // extendedPanel
            //
            this.extendedPanel.AllowDrop = true;
            this.extendedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extendedPanel.Location = new System.Drawing.Point(649, 93);
            this.extendedPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extendedPanel.Name = "extendedPanel";
            this.extendedPanel.Size = new System.Drawing.Size(595, 696);
            this.extendedPanel.TabIndex = 0;
            this.extendedPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.extendedPanel_DragDrop);
            this.extendedPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.extendedPanel_DragEnter);
            //
            // saveTopology
            //
            this.saveTopology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.saveTopology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTopology.FlatAppearance.BorderSize = 0;
            this.saveTopology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTopology.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveTopology.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveTopology.Location = new System.Drawing.Point(568, 817);
            this.saveTopology.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveTopology.Name = "saveTopology";
            this.saveTopology.Size = new System.Drawing.Size(153, 43);
            this.saveTopology.TabIndex = 13;
            this.saveTopology.Text = "Сохранить";
            this.saveTopology.UseVisualStyleBackColor = false;
            this.saveTopology.Click += new System.EventHandler(this.saveTopology_Click);
            //
            // verGridOutput
            //
            this.verGridOutput.BackColor = System.Drawing.Color.White;
            this.verGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verGridOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.verGridOutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verGridOutput.Location = new System.Drawing.Point(1304, 396);
            this.verGridOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verGridOutput.Name = "verGridOutput";
            this.verGridOutput.ReadOnly = true;
            this.verGridOutput.Size = new System.Drawing.Size(54, 45);
            this.verGridOutput.TabIndex = 11;
            this.verGridOutput.Text = "10";
            //
            // minusVerBut
            //
            this.minusVerBut.FlatAppearance.BorderSize = 0;
            this.minusVerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusVerBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusVerBut.Location = new System.Drawing.Point(1297, 463);
            this.minusVerBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minusVerBut.Name = "minusVerBut";
            this.minusVerBut.Size = new System.Drawing.Size(61, 64);
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
            this.plusVerBut.Location = new System.Drawing.Point(1297, 312);
            this.plusVerBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plusVerBut.Name = "plusVerBut";
            this.plusVerBut.Size = new System.Drawing.Size(61, 64);
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
            this.horGridOutput.Location = new System.Drawing.Point(961, 807);
            this.horGridOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horGridOutput.Name = "horGridOutput";
            this.horGridOutput.ReadOnly = true;
            this.horGridOutput.Size = new System.Drawing.Size(40, 45);
            this.horGridOutput.TabIndex = 8;
            this.horGridOutput.Text = "10";
            //
            // minusHorBut
            //
            this.minusHorBut.FlatAppearance.BorderSize = 0;
            this.minusHorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusHorBut.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusHorBut.Location = new System.Drawing.Point(894, 797);
            this.minusHorBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minusHorBut.Name = "minusHorBut";
            this.minusHorBut.Size = new System.Drawing.Size(61, 64);
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
            this.plusHorBut.Location = new System.Drawing.Point(1008, 797);
            this.plusHorBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plusHorBut.Name = "plusHorBut";
            this.plusHorBut.Size = new System.Drawing.Size(61, 64);
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
            this.grid.Location = new System.Drawing.Point(649, 93);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.grid.Size = new System.Drawing.Size(581, 681);
            this.grid.TabIndex = 5;
            //
            // topologyName
            //
            this.topologyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topologyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topologyName.Location = new System.Drawing.Point(514, 32);
            this.topologyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topologyName.Name = "topologyName";
            this.topologyName.Size = new System.Drawing.Size(912, 35);
            this.topologyName.TabIndex = 4;
            this.topologyName.Text = "Название топологии";
            this.topologyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // goToScheduleButton
            //
            this.goToScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.goToScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToScheduleButton.FlatAppearance.BorderSize = 0;
            this.goToScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goToScheduleButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.goToScheduleButton.Location = new System.Drawing.Point(1205, 817);
            this.goToScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goToScheduleButton.Name = "goToScheduleButton";
            this.goToScheduleButton.Size = new System.Drawing.Size(153, 43);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 876);
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
            this.backToMainPageButton.Location = new System.Drawing.Point(162, 817);
            this.backToMainPageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToMainPageButton.Name = "backToMainPageButton";
            this.backToMainPageButton.Size = new System.Drawing.Size(153, 43);
            this.backToMainPageButton.TabIndex = 2;
            this.backToMainPageButton.Text = "Назад";
            this.backToMainPageButton.UseVisualStyleBackColor = false;
            this.backToMainPageButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // label2
            //
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 75);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 640);
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
            this.counterPassTerm.Location = new System.Drawing.Point(24, 575);
            this.counterPassTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterPassTerm.Name = "counterPassTerm";
            this.counterPassTerm.ReadOnly = true;
            this.counterPassTerm.Size = new System.Drawing.Size(55, 32);
            this.counterPassTerm.TabIndex = 23;
            this.counterPassTerm.Text = "x1";
            //
            // counterCargoTerm
            //
            this.counterCargoTerm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterCargoTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterCargoTerm.Location = new System.Drawing.Point(24, 491);
            this.counterCargoTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterCargoTerm.Name = "counterCargoTerm";
            this.counterCargoTerm.ReadOnly = true;
            this.counterCargoTerm.Size = new System.Drawing.Size(55, 32);
            this.counterCargoTerm.TabIndex = 22;
            this.counterCargoTerm.Text = "x1";
            //
            // counterHangar
            //
            this.counterHangar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterHangar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterHangar.Location = new System.Drawing.Point(24, 408);
            this.counterHangar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterHangar.Name = "counterHangar";
            this.counterHangar.ReadOnly = true;
            this.counterHangar.Size = new System.Drawing.Size(55, 32);
            this.counterHangar.TabIndex = 21;
            this.counterHangar.Text = "x5";
            //
            // counterGarage
            //
            this.counterGarage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterGarage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterGarage.Location = new System.Drawing.Point(24, 319);
            this.counterGarage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterGarage.Name = "counterGarage";
            this.counterGarage.ReadOnly = true;
            this.counterGarage.Size = new System.Drawing.Size(55, 32);
            this.counterGarage.TabIndex = 20;
            this.counterGarage.Text = "x5";
            //
            // counterAirport
            //
            this.counterAirport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterAirport.Location = new System.Drawing.Point(24, 204);
            this.counterAirport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterAirport.Name = "counterAirport";
            this.counterAirport.ReadOnly = true;
            this.counterAirport.Size = new System.Drawing.Size(55, 32);
            this.counterAirport.TabIndex = 19;
            this.counterAirport.Text = "x1";
            //
            // counterVPP
            //
            this.counterVPP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.counterVPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counterVPP.Location = new System.Drawing.Point(24, 72);
            this.counterVPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.counterVPP.Name = "counterVPP";
            this.counterVPP.ReadOnly = true;
            this.counterVPP.Size = new System.Drawing.Size(55, 32);
            this.counterVPP.TabIndex = 18;
            this.counterVPP.Text = "x1";
            //
            // PassengerTerminalTittle
            //
            this.PassengerTerminalTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PassengerTerminalTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassengerTerminalTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassengerTerminalTittle.Location = new System.Drawing.Point(190, 575);
            this.PassengerTerminalTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassengerTerminalTittle.Name = "PassengerTerminalTittle";
            this.PassengerTerminalTittle.ReadOnly = true;
            this.PassengerTerminalTittle.Size = new System.Drawing.Size(254, 32);
            this.PassengerTerminalTittle.TabIndex = 17;
            this.PassengerTerminalTittle.Text = "Пассажирский терминал";
            //
            // CargoTerminalTittle
            //
            this.CargoTerminalTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CargoTerminalTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CargoTerminalTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CargoTerminalTittle.Location = new System.Drawing.Point(190, 491);
            this.CargoTerminalTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CargoTerminalTittle.Name = "CargoTerminalTittle";
            this.CargoTerminalTittle.ReadOnly = true;
            this.CargoTerminalTittle.Size = new System.Drawing.Size(202, 32);
            this.CargoTerminalTittle.TabIndex = 16;
            this.CargoTerminalTittle.Text = "Грузовой терминал";
            //
            // HangarTittle
            //
            this.HangarTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HangarTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HangarTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HangarTittle.Location = new System.Drawing.Point(190, 408);
            this.HangarTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HangarTittle.Name = "HangarTittle";
            this.HangarTittle.ReadOnly = true;
            this.HangarTittle.Size = new System.Drawing.Size(79, 32);
            this.HangarTittle.TabIndex = 15;
            this.HangarTittle.Text = "Ангар";
            //
            // GarageTittle
            //
            this.GarageTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GarageTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GarageTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GarageTittle.Location = new System.Drawing.Point(190, 319);
            this.GarageTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GarageTittle.Name = "GarageTittle";
            this.GarageTittle.ReadOnly = true;
            this.GarageTittle.Size = new System.Drawing.Size(79, 32);
            this.GarageTittle.TabIndex = 14;
            this.GarageTittle.Text = "Гараж";
            //
            // AirportBuildingTittle
            //
            this.AirportBuildingTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AirportBuildingTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AirportBuildingTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AirportBuildingTittle.Location = new System.Drawing.Point(275, 204);
            this.AirportBuildingTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AirportBuildingTittle.Name = "AirportBuildingTittle";
            this.AirportBuildingTittle.ReadOnly = true;
            this.AirportBuildingTittle.Size = new System.Drawing.Size(138, 32);
            this.AirportBuildingTittle.TabIndex = 13;
            this.AirportBuildingTittle.Text = "Аэровокзал";
            //
            // RunwayTittle
            //
            this.RunwayTittle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RunwayTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunwayTittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RunwayTittle.Location = new System.Drawing.Point(275, 72);
            this.RunwayTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RunwayTittle.Name = "RunwayTittle";
            this.RunwayTittle.ReadOnly = true;
            this.RunwayTittle.Size = new System.Drawing.Size(55, 32);
            this.RunwayTittle.TabIndex = 12;
            this.RunwayTittle.Text = "ВПП";
            //
            // passengerTerminal
            //
            this.passengerTerminal.Image = ((System.Drawing.Image)(resources.GetObject("passengerTerminal.Image")));
            this.passengerTerminal.Location = new System.Drawing.Point(86, 555);
            this.passengerTerminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passengerTerminal.Name = "passengerTerminal";
            this.passengerTerminal.Size = new System.Drawing.Size(97, 73);
            this.passengerTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passengerTerminal.TabIndex = 11;
            this.passengerTerminal.TabStop = false;
            this.passengerTerminal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passengerTerminal_MouseDown);
            //
            // cargoTerminal
            //
            this.cargoTerminal.Image = ((System.Drawing.Image)(resources.GetObject("cargoTerminal.Image")));
            this.cargoTerminal.Location = new System.Drawing.Point(86, 473);
            this.cargoTerminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cargoTerminal.Name = "cargoTerminal";
            this.cargoTerminal.Size = new System.Drawing.Size(97, 73);
            this.cargoTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cargoTerminal.TabIndex = 10;
            this.cargoTerminal.TabStop = false;
            this.cargoTerminal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cargoTerminal_MouseDown);
            //
            // vpp
            //
            this.vpp.Image = ((System.Drawing.Image)(resources.GetObject("vpp.Image")));
            this.vpp.Location = new System.Drawing.Point(86, 43);
            this.vpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vpp.Name = "vpp";
            this.vpp.Size = new System.Drawing.Size(183, 103);
            this.vpp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vpp.TabIndex = 9;
            this.vpp.TabStop = false;
            this.vpp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vpp_MouseDown);
            //
            // hangar
            //
            this.hangar.Image = ((System.Drawing.Image)(resources.GetObject("hangar.Image")));
            this.hangar.Location = new System.Drawing.Point(86, 384);
            this.hangar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hangar.Name = "hangar";
            this.hangar.Size = new System.Drawing.Size(97, 81);
            this.hangar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangar.TabIndex = 8;
            this.hangar.TabStop = false;
            this.hangar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hangar_MouseDown);
            //
            // garage
            //
            this.garage.Image = ((System.Drawing.Image)(resources.GetObject("garage.Image")));
            this.garage.Location = new System.Drawing.Point(86, 295);
            this.garage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(97, 81);
            this.garage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.garage.TabIndex = 7;
            this.garage.TabStop = false;
            this.garage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.garage_MouseDown);
            //
            // airport
            //
            this.airport.Image = ((System.Drawing.Image)(resources.GetObject("airport.Image")));
            this.airport.Location = new System.Drawing.Point(86, 153);
            this.airport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.airport.Name = "airport";
            this.airport.Size = new System.Drawing.Size(183, 133);
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
            this.SchedulePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SchedulePage.Size = new System.Drawing.Size(1440, 889);
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
            this.DeleteItemButton.Location = new System.Drawing.Point(805, 716);
            this.DeleteItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(153, 43);
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
            this.AddItemButton.Location = new System.Drawing.Point(547, 716);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(153, 43);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.citiesGridView.ColumnHeadersHeight = 29;
            this.citiesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.citiesGridView.Location = new System.Drawing.Point(86, 85);
            this.citiesGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.citiesGridView.Name = "citiesGridView";
            this.citiesGridView.RowHeadersVisible = false;
            this.citiesGridView.RowHeadersWidth = 51;
            this.citiesGridView.RowTemplate.Height = 25;
            this.citiesGridView.Size = new System.Drawing.Size(1259, 573);
            this.citiesGridView.TabIndex = 10;
            this.citiesGridView.Visible = false;
            this.citiesGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.citiesGridView_DataError);
            this.citiesGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.citiesGridView_KeyUp);
            //
            // citiesButton
            //
            this.citiesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.citiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citiesButton.FlatAppearance.BorderSize = 0;
            this.citiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citiesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citiesButton.Location = new System.Drawing.Point(406, 20);
            this.citiesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(153, 43);
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
            this.airplanesButton.Location = new System.Drawing.Point(246, 20);
            this.airplanesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.airplanesButton.Name = "airplanesButton";
            this.airplanesButton.Size = new System.Drawing.Size(153, 43);
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
            this.fligthsButton.Location = new System.Drawing.Point(86, 20);
            this.fligthsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fligthsButton.Name = "fligthsButton";
            this.fligthsButton.Size = new System.Drawing.Size(153, 43);
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
            this.goToSimulationPagebutton.Location = new System.Drawing.Point(1205, 817);
            this.goToSimulationPagebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goToSimulationPagebutton.Name = "goToSimulationPagebutton";
            this.goToSimulationPagebutton.Size = new System.Drawing.Size(153, 43);
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
            this.backToTopologyPage.Location = new System.Drawing.Point(162, 817);
            this.backToTopologyPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToTopologyPage.Name = "backToTopologyPage";
            this.backToTopologyPage.Size = new System.Drawing.Size(153, 43);
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airplanesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.airplanesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airplanesGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.airplanesGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.airplanesGridView.Location = new System.Drawing.Point(86, 85);
            this.airplanesGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.airplanesGridView.Name = "airplanesGridView";
            this.airplanesGridView.RowHeadersVisible = false;
            this.airplanesGridView.RowHeadersWidth = 51;
            this.airplanesGridView.RowTemplate.Height = 25;
            this.airplanesGridView.Size = new System.Drawing.Size(1259, 573);
            this.airplanesGridView.TabIndex = 10;
            this.airplanesGridView.Visible = false;
            this.airplanesGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.airplanesGridView_DataError);
            this.airplanesGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.airplanesGridView_KeyUp);
            //
            // flightsGridView
            //
            this.flightsGridView.AllowUserToOrderColumns = true;
            this.flightsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.flightsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.flightsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightsGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.flightsGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.flightsGridView.Location = new System.Drawing.Point(86, 147);
            this.flightsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 53);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowHeadersVisible = false;
            this.flightsGridView.RowHeadersWidth = 51;
            this.flightsGridView.RowTemplate.Height = 25;
            this.flightsGridView.Size = new System.Drawing.Size(1259, 512);
            this.flightsGridView.TabIndex = 0;
            this.flightsGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.flightsGridView_DataError);
            this.flightsGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flightsGridView_KeyUp);
            //
            // SearchTextBox
            //
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchTextBox.Location = new System.Drawing.Point(237, 85);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "   Начните печатать для поиска";
            this.SearchTextBox.Size = new System.Drawing.Size(1108, 29);
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
            this.SearchComboBox.Location = new System.Drawing.Point(86, 85);
            this.SearchComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(143, 29);
            this.SearchComboBox.TabIndex = 6;
            //
            // SimulationPage
            //
            this.SimulationPage.BackColor = System.Drawing.Color.White;
            this.SimulationPage.Controls.Add(this.extendedModellingPanel);
            this.SimulationPage.Controls.Add(this.modellingGrid);
            this.SimulationPage.Controls.Add(this.panel2);
            this.SimulationPage.Controls.Add(this.panel3);
            this.SimulationPage.Location = new System.Drawing.Point(4, 24);
            this.SimulationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimulationPage.Name = "SimulationPage";
            this.SimulationPage.Size = new System.Drawing.Size(1440, 889);
            this.SimulationPage.TabIndex = 2;
            this.SimulationPage.Text = "Моделирование";
            //
            // extendedModellingPanel
            //
            this.extendedModellingPanel.AllowDrop = true;
            this.extendedModellingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extendedModellingPanel.Location = new System.Drawing.Point(698, 43);
            this.extendedModellingPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extendedModellingPanel.Name = "extendedModellingPanel";
            this.extendedModellingPanel.Size = new System.Drawing.Size(595, 696);
            this.extendedModellingPanel.TabIndex = 7;
            //
            // modellingGrid
            //
            this.modellingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modellingGrid.AutoSize = true;
            this.modellingGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modellingGrid.BackColor = System.Drawing.Color.White;
            this.modellingGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.modellingGrid.ColumnCount = 10;
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.modellingGrid.Location = new System.Drawing.Point(698, 43);
            this.modellingGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modellingGrid.Name = "modellingGrid";
            this.modellingGrid.RowCount = 10;
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.modellingGrid.Size = new System.Drawing.Size(581, 681);
            this.modellingGrid.TabIndex = 6;
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.modellingTime);
            this.panel2.Location = new System.Drawing.Point(448, 592);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 91);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(765, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "1,0X";
            //
            // trackBar1
            //
            this.trackBar1.Location = new System.Drawing.Point(121, 25);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(619, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            //
            // modellingTime
            //
            this.modellingTime.CustomFormat = "H:mm";
            this.modellingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.modellingTime.Location = new System.Drawing.Point(726, 18);
            this.modellingTime.Name = "modellingTime";
            this.modellingTime.ShowUpDown = true;
            this.modellingTime.Size = new System.Drawing.Size(74, 25);
            this.modellingTime.TabIndex = 1;
            //
            // panel3
            //
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.ModellingScheduleLabel);
            this.panel3.Controls.Add(this.modellingGridView);
            this.panel3.Controls.Add(this.backToScheduleButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 880);
            this.panel3.TabIndex = 5;
            //
            // ModellingScheduleLabel
            //
            this.ModellingScheduleLabel.AutoSize = true;
            this.ModellingScheduleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModellingScheduleLabel.Location = new System.Drawing.Point(77, 32);
            this.ModellingScheduleLabel.Name = "ModellingScheduleLabel";
            this.ModellingScheduleLabel.Size = new System.Drawing.Size(346, 32);
            this.ModellingScheduleLabel.TabIndex = 6;
            this.ModellingScheduleLabel.Text = "Текущее расписание полётов";
            //
            // modellingGridView
            //
            this.modellingGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.modellingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modellingGridView.Location = new System.Drawing.Point(9, 75);
            this.modellingGridView.Name = "modellingGridView";
            this.modellingGridView.RowHeadersVisible = false;
            this.modellingGridView.RowHeadersWidth = 51;
            this.modellingGridView.RowTemplate.Height = 25;
            this.modellingGridView.Size = new System.Drawing.Size(429, 413);
            this.modellingGridView.TabIndex = 5;
            //
            // backToScheduleButton
            //
            this.backToScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.backToScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToScheduleButton.FlatAppearance.BorderSize = 0;
            this.backToScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToScheduleButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backToScheduleButton.Location = new System.Drawing.Point(162, 817);
            this.backToScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToScheduleButton.Name = "backToScheduleButton";
            this.backToScheduleButton.Size = new System.Drawing.Size(153, 43);
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
            // helpProvider1
            //
            this.helpProvider1.HelpNamespace = "C:\\Users\\user\\Desktop\\info.chm";
            //
            // timer1
            //
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.helpProvider1.SetShowHelp(this, true);
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
            this.SimulationPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modellingGridView)).EndInit();
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
        private Panel panel2;
        private Button startButton;
        private Label label3;
        private TrackBar trackBar1;
        private DateTimePicker modellingTime;
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
        private TextBox topologyName;
        public HelpProvider helpProvider1;
        private Panel panel3;
        private TableLayoutPanel modellingGrid;
        private ExtendedPanel extendedModellingPanel;
        private DataGridView modellingGridView;
        private Label ModellingScheduleLabel;
        private Timer timer1;
    }
}