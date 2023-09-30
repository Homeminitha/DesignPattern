using FactoryMethod.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Calculator
{
    public class StandardCalculator : ICalculator
    {
        public string Add(int x, int y)
        {
            return $"Add: {x + y}";
        }

        public string Subtract(int x, int y)
        {
            return $"Subtract: {x - y}";
        }
        public string Multiply(int x, int y)
        {
            return $"Multiply: {x * y}";
        }

        public string Divide(int x, int y)
        {
            return $"Divide {x / y}";
        }

        public string Calculate(OperationType type, int x, int y)
        {
            switch (type)
            {
                case OperationType.Add:
                    return Add(x, y);
                case OperationType.Subtract:
                    return Subtract(x, y);
                case OperationType.Multiply:
                    return Multiply(x, y);
                case OperationType.Division:
                    return Divide(x, y);
                default:
                    return "Invalid Operation for Standard Calculator";
            }
        }
    }
}
