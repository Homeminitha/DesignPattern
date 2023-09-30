using FactoryMethod.Calculator;
using FactoryMethod.Enum;
using FactoryMethod.FacotryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer x");
            string x = Console.ReadLine();
            Console.WriteLine("Enter an integer y");
            string y = Console.ReadLine();

            CalculatorFactory standardCalculatorFactory = new StandardCalculatorFactory();
            ICalculator calculateStandard = standardCalculatorFactory.CreateCalculator();

            Console.WriteLine(calculateStandard.Calculate(OperationType.Add, Convert.ToInt32(x), Convert.ToInt32(y)));
            Console.WriteLine(calculateStandard.Calculate(OperationType.Subtract, Convert.ToInt32(x), Convert.ToInt32(y)));
            Console.WriteLine(calculateStandard.Calculate(OperationType.Multiply, Convert.ToInt32(x), Convert.ToInt32(y)));
            Console.WriteLine(calculateStandard.Calculate(OperationType.Division, Convert.ToInt32(x), Convert.ToInt32(y)));

            CalculatorFactory scientificCalculatorFactory = new ScientificCalculatorFactory();
            ICalculator calculateScientific = scientificCalculatorFactory.CreateCalculator();

            Console.WriteLine(calculateScientific.Calculate(OperationType.Mod, Convert.ToInt32(x), Convert.ToInt32(y)));

            Console.WriteLine("Press enter to close the window");
            Console.ReadLine();
        }
    }
}
