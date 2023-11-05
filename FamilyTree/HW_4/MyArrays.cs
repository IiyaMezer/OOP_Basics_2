using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4;

public class MyArrays
{
    /// <summary>
    /// Генерация списка рандомных целых чисел
    /// </summary>
    /// <param name="length">длина списка</param>
    /// <param name="minValue">минимальное значения диапазона генерации</param>
    /// <param name="maxValue">максимальное значение диапазона генерации</param>
    /// <returns>список рандомных целых чисел заданной длины в установленном диапазоне</returns>
    public static List<int> GenerateRandomIntArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();

        List<int> randomArray = new List<int>();

        for (int i = 0; i < length; i++)
        {
            int number = random.Next(minValue, maxValue + 1);
            randomArray.Add(number);
            System.Threading.Thread.Sleep(50);
        }
        return randomArray;

    }
    /// <summary>
    /// Поиск трех элементов массиве, сумма которых равна заданному числу
    /// </summary>
    /// <param name="target">искомая сумма</param>
    /// <param name="nums">исходный массив</param>
    /// <returns>список из стрех искомых чисел</returns>
    public static List<int> FindNumsOfTargetSum(int target, List<int> nums)
    {
        List<int> result = new List<int>();
        
        var request = from num1 in nums
                      from num2 in nums
                      from num3 in nums
                      where num1 + num2 + num3 == target
                      select new { Num1 = num1, Num2 = num2, Num3 = num3 };

        if (request.Any())
        {
            foreach (var numbers in request)
            {
                result.Add(numbers.Num1);
                result.Add(numbers.Num2);
                result.Add(numbers.Num3);
            }
        }
        return result;
    }

    


}
