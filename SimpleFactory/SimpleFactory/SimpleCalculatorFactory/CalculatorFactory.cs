using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Calculator;
using SimpleFactory.Enum;

namespace SimpleFactory.SimpleCalculatorFactory
{
    public class CalculatorFactory
    {
        public static ICalculator CreateCalculator(CalculatorType calculatorType)
        {
            switch (calculatorType)
            {
                case CalculatorType.Standard:
                    return new StandardCalculator();
                case CalculatorType.Scentific:
                    return new ScentificCalculator();
                default:
                    return null;
            }
        }
    }
}
