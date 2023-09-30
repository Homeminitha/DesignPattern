using FactoryMethod.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FacotryMethod
{
    interface CalculatorFactory
    {
        ICalculator CreateCalculator();
    }
}
