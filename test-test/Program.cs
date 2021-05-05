using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SentenceParserApp
{

    /*

    In C#, write a program that 
        parses a sentence and 
        replaces each word with the following: 
            first letter, 
            number of distinct characters between first and last character, 
            and last letter. 
        For example, Smooth would become S3h. 
        Words are 
            separated by spaces or non-alphabetic characters and 
            these separators should be maintained in their original form and location in the answer.

    The code must be syntactically correct and build in visual studio, either as a console or winforms application.

    Please paste these instructions at the top of your completed assignment.

    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can exit by typing 0");

            var parser = new SentenceParser();

            while (true) 
            {
                Console.WriteLine("Enter input:"); // Prompt
                string sentence = Console.ReadLine(); // Get string from user
                if (sentence == "0") // Check string
                    break;

                Console.WriteLine(parser.Parse(sentence));

                ////**ORIGINAL FUNCTIONAL IMPLEMENTATION
                //var wordsRegex      = new Regex(@"^[a-zA-Z]+$");
                //var wordsArray      = Regex.Split(sentence, $"([^a-zA-Z])"); //-> 
                
                //var newWordArray    = wordsArray.Select(x => 
                //{
                //    if (wordsRegex.IsMatch(x))
                //    {
                //        var length          = x.Length;
                //        var innerWordCount  = (length <= 2) ? 0 : x.Substring(1, length - 2)?.Distinct().Count();
                //        return $"{x[0]}{innerWordCount }{x[length - 1]}";
                //    }
                //    return x;
                //});

                //var newSentence = string.Join("", newWordArray);
                //Console.WriteLine($"{newSentence}");
            }
        }
    }
}
