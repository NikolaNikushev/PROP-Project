using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ShopApp
{
    public static class ControlFactory
    {
        // margin for the panel
        private const int LEFTMARGIN = 9, TOPMARGIN = 3;
        // position of a button inside of a panel. always stays unchanged
        private const int BTNX = 6, BTNY = 26;
        // position of a label sotring the product name
        private const int LBLPRODUCTNAMEX = 3, LBLPRODUCTNAMEY = 8;
        // position of a unit storing the price and a currency
        private const int LBLUNITPRICEX = 75, LBLLEVELTWOY = 173, LBLCURRENCYX = 120;
        // the length and the width of a button
        private const int BTNSIDE = 140; // the other labels should be positioned this length away from the top border
                                         // the size of a panel
        private const int PANELWIDTH = 152, PANELHEIGHT = 224;
        // the position of the queantity labels
        const int LBLQUANX = 3, LBLLEVELTHREE = 201, LBLQUANVALX = 110;


        public static Panel ProducePanel(ref int X,ref int Y)
        {
            Panel myPanel = new Panel();
            myPanel.Location = new System.Drawing.Point(X, Y);
            myPanel.Size = new System.Drawing.Size(PANELWIDTH, PANELHEIGHT);
            //myPanel.Name = "pnlTest";
            myPanel.BackColor = Color.AliceBlue;
            myPanel.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9.75F, FontStyle.Bold);
            X = X + PANELWIDTH + LEFTMARGIN;
            return myPanel;
        }

        // Product Name
        public static Label ProduceLabelProductName(string ProdName)
        {
            Label myLblProductName = new Label();
            myLblProductName.Location = new System.Drawing.Point(LBLPRODUCTNAMEX, LBLPRODUCTNAMEY);
            myLblProductName.Text = ProdName;
            return myLblProductName;
        }


        public static Label ProduceLabelProductPrice(double ProdPrice)
        {
            Label myLblProductPrice = new Label();
            myLblProductPrice.Location = new System.Drawing.Point(LBLUNITPRICEX, LBLLEVELTWOY);
            myLblProductPrice.Text = ProdPrice.ToString();
            return myLblProductPrice;
        }


        public static Label ProduceLabelCurrency()
        {
            // Currency
            Label myLblCurrency = new Label();
            myLblCurrency.Text = "c";
            myLblCurrency.Location = new System.Drawing.Point(LBLCURRENCYX, LBLLEVELTWOY);
            return myLblCurrency;
        }


        public static Label ProduceLabelQuantityCaption()
        {
            // Quantity caption
            Label myLblProductQuantityCaption = new Label();
            myLblProductQuantityCaption.Text = "Quantity: ";
            myLblProductQuantityCaption.Location = new System.Drawing.Point(LBLQUANX, LBLLEVELTHREE);
            myLblProductQuantityCaption.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9.75F, FontStyle.Regular);
            return myLblProductQuantityCaption;
        }

        public static Label ProduceLabelQuantity(int ProdQuantity)
        {
            // Quantity caption
            Label myLblProductQuantity = new Label();
            myLblProductQuantity.Text = ProdQuantity.ToString();
            myLblProductQuantity.Location = new System.Drawing.Point(LBLQUANVALX, LBLLEVELTHREE);
            myLblProductQuantity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9.75F, FontStyle.Regular);
            return myLblProductQuantity;
        }


        public static Button ProduceButton(string ProdName)
        {
            Button myButton = new Button();
            myButton.Location = new System.Drawing.Point(BTNX, BTNY);
            myButton.Size = new System.Drawing.Size(BTNSIDE, BTNSIDE);
            myButton.Text = ProdName;
            return myButton;
        }



    }
}
