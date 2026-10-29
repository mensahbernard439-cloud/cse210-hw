using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // 1. Gather numbers until they type 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 2. Compute the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // 3. Compute the Average
        // We cast sum to a double so C# does decimal division instead of rounding down
        double average = (double)sum / numbers.Count;

        // 4. Find the Maximum (Largest number)
        int max = numbers[0]; // Assume the first item is the largest to start
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; // Update max if we find a bigger number
            }
        }

        // 5. Display the Results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
