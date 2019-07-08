using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class CalculatorOpearationHelper
    {
        public static string CalculateResult(string operand1, string operand2, char? _operator)
        {
            double number1 = double.Parse(operand1);
            double number2 = double.Parse(operand2);
            ICalculation calculation;
            switch (_operator)
            {
                case '+':
                    calculation = new Add();
                    return calculation.Operations(number1, number2);

                case '-':
                    calculation = new Subtract();
                    return calculation.Operations(number1, number2);

                case 'x':
                case 'X':
                    calculation = new Multiply();
                    return calculation.Operations(number1, number2);

                case '/':
                    calculation = new Divide();
                    return calculation.Operations(number1, number2);

                default:
                    return "0";
            }
        }
    }
}
