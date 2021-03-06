﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IotaCoinTracker
{
    public class Coin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Rank { get; set; }
        public double Price_USD { get; set; }

        public override string ToString()
        {
            return Name + " currently ranked at: " + Rank + " with current price of: " + Price_USD + " $";
        }
    }
}
