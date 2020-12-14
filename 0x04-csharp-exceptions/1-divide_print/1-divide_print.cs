using System;

class Int
{
    public static void divide(int a, int b)
    {
        int quot = 0;
        try
        {
            quot = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {quot}");
        }
    }
}
