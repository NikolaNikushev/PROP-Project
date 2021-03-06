﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace ShopApp
{
    //dont forget to make an if for selling more then you have!
    public partial class Form1 : Form
    {
        //List<Product> Shop;
        Shop chosenShop;
        DBHelper dbh;
        private RFID myRFIDReader;

        const string ACCODEPLACEHOLDER = "Access code here...";

        //int quantity;
        double balance = 0;
        int buyerId = 0;
        string tag;
        int workingRFID;

        double totalPrice;

        Stack<HistoryProduct> actions;
        Stack<HistoryProduct> undoneActions;


        private void RemoveText(object sender, EventArgs e)
        {
            if (this.tbShopCode.Text == ACCODEPLACEHOLDER)
            {
                this.tbShopCode.Text = "";
                this.tbShopCode.ForeColor = Color.Black;
            }
        }
        private void AddText(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(this.tbShopCode.Text))
            {
                this.tbShopCode.ForeColor = Color.Gray;
                this.tbShopCode.Text = ACCODEPLACEHOLDER;
            }
        }



        public Form1()
        {
            InitializeComponent();
            workingRFID = 0;
            this.pnlCheckout.Enabled = false;
            this.btnCancel.Enabled = true;
            try
            {
                dbh = new DBHelper();
                List<String> names = dbh.RetrieveStoreNames();
                this.cmbxShopNames.Items.AddRange(names.ToArray());
            }
            catch
            {
                this.LogMessage("Could not connect to the db. Press the button SUBMIT to try again");
            }
            try
            {
                myRFIDReader = new RFID();
                openRFID();
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

            }
            catch (PhidgetException) { this.LogMessage("error at start-up."); }
            this.LogMessage("Hello, please choose your shop on the left first");
            this.tbBalance.Text = balance.ToString();

            this.tbShopCode.ForeColor = Color.Gray;
            this.tbShopCode.Text = ACCODEPLACEHOLDER;

            this.tbShopCode.GotFocus += new EventHandler(RemoveText);
            this.tbShopCode.LostFocus += new EventHandler(AddText);

            tbPrice.Text = "0";

            //quantity = 1;
            actions = new Stack<HistoryProduct>();
            undoneActions = new Stack<HistoryProduct>();
            // do all the stuff to display the products etc

        }

        private void openRFID()
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { this.LogMessage("no RFID-reader opened"); }
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            int paid = dbh.CheckIfPaid(e.Tag);
            if (paid == 1 && workingRFID == 0)
            {

                //btnScan.Visible = false;
                balance = dbh.getBalance(e.Tag, out buyerId);
                tbBalance.Text = Convert.ToString(balance);
                tag = e.Tag;
                workingRFID = 1;

            }
            else
            {
                MessageBox.Show("Invalid RFID / RFID Already in use");
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (chosenShop.Basket.Count > 0 && workingRFID == 1)
            {
                totalPrice = this.chosenShop.TotalPrice;
                if (balance > totalPrice)
                {
                    // old
                    //double newbalance = balance - totalPrice;
                    //dbh.UpdateBalance(tag, newbalance);
                    //int newcocacolas = cocacolas - cocacolasInBasket;
                    //dbh.UpdateQuantity("CocaCola", newcocacolas);
                    try
                    {
                        //now everything is done here
                        dbh.RecordPurchase(buyerId, ref balance, chosenShop);
                        buyerId = 0;
                        this.tbBalance.Text = balance.ToString();
                        this.ReinitializeTheStore();
                        this.ClearBuyer();
                        actions.Clear();
                        this.LogMessage("Purchase successfull");
                        //btnScan.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        this.LogMessage(ex.Message);
                    }


                }
                else { this.LogMessage("Not enough money"); }
            }
            else
            {
                this.LogMessage("Purchase is not successful");
            }

        }

        /// <summary>
        /// Clears the basket and resets the store but keeps the user data untouched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // NB: if you undo the cancel the redo should restore all the products back... 
            this.ReinitializeTheStore();
            tbPrice.Text = chosenShop.TotalPrice.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myRFIDReader.LED = false;
            //myRFIDReader.Antenna = false;
            //myRFIDReader.close();
        }

        /// <summary>
        /// Cancels all the changes done during the last period. Returns back to the Database retrieved state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            // the easiest way to set everything to the db state - to reinitialize the shop
            this.ReinitializeTheStore();
            this.ClearBuyer();
            actions.Clear();
        }

        //Product temp;
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (basket.Count > 0)
        //    {
        //        temp = basket.Pop();
        //        reverseBasket.Push(temp);
        //        totalPrice = totalPrice - (temp.Price * temp.Quantity);
        //        tbPrice.Text = totalPrice.ToString();

        //        switch (temp.Name)
        //        {
        //            case "CocaCola":
        //                cocacolasInBasket = cocacolasInBasket - temp.Quantity;
        //                break;
        //            case "Fanta":
        //                fantasInBasket = fantasInBasket - temp.Quantity;
        //                break;
        //            case "Sprite":
        //                spritesInBasket = spritesInBasket - temp.Quantity;
        //                break;
        //            case "HotDog":
        //                hotdogsInBasket = hotdogsInBasket - temp.Quantity;
        //                break;
        //            case "Pizza":
        //                pizzasInBasket = pizzasInBasket - temp.Quantity;
        //                break;
        //            case "Burger":
        //                burgersInBasket = burgersInBasket - temp.Quantity;
        //                break;
        //            case "Fries":
        //                friesInBasket = friesInBasket - temp.Quantity;
        //                break;
        //            case "Beer":
        //                beersInBasket = beersInBasket - temp.Quantity;
        //                break;
        //            case "SexyLady":
        //                womenInBasket = womenInBasket - temp.Quantity;
        //                break;
        //        }
        //        lbBasket.Items.RemoveAt(lbBasket.Items.Count - 1);
        //    }
        //    else { MessageBox.Show("Nothing to undo"); }
        //}

        /// <summary>
        /// Recreates the store object and retrieves the data from the database
        /// </summary>
        private void ReinitializeTheStore()
        {
            this.actions.Clear();
            this.undoneActions.Clear();
            try
            {
                lbBasket.Items.Clear();
                while (pnlProducts.Controls.Count > 0)
                {
                    this.pnlProducts.Controls[0].Dispose();
                }
                this.chosenShop = new Shop(this.cmbxShopNames.SelectedItem.ToString());
                this.DisplayAllProducts();
                this.tbPrice.Text = this.chosenShop.TotalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.LogMessage("Could not connect to the db. Press the button SUBMIT to try again");
            }

        }


        /// <summary>
        /// Displays all the products there are in stock
        /// </summary>
        private void DisplayAllProducts()
        {
            int X = 9, Y = 5;
            foreach (Product p in chosenShop.Stock)
            {
                this.GenerateProductControl(p, ref X, ref Y);
            }
        }


        /// <summary>
        /// Generates a panel with all the controls inside. 
        /// X and Y are passed as reference and are updated during the runtime of the method
        /// </summary>
        /// <param name="Prod"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        private void GenerateProductControl(Product Prod, ref int X, ref int Y)
        {
            //The height of a panel + a margin
            const int VDIFFERENCE = 227;

            Panel myPanel;
            Button myButton;
            Label myLblProductName;
            Label myLblProductPrice;
            Label myLblCurrency;
            Label myLblProductQuantityCaption;
            Label myLblProductQuantity;

            // the main thing to store every other product related control
            myPanel = ControlFactory.ProducePanel(ref X, ref Y);

            // Product Name
            myLblProductName = ControlFactory.ProduceLabelProductName(Prod.Name);

            // Product price
            myLblProductPrice = ControlFactory.ProduceLabelProductPrice(Prod.Price);

            // Currency
            myLblCurrency = ControlFactory.ProduceLabelCurrency();

            // Quantity caption
            myLblProductQuantityCaption = ControlFactory.ProduceLabelQuantityCaption();

            // tha actual value
            myLblProductQuantity = ControlFactory.ProduceLabelQuantity(Prod.Quantity);

            myButton = ControlFactory.ProduceButton(Prod.Name);
            myButton.Click += new EventHandler(this.PutProductToBasket);
            myButton.Tag = Prod;

            myPanel.Controls.Add(myButton); // index 0
            myPanel.Controls.Add(myLblProductName);  // index 1
            myPanel.Controls.Add(myLblProductPrice); // index 2
            myPanel.Controls.Add(myLblCurrency); // index 3
            myPanel.Controls.Add(myLblProductQuantityCaption); // index 4
            myPanel.Controls.Add(myLblProductQuantity); // index 5
            this.pnlProducts.Controls.Add(myPanel);

            //X = X + PANELWIDTH + LEFTMARGIN;
            if (X + myPanel.Width >= this.pnlProducts.Width)
            {
                X = 9;
                Y = Y + VDIFFERENCE;
            }
        }



        /// <summary>
        /// Puts a certain product to he basket and updates everything else accordingly
        /// every time a new item is put the redo list is cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PutProductToBasket(object sender, EventArgs e)
        {
            // we need to check how many those products do we have
            int availableStock = int.Parse(((Button)sender).Parent.Controls[5].Text);
            // the number of instances of one product to buy
            int selectedQuantity = (int)this.nudQuantityToAdd.Value;
            if (availableStock != 0)
            {
                Product productToBasket = chosenShop.getProductByName(((Button)sender).Text, chosenShop.Stock);
                // if we want to sell more than what is left, we can not do that... so SELL AAAAAL THE ITEMS LEFT SO FAR
                if (selectedQuantity > availableStock)
                {
                    selectedQuantity = availableStock;
                    this.LogMessage("Sorry, requested to sell more than we have in stock. Sold out the " + productToBasket.Name);
                }
                this.actions.Push(new HistoryProduct(productToBasket.Id, productToBasket.Name, productToBasket.Price, selectedQuantity, DirectionOption.TOBASKET));

                productToBasket.LowerQuantityBy(selectedQuantity);
                Product temp = new Product(productToBasket.Id, productToBasket.Name, productToBasket.Price, selectedQuantity);
                // prepared to be added to the basket
                chosenShop.AddToBasket(temp);

                // added to the basket, now we need to update the quantity (index 5)
                ((Button)sender).Parent.Controls[(int)ControlEnums.QUANTITY].Text = productToBasket.Quantity.ToString();
                this.UpdateBasket();
                this.undoneActions.Clear();
            }
            else
            {
                this.LogMessage("Sorry " + ((Button)sender).Text + " is sold out! Request more from the warehouse!");
            }
            // need to reset the qualifier
            this.nudQuantityToAdd.Value = 1;

        }

        /// <summary>
        /// Puts the message to a activity log - potentially also can be a part of event-triggered methods
        /// </summary>
        /// <param name="msg"></param>
        private void LogMessage(string msg)
        {
            this.lbActivityLog.Items.Insert(0, msg);
        }

        /// <summary>
        /// Reinitilizes the basket and displays the current contents of the basket of this shop
        /// </summary>
        private void UpdateBasket()
        {
            lbBasket.Items.Clear();
            foreach (Product p in chosenShop.Basket)
            {
                this.lbBasket.Items.Add(p);
            }
            this.tbPrice.Text = this.chosenShop.TotalPrice.ToString();
        }

        /// <summary>
        /// Generally we undo the undone actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedo_Click(object sender, EventArgs e)
        {
            // keep imaginary "history"-product with properties WhereTo(to the Basket or back from the basket) Quantity Name
            // well, since the controls inside of a panel are generated based on the array they should share the same indexes
            if (undoneActions.Count > 0)
            {
                HistoryProduct historyProd = this.undoneActions.Pop();
                int prodAndControlId = this.chosenShop.Stock.FindIndex(p => p.Name == historyProd.Name);
                // managing the quantity in the display
                this.ModifyControlQuantity(historyProd.Name, -(historyProd.Quantity));
                // done adjusting

                chosenShop.AddToBasket(new Product(historyProd));


                historyProd.ChangeStack(actions);
                // very bad to do - since will a lot of time, but for now - it's okay
                this.UpdateBasket();
            }
            else
            {
                this.LogMessage("Nothing to redo.");
            }
        }

        /// <summary>
        /// Just for fun. Change the label on the right part of a checkout module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width - this.lbBasket.Width >= this.MinimumSize.Width)
            {
                this.lblCheckOutSign.Text = "C\nH\nE\nC\nK\nO\nU\nT\n\n\n<<";
            }
            else
            {
                this.lblCheckOutSign.Text = "C\nH\nE\nC\nK\nO\nU\nT\n\n\n>>";
            }
        }


        /// <summary>
        /// reverts the last additions
        /// keep imaginary "history"-product with properties WhereTo(to the Basket or back from the basket) Quantity Name
        /// well, since the controls inside of a panel are generated based on the array they should share the same indexes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            // keep imaginary "history"-product with properties WhereTo(to the Basket or back from the basket) Quantity Name
            // well, since the controls inside of a panel are generated based on the array they should share the same indexes
            if (actions.Count > 0)
            {
                HistoryProduct temp = this.actions.Pop();
                this.ModifyControlQuantity(temp.Name, temp.Quantity);
                // done adjusting

                // make it objects
                Product prodInBasket = this.chosenShop.getProductByName(temp.Name, this.chosenShop.Basket);
                if (prodInBasket != null)
                {
                    prodInBasket.LowerQuantityBy(temp.Quantity);
                    if (prodInBasket.Quantity == 0)
                    {
                        this.chosenShop.Basket.Remove(prodInBasket);
                    }
                }


                temp.ChangeStack(undoneActions);
                // very bad to do - since will a lot of time, but for now - it's okay
                this.UpdateBasket();
            }
            else
            {
                this.LogMessage("Nothing to undo.");
            }
        }

        /// <summary>
        /// Modifies the quantity in the products panel
        /// finds the product index in the chosenShop.Stock
        /// quantity can be both negative and positive, use with caution
        /// Quantity increases the current quantity there is
        /// </summary>
        /// <param name="name"></param>
        /// <param name="listToCheck"></param>
        /// <param name="quantity"></param>
        private void ModifyControlQuantity(string name, int quantity)
        {
            int controlId = this.chosenShop.Stock.FindIndex(p => p.Name == name);
            // managing the quantity in the display
            // since we undo the adding of products to the basket we should increase the quantity
            string quantityRead = this.pnlProducts.Controls[controlId].Controls[(int)ControlEnums.QUANTITY].Text;
            int quantityReadVal;
            int.TryParse(quantityRead, out quantityReadVal);
            quantityReadVal += quantity;
            this.pnlProducts.Controls[controlId].Controls[(int)ControlEnums.QUANTITY].Text = quantityReadVal.ToString();
            // done adjusting
        }


        private void btnShopDataSubmit_Click(object sender, EventArgs e)
        {
            if (this.cmbxShopNames.SelectedIndex != 0)
            {
                this.ReinitializeTheStore();
                this.pnlStoreSelect.Enabled = false;
                this.pnlCheckout.Enabled = true;
            }

        }

        /// <summary>
        /// currently one can not undo the clear order or remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            Product productToRemove = (Product)this.lbBasket.SelectedItem;
            if (productToRemove != null)
            {
                this.ModifyControlQuantity(productToRemove.Name, productToRemove.Quantity);
                this.chosenShop.Basket.Remove(productToRemove);
                this.lbBasket.Items.Remove(productToRemove);
            }
            this.UpdateBasket();
        }

        private void btnChangeShop_Click(object sender, EventArgs e)
        {
            this.pnlCheckout.Enabled = false;
            this.btnCancel.Enabled = true;
            this.pnlStoreSelect.Enabled = true;
            this.ClearBuyer();

        }

        /// <summary>
        /// Clears the data abou the current visitor, if there's any
        /// and makes it possible to register a new buyer
        /// </summary>
        private void ClearBuyer()
        {
            if (workingRFID!=0)
            {
                buyerId = 0;
                totalPrice = 0;
                //tbPrice.Text = totalPrice.ToString();
                balance = 0;
                this.tbBalance.Text = balance.ToString();
                //btnScan.Visible = true;
                workingRFID = 0;
                tag = "";
            }
        }
    }
}
