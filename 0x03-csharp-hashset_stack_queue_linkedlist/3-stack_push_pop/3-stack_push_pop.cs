using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int counter = aStack.Count;
        Console.WriteLine($"Number of items: {counter}");

        if (counter == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");

        Console.Write($"Stack contains: {search}: ");
        int exist = 0;

        foreach (string element in aStack)
        {
            if (element == search)
            {
                exist = 1;
                break;
            }
        }
        if (exist == 0)
            Console.WriteLine("False");
        else
        {
            Console.WriteLine("True");
            int i = 1;
            while (i != 0)
            {
                if (aStack.Peek() == search)
                {
                    aStack.Pop();
                    break;
                }
                else
                    aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return (aStack);
    }
}

