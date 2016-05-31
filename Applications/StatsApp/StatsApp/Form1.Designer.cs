namespace StatsApp
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
            this.tabVisitors = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbStores = new System.Windows.Forms.ListBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSelectedShop = new System.Windows.Forms.Label();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Current_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tabVisitors.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
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
            this.label2.Location = new System.Drawing.Point(82, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(519, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitors Tracking";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Day3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Day2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Day1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(226, 81);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(108, 199);
            this.listBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose a Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Todays Visitors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 120);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 160);
            this.listBox1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabVisitors
            // 
            this.tabVisitors.Controls.Add(this.tabPage1);
            this.tabVisitors.Controls.Add(this.tabPage2);
            this.tabVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisitors.Location = new System.Drawing.Point(0, 0);
            this.tabVisitors.Name = "tabVisitors";
            this.tabVisitors.SelectedIndex = 0;
            this.tabVisitors.Size = new System.Drawing.Size(699, 511);
            this.tabVisitors.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 335);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbStores
            // 
            this.lbStores.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStores.FormattingEnabled = true;
            this.lbStores.Location = new System.Drawing.Point(3, 3);
            this.lbStores.Name = "lbStores";
            this.lbStores.Size = new System.Drawing.Size(120, 479);
            this.lbStores.TabIndex = 0;
            // 
            // lbProducts
            // 
            this.lbProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(123, 3);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(120, 479);
            this.lbProducts.TabIndex = 1;
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.Location = new System.Drawing.Point(165, 28);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(77, 75);
            this.btnDisplayInfo.TabIndex = 2;
            this.btnDisplayInfo.Text = "ShowInfo";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblSelectedShop
            // 
            this.lblSelectedShop.AutoSize = true;
            this.lblSelectedShop.Location = new System.Drawing.Point(31, 15);
            this.lblSelectedShop.Name = "lblSelectedShop";
            this.lblSelectedShop.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedShop.TabIndex = 5;
            this.lblSelectedShop.Text = "Selected Shop";
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Location = new System.Drawing.Point(31, 67);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedProduct.TabIndex = 6;
            this.lblSelectedProduct.Text = "Selected Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnDisplayInfo);
            this.panel1.Controls.Add(this.lblSelectedProduct);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSelectedShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(243, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 479);
            this.panel1.TabIndex = 8;
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
            this.dataGridView1.Location = new System.Drawing.Point(243, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 291);
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
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(510, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(178, 188);
            this.listBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 511);
            this.Controls.Add(this.tabVisitors);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabVisitors.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tabVisitors;
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
    }
}

