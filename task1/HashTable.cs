using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public sealed class HashTable
    {
        public ListNode<uint>[] values;

        public HashTable(byte N)
        {
            if (N == 0)
            {
                throw new ArgumentException("A Delimeter must be bigger than zero");
            }
            values = new ListNode<uint>[N];
        }

        private byte N { get { return (byte)values.Length; } }

        public void Insert(uint newValue)
        {
            long position = newValue % N;

            if (values[position] == null)
            {
                values[position] = new ListNode<uint>(newValue);
            }
            else
            {
                values[position].Insert(newValue);
            }

            return;
        }
    }