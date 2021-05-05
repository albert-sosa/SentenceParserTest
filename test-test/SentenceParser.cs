using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SentenceParserApp
{
    public class SentenceParser
    {
        private Regex wordRegex;

        public SentenceParser()
        {
            wordRegex = new Regex(@"^[a-zA-Z]+$");
        }

        private string[] GetSentenceArray(string x) => Regex.Split(x, $"([^a-zA-Z])");

        //-> is public only for testing purposes
        private string ParseWord(string word)
        {
            if (wordRegex.IsMatch(word))
            {
                var length          = word.Length;
                var innerWordCount  = (length <= 2) ? 0 : word.Substring(1, length - 2)?.Distinct().Count();
                return $"{word[0]}{innerWordCount }{word[length - 1]}";
            }
            return word;
        }

        public string Parse(string sentence = "")
        {
            var wordsArray      = GetSentenceArray(sentence ?? "");
            var newWordArray    = wordsArray?.Select(x => ParseWord(x));

            return string.Join("", newWordArray);
        }
    }
}
