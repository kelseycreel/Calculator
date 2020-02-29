using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication
            Console.WriteLine("I hope you're ready to math today! Type in * to multiply, ^ to square, / to divide, and + to add the comma separated numbers (NO SPACES): *1,2,3");
            var input = Console.ReadLine();
            var inputSymbol = input[0];
            var inputToUse = input.Remove(0, 1);
            string[] numbers = inputToUse.Split(',');
            var sum = 1;
            if (input.Contains('*'))
            { 

                foreach (var num in numbers)
                {
                    sum *= int.Parse($"{num}");
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
            // Squares
            else if (input.Contains('^'))
            {
                var output = "";
                foreach (var num in numbers)
                {
                    var newNum = int.Parse($"{num}");
                    sum = newNum * newNum;
                    output += ($"{sum.ToString()},");
                }
                Console.WriteLine(output);
                Console.ReadKey();
            }
            // Add
            else if (input.Contains('+'))
            {
                foreach (var num in numbers)
                {
                    sum += int.Parse($"{num}");
                    sum = sum - 1;
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
            // Divide
            else if (input.Contains('/'))
            {
                foreach (var num in numbers)
                {
                    if (input.Contains('0'))
                        Console.WriteLine("Error: Cannot divide by zero");
                    else
                    {
                        sum /= int.Parse($"{num}");
                    }
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oops! Please try again!");
            }
        }
    }
}
