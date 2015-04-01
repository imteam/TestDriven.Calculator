using TestDriven.Calculator;
using TestDriven.Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestProject1
{   
    [TestClass()]
    public class CalculatorTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod()]
        public void CalculatorConstructorTest()
        {
            ICalculator calc = new Calculator();

            Assert.IsTrue(null != calc, "Constructor Fehler");
            Assert.IsTrue(0.0D == calc.Total, "Ist nicht mit 0.0 initialisiert");
        }

        [TestMethod()]
        public void CalculatorAdditionTest()
        {
            ICalculator calc;
            double expected, actual;

            calc = new Calculator();
            expected = 1.0;
            actual = calc.Add(1.0);

            Assert.AreEqual(expected, actual, "0 + 1 muss 1 ergeben");
            Assert.AreEqual(expected, calc.Total, "Summe ist falsch");

            expected = 2.5;
            actual = calc.Add(1.5);
            Assert.AreEqual(expected, actual, "1 + 1.5 muss 2.5 ergeben");
            Assert.AreEqual(expected, calc.Total, "Summe ist falsch");
        }

        [TestMethod()]
        public void CalculatorSubtractionTest()
        {
            ICalculator calc;
            double expected, actual;

            calc = new Calculator();
            expected = -1.0;
            actual = calc.Subtract(1.0);

            Assert.AreEqual(expected, actual, "0 - 1 muss -1 ergeben");
            Assert.AreEqual(expected, calc.Total, "Differenz ist falsch");

            expected = -2.5;
            actual = calc.Subtract(1.5);
            Assert.AreEqual(expected, actual, "-1 -1.5 muss -2.5 ergeben");
            Assert.AreEqual(expected, calc.Total, "Differenz ist falsch");
        }

        [TestMethod()]
        public void ClearTest()
        {
            ICalculator calc;

            calc = new Calculator();
            calc.Add(123.456);
            calc.Clear();

            Assert.AreEqual(0.0, calc.Total, "Calculator wurde nicht zurückgesetzt");
        }
    }
}
