using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hyello! I hope you're ready to math today! Enter in comma separated numbers to multiply:");
            var input = Console.ReadLine();
            var numbers = new string[input.Length];
            var sum = 0;
            if (input.Contains(" "))
            {
                numbers = input.Split(" ");
            }
            else if (input.Contains(", "))
            {
                numbers = input.Split(", ");
            }
            else
            {
                numbers = input.Split(",");
            }
            foreach (var num in numbers)
            {
                sum *= int.Parse($"{num}");
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
