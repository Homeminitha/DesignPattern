using SimpleFactory.Enum;
using SimpleFactory.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class ScentificCalculator:ICalculator
    {
       public string Mod(int x, int y)
        {
            return $"Mod: {x % y}";
        }

        public string Calculate(OperationType type, int x, int y)
        {
            switch (type)
            {
                case OperationType.Mod:
                    return Mod(x, y);
                default:
                    return "Invalid operation for Scentific Calculator";
            }
        }
    }
}
