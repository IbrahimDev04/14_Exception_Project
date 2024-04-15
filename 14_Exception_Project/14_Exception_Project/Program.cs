using _14_Exception_Project.Models;

namespace _14_Exception_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Adı girin:");
                string name = Console.ReadLine();

                try
                {
                    Person person = new Person(name);
                    Console.WriteLine(person.Name);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);
        }
    }
}
