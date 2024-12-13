using System;

namespace inlämningUppgift_._nivå1_._3
{
    class program
    {
        static void Main(string[] args)
        {
            int totalsum = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ange heltal:");
                int nummer = int.Parse(Console.ReadLine());
                totalsum += nummer;

            }
            Console.WriteLine("Summan av alla tal är:" + totalsum);


        }
    }
}