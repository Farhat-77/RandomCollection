using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCollection
{
    public class ArrayList
    {
        public int Count { get; private set; }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random random = new Random();
            Console.WriteLine("Initial list: ");
            int average = 0;
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-20, 20));
                average += (int)list[i];
                Console.Write(list[i] + " ");
            }
            average /= list.Count;
            Console.WriteLine("\n\nAverage:\n" + average);
            Console.WriteLine("\nResult: ");
            foreach (int item in list)
            {
                if (item > average)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadLine();
        }

        private void Add(int v)
        {
            throw new NotImplementedException();
        }
    }
}
