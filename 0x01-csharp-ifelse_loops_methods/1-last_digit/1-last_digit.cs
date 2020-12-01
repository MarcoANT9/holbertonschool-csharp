using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last = number % 10;
        if (last > 5)
            Console.WriteLine($"The last digit of {number} is {last} ant is greater than 5");
        else if (last == 0)
            Console.WriteLine($"The last digit of {number} is {last} ant is 0");
        else
            Console.WriteLine($"The last digit of {number} is {last} ant is less than 6 and not 0");
    }
}
