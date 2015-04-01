using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDriven.Calculator.Core
{
    public interface ICalculator
    {
        double Total { get; }
        double Add(double value);
        double Subtract(double value);
        double Clear();
    }
}
