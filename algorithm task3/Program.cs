namespace algorithm_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded:");
            int number = Convert.ToInt32(Console.ReadLine());
            int new_number = 4000000 + 10 * number + 2;
            Console.WriteLine(new_number);
        }
    }
}