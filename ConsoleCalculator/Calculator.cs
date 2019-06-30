using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        private CalculatorOperation operation = new CalculatorOperation();
        public string SendKeyPress(char key)
        {
            return operation.PerformOperation(key);
            throw new NotImplementedException();
        }
    }
}
