using SimpleFactory.Enum;
using SimpleFactory.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.SimpleCalculatorFactory
{
    public interface ICalculatorFactory
    {
        ICalculator CreateCalculator(CalculatorType calculatorType);
    }
}
