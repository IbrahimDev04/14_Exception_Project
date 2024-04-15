using Indexer.Models;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test[0] = "Ibrahim";
            test[2] = "Eli";
            test[3] = "El";
            test[6] = "Eli";

            for (int i = 0;i<test.Lenght;i++)
            {
                Console.WriteLine(test[i]);
            }
        }
    }
}
