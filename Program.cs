namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDigits(1234);
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
