using System;

/// <summary>
/// Summary description for Labyrinth
/// </summary>
public class Labyrinth
{
	public bool HasExit(int[,] labyrinth, int startI, int startJ)
	{
		if (labyrinth[startI, startJ] == 1)
		{
			Console.WriteLine("Вы попали в стену.");
			return false;
		}
		else if (labyrinth[startI,startJ] ==2)
		{
			Console.WriteLine("Вход является выходом.");
			return true;
		}

		var stack = new Stack<Tuple>
		
	}
}
