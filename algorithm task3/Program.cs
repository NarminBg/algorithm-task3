namespace algorithm_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = (int)Math.Log10(number)+1;
           

            if (count==5)
            { 
                int new_number = (400000 + number) * 10 + 2;
                Console.WriteLine(new_number);
            }
            
            else
            {
                Console.WriteLine("Eded 5 reqemli olmalidir");
            }
            
        }
    }
}