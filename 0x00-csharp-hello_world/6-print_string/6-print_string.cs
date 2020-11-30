using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine($"{str:s}{str:s}{str:s}\n" + str.Substring(0,9) + "\n");
        }
}
