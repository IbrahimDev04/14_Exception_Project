namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            foreach (var item in typeof(Test).GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    public class Test
    {
        private int[] Arr { get; }
        private int A { get; set; } = 5;
    }
}
