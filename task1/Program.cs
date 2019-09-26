using System;
using System.Collections.Generic;
using System.Linq;


    public class Program
    {
        static void WriteData(HashTable table, System.IO.TextWriter writer)
        {
            for (int i = 0; i < table.values.Count(); ++i)
            {
                writer.Write(i + ": ");

                if (table.values[i] != null)
                {
                    ListNode<uint> o = table.values[i];

                    while (o != null)
                    {
                        writer.Write(o.value + " ");
                        o = o.next;
                    }
                }
                writer.WriteLine();
            }
        }
        static void ReadData(System.IO.TextReader reader, out byte delimiter, out string[] numbers)
        {
            delimiter = Convert.ToByte(Console.ReadLine());
            numbers = Console.ReadLine().Split(' ');
        }

        public static void Main(string[] args)
        {
            byte divider;
            string[] numbers;
            ReadData(Console.In, out divider, out numbers);

            HashTable table = new HashTable(divider);

            if (numbers.Length > 0 && !numbers[0].Equals(""))
            {
                foreach (var number in numbers)
                {
                    table.Insert(Convert.ToUInt32(number));
                }
            }

            WriteData(table, Console.Out);

            return;
        }
    }