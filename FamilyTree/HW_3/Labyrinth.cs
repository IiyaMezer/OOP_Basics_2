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
    /// <param name="l">исследуемый лабиринт</param>
    /// <param name="startI">стартовая строка</param>
    /// <param name="startJ">стартовый столбец</param>
    /// <returns>true/false</returns>
    public bool HasExit(int[,] l, int startI, int startJ)
    {
        if (l[startI, startJ] == 1)
        {
            Console.WriteLine("Вы попали в стену.");
            return false;
        }
        else if (l[startI, startJ] == 2)
        {

            Console.WriteLine("Вход является выходом.");
            return true;
        }

        var stack = new Stack<Tuple<int, int>>();
        stack.Push(new(startI, startJ));

        while (stack.Count > 0)
        {
            var temp = stack.Pop();

            if (l[temp.Item1, temp.Item2] == 2)
            {
                Console.WriteLine("Found!");
                return true;
            }
            l[temp.Item1, temp.Item2] = 1;

            //TODO  разобратьлся с Out of bounds 

            if (temp.Item2 >= 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 - 1)); //up

            if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 + 1)); //down

            if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 - 1, temp.Item2)); //left

            if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 + 1, temp.Item2)); //rigth
        }

        return false;
    }
}
