using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise1TipCalc
    {
        public void PromptAndDisplay()
        {
            int bill, tip, result;
            //Prompt
            Console.WriteLine("Type in the bill: ");
            bill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the tip: ");
            tip = Convert.ToInt32(Console.ReadLine());
            result = Calculate(bill, tip);

            //Display
            Console.WriteLine($"The bill is: {bill}");
            Console.WriteLine($"The tip is: {tip}");
            Console.WriteLine($"The total amount is: {result}");
        }

        public int Calculate(int bill, int tip)
        {
            int result = bill * (tip / 100);
            return result;
        }
    }
}
