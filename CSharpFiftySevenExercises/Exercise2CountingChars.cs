using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiftySevenExercises
{
    class Exercise2CountingChars
    {
        public void CharCount()
        {
            Console.WriteLine("Type in a word");
            string word = Console.ReadLine();
            Console.WriteLine($"Your word is: {word}");
            Console.WriteLine($"{word} has {word.Length} characters");            
        }
    }
}
