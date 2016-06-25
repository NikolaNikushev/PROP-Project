﻿namespace StatsApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabModules = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Current_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSelectedShop = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbStores = new System.Windows.Forms.ListBox();
            this.tabWarehouse = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSalesOverview = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductStock = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDisplayProducts = new System.Windows.Forms.Button();
            this.cmbStorageSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tabModules.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStock)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Visitors";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1256, 592);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitors Tracking";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 394);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 85);
            this.button3.TabIndex = 8;
            this.button3.Text = "Day3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 85);
            this.button2.TabIndex = 7;
            this.button2.Text = "Day2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Day1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(440, 139);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 340);
            this.listBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose a Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Todays Visitors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(62, 142);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 340);
            this.listBox1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabModules
            // 
            this.tabModules.Controls.Add(this.tabPage1);
            this.tabModules.Controls.Add(this.tabPage2);
            this.tabModules.Controls.Add(this.tabWarehouse);
            this.tabModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModules.Location = new System.Drawing.Point(0, 0);
            this.tabModules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabModules.Name = "tabModules";
            this.tabModules.SelectedIndex = 0;
            this.tabModules.Size = new System.Drawing.Size(1281, 645);
            this.tabModules.TabIndex = 3;
            this.tabModules.SelectedIndexChanged += new System.EventHandler(this.tabModules_TabIndexChanged);
            this.tabModules.TabIndexChanged += new System.EventHandler(this.tabModules_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1273, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visitors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lbProducts);
            this.tabPage2.Controls.Add(this.lbStores);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1273, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(1033, 4);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(236, 250);
            this.listBox3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Current_Stock,
            this.Total_Sales,
            this.Total_Revenue,
            this.Warehouse_Stock});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(322, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 358);
            this.dataGridView1.TabIndex = 9;
            // 
            // Current_Stock
            // 
            this.Current_Stock.HeaderText = "Current Stock";
            this.Current_Stock.Name = "Current_Stock";
            this.Current_Stock.ReadOnly = true;
            // 
            // Total_Sales
            // 
            this.Total_Sales.HeaderText = "Total Sales";
            this.Total_Sales.Name = "Total_Sales";
            this.Total_Sales.ReadOnly = true;
            // 
            // Total_Revenue
            // 
            this.Total_Revenue.HeaderText = "Total Revenue";
            this.Total_Revenue.Name = "Total_Revenue";
            this.Total_Revenue.ReadOnly = true;
            // 
            // Warehouse_Stock
            // 
            this.Warehouse_Stock.HeaderText = "Warehouse Stock";
            this.Warehouse_Stock.Name = "Warehouse_Stock";
            this.Warehouse_Stock.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnDisplayInfo);
            this.panel1.Controls.Add(this.lblSelectedProduct);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSelectedShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(322, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 608);
            this.panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.Location = new System.Drawing.Point(220, 34);
            this.btnDisplayInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(103, 92);
            this.btnDisplayInfo.TabIndex = 2;
            this.btnDisplayInfo.Text = "ShowInfo";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Location = new System.Drawing.Point(41, 82);
            this.lblSelectedProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(116, 17);
            this.lblSelectedProduct.TabIndex = 6;
            this.lblSelectedProduct.Text = "Selected Product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblSelectedShop
            // 
            this.lblSelectedShop.AutoSize = true;
            this.lblSelectedShop.Location = new System.Drawing.Point(41, 18);
            this.lblSelectedShop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedShop.Name = "lblSelectedShop";
            this.lblSelectedShop.Size = new System.Drawing.Size(100, 17);
            this.lblSelectedShop.TabIndex = 5;
            this.lblSelectedShop.Text = "Selected Shop";
            // 
            // lbProducts
            // 
            this.lbProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(163, 4);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(159, 608);
            this.lbProducts.TabIndex = 1;
            // 
            // lbStores
            // 
            this.lbStores.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStores.FormattingEnabled = true;
            this.lbStores.ItemHeight = 16;
            this.lbStores.Location = new System.Drawing.Point(4, 4);
            this.lbStores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStores.Name = "lbStores";
            this.lbStores.Size = new System.Drawing.Size(159, 608);
            this.lbStores.TabIndex = 0;
            // 
            // tabWarehouse
            // 
            this.tabWarehouse.Controls.Add(this.chart1);
            this.tabWarehouse.Controls.Add(this.panel4);
            this.tabWarehouse.Controls.Add(this.panel3);
            this.tabWarehouse.Controls.Add(this.dgvProductStock);
            this.tabWarehouse.Controls.Add(this.panel2);
            this.tabWarehouse.Location = new System.Drawing.Point(4, 25);
            this.tabWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWarehouse.Name = "tabWarehouse";
            this.tabWarehouse.Size = new System.Drawing.Size(1273, 616);
            this.tabWarehouse.TabIndex = 2;
            this.tabWarehouse.Text = "Warehouse";
            this.tabWarehouse.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(864, 214);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(409, 402);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(864, 55);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 159);
            this.panel4.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 106);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel7.Controls.Add(this.lblSalesOverview);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(409, 53);
            this.panel7.TabIndex = 1;
            // 
            // lblSalesOverview
            // 
            this.lblSalesOverview.AutoSize = true;
            this.lblSalesOverview.Location = new System.Drawing.Point(8, 21);
            this.lblSalesOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOverview.Name = "lblSalesOverview";
            this.lblSalesOverview.Size = new System.Drawing.Size(215, 24);
            this.lblSalesOverview.TabIndex = 1;
            this.lblSalesOverview.Text = "HISTORY OVERVIEW";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(549, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 561);
            this.panel3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 53);
            this.panel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "GENERAL OVERVIEW";
            // 
            // dgvProductStock
            // 
            this.dgvProductStock.AllowUserToAddRows = false;
            this.dgvProductStock.AllowUserToDeleteRows = false;
            this.dgvProductStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProductStock.Location = new System.Drawing.Point(0, 55);
            this.dgvProductStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductStock.Name = "dgvProductStock";
            this.dgvProductStock.Size = new System.Drawing.Size(549, 561);
            this.dgvProductStock.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 55);
            this.panel2.TabIndex = 1;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(404, 0);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(869, 55);
            this.listBox4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(288, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(116, 55);
            this.panel8.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "???didn\'t decide what should it be yet";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDisplayProducts);
            this.panel5.Controls.Add(this.cmbStorageSelect);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 55);
            this.panel5.TabIndex = 2;
            // 
            // btnDisplayProducts
            // 
            this.btnDisplayProducts.Location = new System.Drawing.Point(200, 5);
            this.btnDisplayProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayProducts.Name = "btnDisplayProducts";
            this.btnDisplayProducts.Size = new System.Drawing.Size(81, 47);
            this.btnDisplayProducts.TabIndex = 1;
            this.btnDisplayProducts.Text = "Display Products";
            this.btnDisplayProducts.UseVisualStyleBackColor = true;
            this.btnDisplayProducts.Click += new System.EventHandler(this.btnDisplayProducts_Click);
            // 
            // cmbStorageSelect
            // 
            this.cmbStorageSelect.FormattingEnabled = true;
            this.cmbStorageSelect.Items.AddRange(new object[] {
            "Warehouse",
            "MOES"});
            this.cmbStorageSelect.Location = new System.Drawing.Point(11, 16);
            this.cmbStorageSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStorageSelect.Name = "cmbStorageSelect";
            this.cmbStorageSelect.Size = new System.Drawing.Size(160, 24);
            this.cmbStorageSelect.TabIndex = 0;
            this.cmbStorageSelect.Text = "Select a storage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 645);
            this.Controls.Add(this.tabModules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabModules.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabWarehouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabModules;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Label lblSelectedProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSelectedShop;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbStores;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_Stock;
        private System.Windows.Forms.TabPage tabWarehouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProductStock;
        private System.Windows.Forms.ComboBox cmbStorageSelect;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDisplayProducts;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblSalesOverview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

