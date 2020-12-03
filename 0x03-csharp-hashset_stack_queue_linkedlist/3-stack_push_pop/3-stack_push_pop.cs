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

        Console.WriteLine($"Stack contains: \"{search}\": {aStack.Contains(search)}");

        if (aStack.Contains(search))
        {
            while (aStack.Contains(search))
                aStack.Pop();
            if (newItem != null)
                aStack.Push(newItem);
        }
        return (aStack);
    }
}

