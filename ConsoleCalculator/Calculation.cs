using System;
namespace ConsoleCalculator
{
   public interface ICalculation
    {
       string Operations(double number1, double number2);
    }
    
    public class Add : ICalculation
    {
        public string Operations(double number1, double number2)
        {
            return (number1 + number2).ToString();
        }
    }

    public class Subtract : ICalculation
    {
        public string Operations(double number1, double number2)
        {
            return (number1 - number2).ToString();
        }
    }

    public class Multiply : ICalculation
    {
        public string Operations(double number1, double number2)
        {
            return (number1 * number2).ToString();
        }
    }

    public class Divide : ICalculation
    {
        public string Operations(double number1, double number2)
        {
            if (number2 == 0)
                return "-E-";
            return (number1 / number2).ToString();
        }
    }
}


