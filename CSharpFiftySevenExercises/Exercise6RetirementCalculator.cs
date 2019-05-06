using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise6RetirementCalculator
    {
        public void PromptAndDisplayRetireYear()
        {
            DateTime dt = new DateTime();
            Console.WriteLine("Your age: ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Retirement year: ");
            int retireInput = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int result = CalculateRetireYear(ageInput, retireInput);
            Console.WriteLine($"You have {result} until you can retire");
            Console.WriteLine($"It is {dt.Year} so you can retire in {dt.Year + result}");
        }

        public int CalculateRetireYear(int age, int retirementYear)
        {
            int yearsToRetire = retirementYear - age;
            return yearsToRetire;
        }
    }
}
