namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int num = rng.Next(9999);
            Console.WriteLine(num);
            PrintDigits(num);
        }

        static void PrintDigits(int num)
        {
            if (num / 10 > 0)
            {
                PrintDigits(num / 10);
            }
            Console.Write($"{num % 10} ");
        }
    }
}
