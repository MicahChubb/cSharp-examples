using System;

public class Program
{
	public static void Main()
	{
		string[, ] letters = {{"_","_","_"},{"_","_","_"},{"_","_","_"}};
		while(true){
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(letters[i, j]);
				}

				Console.WriteLine();
			}
			Console.WriteLine("First dim: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Second dim: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			letters[num1, num2] = "X";
		}
	}
}
