using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDriven.Calculator.Core;

namespace TestDriven.Calculator
{
    class Calculator:ICalculator
    {
        public Calculator()
        {
            m_total = 0.0;
        }

        private double m_total;

        #region ICalculator Members

        public double Total
        {
            get { return m_total; }
        }

        public double Add(double value)
        {
            m_total += value;
            return 4711; //m_total;
        }

        public double Subtract(double value)
        {
            m_total -= value;
            return 4711; // m_total;
        }

        public double Clear()
        {
            m_total = 0.0;
            return m_total;
        }

        #endregion
    }
}
