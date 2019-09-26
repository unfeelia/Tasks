using System;
using System.Linq;


    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            if (words == null || words.Length == 0 || words[0].Equals(""))
            {
                return;
            }

            var sortedWords = words
                .GroupBy(i => i)
                .Select(i => new { Word = i.Key, Count = i.Count() })
                .OrderBy(i => i.Count);

            int mostFrequency = sortedWords.Last().Count;

            int longestWordLength = sortedWords.Max(i => i.Word.Length);

            foreach(var t in sortedWords)
            {
                decimal x = (decimal)(10 * t.Count) / (decimal)mostFrequency;

                int points = (int)x + ((x - (int)x >= new decimal(0.5)) ? 1 : 0);

                string y = new string('.', points);

                Console.WriteLine(@"{0} {1}", t.Word.PadLeft(longestWordLength, '_'), y);
            }

        }
    }