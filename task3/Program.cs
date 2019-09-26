using System;
using System.Collections.Generic;
using System.Linq;


    public class Program
    {
        static readonly LinkedList<int> s_numbers = new LinkedList<int>();

        public static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');

            if(tokens == null || tokens.Count() < 1)
            {
                Console.WriteLine(0);
                return;
            }

            foreach(var word in tokens)
            {
                int number;
                if (Int32.TryParse(word, out number))
                {
                    s_numbers.AddLast(number);
                }
                else
                {
                    int lastAddedNumber = s_numbers.Last();
                    s_numbers.RemoveLast();

                    int preLastAddedNumber = s_numbers.Last();
                    s_numbers.RemoveLast();

                    switch (word)
                    {
                        case "+":
                            s_numbers.AddLast(preLastAddedNumber + lastAddedNumber);
                            break;
                        case "-":
                            s_numbers.AddLast(preLastAddedNumber - lastAddedNumber);
                            break;
                        case "*":
                            s_numbers.AddLast(preLastAddedNumber * lastAddedNumber);
                            break;
                        case "/":
                            s_numbers.AddLast(preLastAddedNumber / lastAddedNumber);
                            break;
                    }
                }
            }

            Console.WriteLine(s_numbers.Last());
        }
    }