using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise3PrintQuotes
    {
        public void QuotePrint()
        {
            Console.WriteLine("What is the quote?: ");
            string quoteInput = Console.ReadLine();
            Console.WriteLine("Who said it?: ");
            string whoInput = Console.ReadLine();

            Console.WriteLine($"{whoInput} says \"{quoteInput}\"");
        }
    }
}
