using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
