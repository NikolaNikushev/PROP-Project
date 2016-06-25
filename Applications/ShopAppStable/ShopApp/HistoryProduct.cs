using System.Collections.Generic;

namespace ShopApp
{
    public enum DirectionOption
    {
        TOBASKET,
        BACKFROMTHEBASKET
    }

    class HistoryProduct: Product
    {
        public DirectionOption ProductTransferDirection
        {
            get; private set;
        }

        /// <summary>
        /// Move the item to the stack specified in the parameters
        /// </summary>
        /// <param name="ActionStack"></param>
        public void ChangeStack(Stack<HistoryProduct> ActionStack)
        {
            switch(this.ProductTransferDirection)
            {
                case DirectionOption.BACKFROMTHEBASKET:
                    this.ProductTransferDirection = DirectionOption.TOBASKET;                    break;
                case DirectionOption.TOBASKET:
                    this.ProductTransferDirection = DirectionOption.BACKFROMTHEBASKET;
                    break;
            }
            ActionStack.Push(this);
        }

        public HistoryProduct(int id, string nm, double prc, int qntt, DirectionOption productTransferDirection)
            : base(id, nm, prc, qntt)
        {
            this.ProductTransferDirection = productTransferDirection;
        }
    }
}
