using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class BuyStock : IOrder
    {

        private Stock abcStock;

        public BuyStock(Stock abcstock)
        {
            this.abcStock = abcstock;
        }
        public void Execute()
        {
            abcStock.Buy();
        }
    }
}
