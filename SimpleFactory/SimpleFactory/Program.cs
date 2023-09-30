using SimpleFactory.Calculator;
using SimpleFactory.Enum;
using SimpleFactory.SimpleCalculatorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer x");
            string x = Console.ReadLine();
            Console.WriteLine("Enter an integer y");
            string y = Console.ReadLine();

            ICalculatorFactory simpleFactory = new CalculatorFactory();
            ICalculator standardCalculator = simpleFactory.CreateCalculator(CalculatorType.Standard);
            ICalculator scentificCalculator = simpleFactory.CreateCalculator(CalculatorType.Scentific);

            Console.WriteLine(standardCalculator.Calculate(OperationType.Add, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine(standardCalculator.Calculate(OperationType.Subtract, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine(standardCalculator.Calculate(OperationType.Multiply, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine(standardCalculator.Calculate(OperationType.Division, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine(scentificCalculator.Calculate(OperationType.Mod, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine("Press enter to close the window");
            Console.ReadLine();
        }
    }
}
