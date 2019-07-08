using System;

namespace ConsoleCalculator
{
    public class CalculatorOperation
    {
        private bool hasProcesed = true;
        private string operand1 = "";
        private string operand2 = "";
        private char? _operator = null;
        private string digits = "1234567890.";
        private string operators = "+-/xX";

        private const string Error = "-E-";

        public string PerformOperation(char key)
        {

            if (digits.Contains(key.ToString()))
                _HandleDigit(key);

            else if (operators.Contains(key.ToString()))
                ActionOnOperator(key);

            else if (key == 'C' || key == 'c')
                ClearConsole();

            else if (key == 's' || key == 'S')
                ToggleSign(key);

            else if (key == '=')
            {
                if (_operator != null && operators.Contains(_operator.ToString()))
                {
                    operand1 = DisplayResult(operand1, operand2, _operator);
                }
                operand2 = "0";
            }
            return operand1;   
        }

        /*Clear the console screen*/
        private void ClearConsole()
        {
            operand1 = "0";
            operand2 = "0";
            hasProcesed = true;
        }

        /*
         _HandleDigit takes input from user and form the number.
         First it form operand1 and set flag hasProssed false
         after it will form operand2.
        */
        private void _HandleDigit(char key)
        {
            if(hasProcesed)
            {
                if(IsValidDigit(operand1, key))                     
                    operand1 += key;
            }
            else
            {
                if(IsValidDigit(operand2, key))
                    operand2 += key;
            }
        }

        /*
         ActionOnOperator takes input and set to the _operator 
         if _operator is already set then calculate the result
        */
        private void ActionOnOperator(char key)
        {
            if(_operator == null)
                _operator = key;
            if(hasProcesed)
            {
                hasProcesed = false;
            }
            else
            {
                operand1 = DisplayResult(operand1, operand2, _operator);
                operand2 = "0";
                if(_operator != null) _operator = key;
            }
        }

        /* Calculate the final output */
        private string DisplayResult(string operand1, string operand2, char? @operator)
        {
            return CalculatorOpearationHelper.CalculateResult(operand1, operand2, @operator);
        }

        /* ToggleSign function toggle the sign of console output */
        private void ToggleSign(char key)
        {
            if(hasProcesed)
            {
                operand1 = $"{(Double.Parse(operand1) * -1)}";
            }
            else
            {
                operand2 = $"{(Double.Parse(operand2) * -1)}";
            }
        }


        /* Check given number is valid or not */
        private bool IsValidDigit(string number, char key)
        {
            if(number.Contains(".") && key == '.')  
                return false; 
            else if(number.Equals("0") && key == '0')
                return false;
            else return true;
        }
    }
}