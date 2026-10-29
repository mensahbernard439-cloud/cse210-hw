using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int percent = int.Parse(grade);

        string letter = "";
    
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit > 0 && lastDigit < 3)
        {
            sign = "-";
        }
             
        if (letter == "A")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter is {letter}{sign}");

        if (percent >= 90)
        {
            Console.WriteLine("Congratulations! You passed the course with flying colors!");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Awesome work! Hard work pays off—congratulations on passing!");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Great job! You passed the class!");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("You passed the class! You can do better");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep practicing and you'll get it next time.");
        }
    }
}