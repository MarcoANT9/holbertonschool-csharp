using System;

class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            Console.WriteLine($"{a} / {b} = 0");
        }
    }
}
