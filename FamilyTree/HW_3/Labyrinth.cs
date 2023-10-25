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

       if (ExitSearch(l, startI, startJ)== true){
        Concole.WriteLine("Found!");
       }
       else {
        Console.WriteLine("There is no escape!");
       }      

        
    }
/// <summary>
/// Поиск выхода
/// </summary>
/// <param name="l">исследуемый лабиринт</param>
/// <param name="startI">стартовая строка</param>
/// <param name="startJ">стартовый столбец</param>
/// <returns>true/false</returns>
    private bool ExitSearch(int[,] l, int startI, int startJ)
    { 
        var stack = new Stack<Tuple<int, int>>();
        stack.Push(new(startI, startJ));

        while (stack.Count > 0)
        {
            var temp = stack.Pop();

            if (l[temp.Item1, temp.Item2] == 2)
            {                
                return true;
            }
            
            l[temp.Item1, temp.Item2] = 1;


            if (temp.Item2 > 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 - 1)); //up

            if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 + 1)); //down
            if (temp.Item1 > 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 - 1, temp.Item2)); //left

            if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 + 1, temp.Item2)); //rigth
        }


    }
    
    
    
    /// <summary>
    /// Количество возможных выходов
    /// </summary>
    /// <param name="l"></param>
    /// <param name="startI">стартовая строка</param>
    /// <param name="startJ">стартовый столбец</param>
    /// /// <returns>кол-в выходов</returns>
    public int ExitNums(int[,] l, int startI, int startJ)
    {

    }
}
