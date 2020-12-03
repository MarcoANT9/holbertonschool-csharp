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

        Console.Write($"Stack contains: \"{search}\": ");

        if (aStack.Contains(search) == false)
            Console.WriteLine("False");
        else
        {
            Console.WriteLine("True");
            Stack<string> otherStack = new Stack<string>(aStack);
            foreach(string element in otherStack)
            {
                if (aStack.Pop() == search)
                    break;
            }
        } 
        aStack.Push(newItem);
        return (aStack);
    }
}

