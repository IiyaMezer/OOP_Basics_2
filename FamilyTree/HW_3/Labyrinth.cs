using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3;

public class Labyrinth
{

    /// <summary>
    /// Проверка возможности выйти из лабиринта
    /// </summary>
    /// <param name="labyrinth">исследуемый лабиринт</param>
    /// <param name="startI">стартовый столбец</param>
    /// <param name="startJ">стартовая строка</param>
    /// <returns>true/false</returns>
    public bool HasExit(int[,] labyrinth, int startI, int startJ)
    {
        if (labyrinth[startI, startJ] == 1)
        {
            Console.WriteLine("Вы попали в стену.");
            return false;
        }
        else if (labyrinth[startI, startJ] == 2)
        {

            Console.WriteLine("Вход является выходом.");
            return true;
        }

        var stack = new Stack<Tuple<int, int>>();
        stack.Push(new(startI, startJ));

        while (stack.Count > 0)
        {
            var temp = stack.Pop();

            if (labyrinth[temp.Item1, temp.Item2] == 2)
            {
                Console.WriteLine("Found!");
                return true;
            }
            labyrinth[temp.Item1, temp.Item2] = 1;

            if (temp.Item2 >= 0 && labyrinth[temp.Item1, temp.Item2 - 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 - 1)); //up

            if (temp.Item2 + 1 < labyrinth.GetLength(1) && labyrinth[temp.Item1, temp.Item2 + 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 + 1)); //down

            if (temp.Item1 >= 0 && labyrinth[temp.Item1 - 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 - 1, temp.Item2)); //left

            if (temp.Item1 + 1 < labyrinth.GetLength(0) && labyrinth[temp.Item1 + 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 + 1, temp.Item2)); //rigth
        }

        return false;
    }
}
