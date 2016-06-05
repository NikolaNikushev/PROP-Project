using System;
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

        int quantity;
        double balance;
        string tag;
        int workingRFID;

        double totalPrice;

        Stack<Product> basket;
        Stack<Product> reverseBasket;
        public Form1()
        {
            InitializeComponent();
            workingRFID = 0;
            dbh = new DBHelper();
            //try
            //{
            //    myRFIDReader = new RFID();
            //    openRFID();
            //    myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

            //}
            //catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }



            tbPrice.Text = "0";
            balance = 0;
            quantity = 1;
            basket = new Stack<Product>();
            reverseBasket = new Stack<Product>();
            // do all the stuff to display the products etc
            this.ReinitializeTheStore();
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
            catch (PhidgetException) { MessageBox.Show("no RFID-reader opened"); }
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            int paid = dbh.CheckIfPaid(e.Tag);
            if (paid == 1 && workingRFID == 0)
            {

                //btnScan.Visible = false;
                balance = dbh.getBalance(e.Tag);
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
            if (balance > totalPrice)
            {
                double newbalance = balance - totalPrice;
                dbh.UpdateBalance(tag, newbalance);

                //int newcocacolas = cocacolas - cocacolasInBasket;
                //dbh.UpdateQuantity("CocaCola", newcocacolas);


                lbBasket.Items.Clear();



                balance = 0;
                totalPrice = 0;
                tbPrice.Text = totalPrice.ToString();
                workingRFID = 0;



                MessageBox.Show("Purchase successfull");
                //btnScan.Visible = true;
            }
            else { MessageBox.Show("Not enough money"); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbBasket.Items.Clear();

            totalPrice = 0;
            tbPrice.Text = totalPrice.ToString();
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
            lbBasket.Items.Clear();
            // the easiest way to set everything to the db state - to reinitialize the shop
            this.ReinitializeTheStore();

            totalPrice = 0;
            tbPrice.Text = totalPrice.ToString();
            balance = 0;
            //btnScan.Visible = true;
            workingRFID = 0;
            basket.Clear();
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

        private void ReinitializeTheStore()
        {
            while (pnlProducts.Controls.Count > 0)
            {
                this.pnlProducts.Controls[0].Dispose();
            } 
            this.chosenShop = new Shop();
            this.DisplayAllProducts();
        }


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
                productToBasket.LowerQuantityBy(selectedQuantity);
                Product temp = new Product(productToBasket.Id, productToBasket.Name, productToBasket.Price, (int)this.nudQuantityToAdd.Value);
                // prepared to be added to the basket
                chosenShop.AddToBasket(temp);

                // added to the basket, now we need to update the quantity (index 5)
                ((Button)sender).Parent.Controls[5].Text = productToBasket.Quantity.ToString();
                this.UpdateBasket();
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
            double totalPrice = 0;
            lbBasket.Items.Clear();
            foreach (Product p in chosenShop.Basket)
            {
                totalPrice += (p.Price * p.Quantity);
                this.lbBasket.Items.Add(p);
            }
            this.tbPrice.Text = totalPrice.ToString();
        }


        private void btnRedo_Click(object sender, EventArgs e)
        {
            //    if (reverseBasket.Count > 0)
            //    {
            //        temp = reverseBasket.Pop();
            //        basket.Push(temp);
            //        totalPrice = totalPrice + (temp.Price * temp.Quantity);
            //        tbPrice.Text = totalPrice.ToString();
            //        switch (temp.Name)
            //        {
            //            case "CocaCola":
            //                cocacolasInBasket = cocacolasInBasket + temp.Quantity;
            //                break;
            //            case "Fanta":
            //                fantasInBasket = fantasInBasket + temp.Quantity;
            //                break;
            //            case "Sprite":
            //                spritesInBasket = spritesInBasket + temp.Quantity;
            //                break;
            //            case "HotDog":
            //                hotdogsInBasket = hotdogsInBasket + temp.Quantity;
            //                break;
            //            case "Pizza":
            //                pizzasInBasket = pizzasInBasket + temp.Quantity;
            //                break;
            //            case "Burger":
            //                burgersInBasket = burgersInBasket + temp.Quantity;
            //                break;
            //            case "Fries":
            //                friesInBasket = friesInBasket + temp.Quantity;
            //                break;
            //            case "Beer":
            //                beersInBasket = beersInBasket + temp.Quantity;
            //                break;
            //            case "SexyLady":
            //                womenInBasket = womenInBasket + temp.Quantity;
            //                break;
            //        }
            //        lbBasket.Items.Add(temp.Name + " " + temp.Quantity.ToString());
            //    }
            //    else { MessageBox.Show("Nothing to redo"); }
        }
    }
}
