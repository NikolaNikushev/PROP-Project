﻿namespace ShopApp
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.lblBasket = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbProducts = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantityToAdd = new System.Windows.Forms.NumericUpDown();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbActivityLog = new System.Windows.Forms.ListBox();
            this.btnChangeShop = new System.Windows.Forms.Button();
            this.pnlStoreSelect = new System.Windows.Forms.Panel();
            this.btnShopDataSubmit = new System.Windows.Forms.Button();
            this.tbShopCode = new System.Windows.Forms.TextBox();
            this.cmbxShopNames = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbCheckout = new System.Windows.Forms.GroupBox();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.lblCheckOutSign = new System.Windows.Forms.Label();
            this.grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToAdd)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlStoreSelect.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbCheckout.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(24, 396);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(112, 16);
            this.lblBalance.TabIndex = 19;
            this.lblBalance.Text = "Client Balance:";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbBalance.Location = new System.Drawing.Point(162, 390);
            this.tbBalance.Margin = new System.Windows.Forms.Padding(2);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(185, 22);
            this.tbBalance.TabIndex = 20;
            // 
            // lbBasket
            // 
            this.lbBasket.BackColor = System.Drawing.SystemColors.Info;
            this.lbBasket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.ItemHeight = 16;
            this.lbBasket.Location = new System.Drawing.Point(27, 44);
            this.lbBasket.Margin = new System.Windows.Forms.Padding(2);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.Size = new System.Drawing.Size(320, 308);
            this.lbBasket.TabIndex = 21;
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Location = new System.Drawing.Point(24, 15);
            this.lblBasket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(60, 16);
            this.lblBasket.TabIndex = 22;
            this.lblBasket.Text = "Basket:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(263, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPurchase.Location = new System.Drawing.Point(27, 428);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(137, 107);
            this.btnPurchase.TabIndex = 24;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 369);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(92, 16);
            this.lblTotalPrice.TabIndex = 25;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPrice.Location = new System.Drawing.Point(162, 363);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(185, 22);
            this.tbPrice.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(196, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 26);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel session";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(213, 428);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 103);
            this.btnUndo.TabIndex = 32;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(282, 428);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(65, 103);
            this.btnRedo.TabIndex = 33;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 651);
            this.panel1.TabIndex = 34;
            // 
            // grbProducts
            // 
            this.grbProducts.Controls.Add(this.label2);
            this.grbProducts.Controls.Add(this.nudQuantityToAdd);
            this.grbProducts.Controls.Add(this.pnlProducts);
            this.grbProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbProducts.Location = new System.Drawing.Point(0, 0);
            this.grbProducts.Name = "grbProducts";
            this.grbProducts.Size = new System.Drawing.Size(690, 594);
            this.grbProducts.TabIndex = 29;
            this.grbProducts.TabStop = false;
            this.grbProducts.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(441, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity to add:";
            // 
            // nudQuantityToAdd
            // 
            this.nudQuantityToAdd.Location = new System.Drawing.Point(583, 0);
            this.nudQuantityToAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantityToAdd.Name = "nudQuantityToAdd";
            this.nudQuantityToAdd.Size = new System.Drawing.Size(76, 26);
            this.nudQuantityToAdd.TabIndex = 33;
            this.nudQuantityToAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlProducts
            // 
            this.pnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.Location = new System.Drawing.Point(-3, 25);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(687, 573);
            this.pnlProducts.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbActivityLog);
            this.panel2.Controls.Add(this.btnChangeShop);
            this.panel2.Controls.Add(this.pnlStoreSelect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 57);
            this.panel2.TabIndex = 35;
            // 
            // lbActivityLog
            // 
            this.lbActivityLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbActivityLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbActivityLog.FormattingEnabled = true;
            this.lbActivityLog.ItemHeight = 16;
            this.lbActivityLog.Location = new System.Drawing.Point(324, 0);
            this.lbActivityLog.Name = "lbActivityLog";
            this.lbActivityLog.Size = new System.Drawing.Size(790, 52);
            this.lbActivityLog.TabIndex = 4;
            // 
            // btnChangeShop
            // 
            this.btnChangeShop.Location = new System.Drawing.Point(205, 4);
            this.btnChangeShop.Name = "btnChangeShop";
            this.btnChangeShop.Size = new System.Drawing.Size(113, 47);
            this.btnChangeShop.TabIndex = 3;
            this.btnChangeShop.Text = "Change Shop";
            this.btnChangeShop.UseVisualStyleBackColor = true;
            this.btnChangeShop.Click += new System.EventHandler(this.btnChangeShop_Click);
            // 
            // pnlStoreSelect
            // 
            this.pnlStoreSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStoreSelect.Controls.Add(this.btnShopDataSubmit);
            this.pnlStoreSelect.Controls.Add(this.tbShopCode);
            this.pnlStoreSelect.Controls.Add(this.cmbxShopNames);
            this.pnlStoreSelect.Location = new System.Drawing.Point(-1, -1);
            this.pnlStoreSelect.Name = "pnlStoreSelect";
            this.pnlStoreSelect.Size = new System.Drawing.Size(200, 58);
            this.pnlStoreSelect.TabIndex = 3;
            // 
            // btnShopDataSubmit
            // 
            this.btnShopDataSubmit.Location = new System.Drawing.Point(131, 4);
            this.btnShopDataSubmit.Name = "btnShopDataSubmit";
            this.btnShopDataSubmit.Size = new System.Drawing.Size(60, 47);
            this.btnShopDataSubmit.TabIndex = 1;
            this.btnShopDataSubmit.Text = "Display Products";
            this.btnShopDataSubmit.UseVisualStyleBackColor = true;
            this.btnShopDataSubmit.Click += new System.EventHandler(this.btnShopDataSubmit_Click);
            // 
            // tbShopCode
            // 
            this.tbShopCode.Location = new System.Drawing.Point(4, 31);
            this.tbShopCode.Name = "tbShopCode";
            this.tbShopCode.Size = new System.Drawing.Size(121, 20);
            this.tbShopCode.TabIndex = 2;
            // 
            // cmbxShopNames
            // 
            this.cmbxShopNames.FormattingEnabled = true;
            this.cmbxShopNames.Items.AddRange(new object[] {
            "Select a Store"});
            this.cmbxShopNames.Location = new System.Drawing.Point(4, 4);
            this.cmbxShopNames.Name = "cmbxShopNames";
            this.cmbxShopNames.Size = new System.Drawing.Size(121, 21);
            this.cmbxShopNames.TabIndex = 0;
            this.cmbxShopNames.Text = "Select a Store";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbProducts);
            this.panel3.Controls.Add(this.grbCheckout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 594);
            this.panel3.TabIndex = 36;
            // 
            // grbCheckout
            // 
            this.grbCheckout.Controls.Add(this.pnlCheckout);
            this.grbCheckout.Controls.Add(this.btnCancel);
            this.grbCheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbCheckout.Location = new System.Drawing.Point(700, 0);
            this.grbCheckout.Name = "grbCheckout";
            this.grbCheckout.Size = new System.Drawing.Size(416, 594);
            this.grbCheckout.TabIndex = 34;
            this.grbCheckout.TabStop = false;
            this.grbCheckout.Text = "Checkout";
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.btnRemoveSelectedItem);
            this.pnlCheckout.Controls.Add(this.lbBasket);
            this.pnlCheckout.Controls.Add(this.lblCheckOutSign);
            this.pnlCheckout.Controls.Add(this.lblTotalPrice);
            this.pnlCheckout.Controls.Add(this.btnPurchase);
            this.pnlCheckout.Controls.Add(this.btnClear);
            this.pnlCheckout.Controls.Add(this.tbBalance);
            this.pnlCheckout.Controls.Add(this.btnUndo);
            this.pnlCheckout.Controls.Add(this.lblBasket);
            this.pnlCheckout.Controls.Add(this.btnRedo);
            this.pnlCheckout.Controls.Add(this.tbPrice);
            this.pnlCheckout.Controls.Add(this.lblBalance);
            this.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.pnlCheckout.Location = new System.Drawing.Point(3, 52);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(410, 539);
            this.pnlCheckout.TabIndex = 34;
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(193, 12);
            this.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem";
            this.btnRemoveSelectedItem.Size = new System.Drawing.Size(65, 23);
            this.btnRemoveSelectedItem.TabIndex = 34;
            this.btnRemoveSelectedItem.Text = "Remove";
            this.btnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedItem.Click += new System.EventHandler(this.btnRemoveSelectedItem_Click);
            // 
            // lblCheckOutSign
            // 
            this.lblCheckOutSign.AutoSize = true;
            this.lblCheckOutSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCheckOutSign.Location = new System.Drawing.Point(367, 59);
            this.lblCheckOutSign.Name = "lblCheckOutSign";
            this.lblCheckOutSign.Size = new System.Drawing.Size(34, 264);
            this.lblCheckOutSign.TabIndex = 33;
            this.lblCheckOutSign.Text = "C\r\nH\r\nE\r\nC\r\nK\r\nO\r\nU\r\nT\r\n\r\n\r\n<<";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(763, 690);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.grbProducts.ResumeLayout(false);
            this.grbProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlStoreSelect.ResumeLayout(false);
            this.pnlStoreSelect.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbCheckout.ResumeLayout(false);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ComboBox cmbxShopNames;
        private System.Windows.Forms.Panel pnlStoreSelect;
        private System.Windows.Forms.Button btnShopDataSubmit;
        private System.Windows.Forms.TextBox tbShopCode;
        private System.Windows.Forms.Button btnChangeShop;
        private System.Windows.Forms.NumericUpDown nudQuantityToAdd;
        private System.Windows.Forms.ListBox lbActivityLog;
        private System.Windows.Forms.GroupBox grbCheckout;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblCheckOutSign;
        private System.Windows.Forms.Button btnRemoveSelectedItem;
    }
}

