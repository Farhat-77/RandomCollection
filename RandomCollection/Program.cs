using System;

namespace RandomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Console.WriteLine("{0,4}", rnd.Next(1, 40));
            }
            Console.ReadKey();
        }
    }
   
}
