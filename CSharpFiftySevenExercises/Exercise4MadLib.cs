using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise4MadLib
    {
        public void MadLibCreate()
        {
            Console.WriteLine("Enter a noun: ");
            string nounInput = Console.ReadLine();
            Console.WriteLine("Enter a verb: ");
            string verbInput = Console.ReadLine();
            Console.WriteLine("Enter an adjective: ");
            string adjectiveInput = Console.ReadLine();
            Console.WriteLine("Enter a adverb: ");
            string adverbInput = Console.ReadLine();

            Console.WriteLine($"Do you {verbInput} your {adjectiveInput} {nounInput} {adverbInput}");
            Console.WriteLine("Now that is funny!");
        }
    }
}
