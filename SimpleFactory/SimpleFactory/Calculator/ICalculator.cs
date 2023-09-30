using SimpleFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public interface ICalculator
    {
        string Calculate(OperationType type, int x, int y);
    }
}
