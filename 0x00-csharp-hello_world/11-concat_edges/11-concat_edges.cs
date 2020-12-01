using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(49, 15) + " " + str.Substring(81, 11) + "in" + str.Substring(101, 3);
        Console.WriteLine(str);
        }
}
