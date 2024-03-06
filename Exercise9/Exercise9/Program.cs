using System.Globalization;
using System.Transactions;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many collums ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine(" how many rows");
            int row = int.Parse(Console.ReadLine());

            for (int currRow = 1; currRow <= row; currRow++)
            {
                for (int j = 1; j <= width; j++)

                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }

            Console.Write("how many *");
            int maxAster = int.Parse(Console.ReadLine());

            for (int r = 1; r <= maxAster; r++)
            {

                for (int c = 1; c <= r; c++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }       
        }
    }
}
