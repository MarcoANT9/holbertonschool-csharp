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
        int pos = 1;

        foreach (string element in aStack)
        {
            if (element == search)
            {
                exist = 1;
                break;
            }
            pos += 1;
        }
        if (exist == 0)
            Console.WriteLine("False");
        else
        {
            Console.WriteLine("True");
            while (pos > 0)
            {
                aStack.Pop();
                pos--;
            }
        }
        aStack.Push(newItem);
        return (aStack);
    }
}

