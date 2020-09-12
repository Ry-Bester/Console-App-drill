using System;
using System.Collections.Concurrent;

public class Class1
{
	static void Main(string[] args)
	{
        try
        {
			Console.WriteLine("Pick a number.");
			int numberOne = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pick a second number.");
			int numberTwo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("dividing the two");
			int numberThree = numberOne / numberTwo;
			Console.WriteLine(numberOne + " divided by" + numberTwo + " equals " + numberThree);
			Console.ReadLine();
		}
		catch (FormatException ex)
        {
			Console.WriteLine(ex.Message);
			
        }
		Console.ReadLine()
	}

}
