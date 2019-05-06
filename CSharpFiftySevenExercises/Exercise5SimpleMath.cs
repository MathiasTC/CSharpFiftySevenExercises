using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise5SimpleMath
    {
        public void PromptAndShow()
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of numbers is: {CalculateSum(firstNum, secondNum)}");
            Console.WriteLine($"Difference of numbers is: {CalculateDifference(firstNum, secondNum)}");
            Console.WriteLine($"Product of numbers is: {CalculateProduct(firstNum, secondNum)}");
            Console.WriteLine($"Quotient of numbers is: {CalculateQuotient(firstNum, secondNum)}");
        }
        public int CalculateSum(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }
        public int CalculateDifference(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }
        public int CalculateProduct(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }
        public int CalculateQuotient(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            return result;
        }
    }
}
