using System.Diagnostics.CodeAnalysis;

namespace Array_average1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40, 50 }; 
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //double average = (double)sum / numbers.Length;
            //Console.WriteLine($"Average value: {average}");

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;
            Console.WriteLine($"Average value: {average}");
        }
    }
}
