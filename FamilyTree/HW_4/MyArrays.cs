using System;
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
        }
        return randomArray;

    }

    public static 



}
