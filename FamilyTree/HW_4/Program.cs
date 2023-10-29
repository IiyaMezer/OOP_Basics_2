using System.Globalization;

namespace HW_4;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = MyArrays.GenerateRandomIntArray(10, 1, 15);     

        Console.WriteLine("initial Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        nums.Sort();

        Console.WriteLine("sorted Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        int targetSum = 10;

        var result = (from num1 in nums

                      from num2 in nums

                      from num3 in nums

                      where num1 != num2 && num1 != num3 && num2 != num3 && num1 + num2 + num3 == targetSum

                      select new { Num1 = num1, Num2 = num2, Num3 = num3 }).FirstOrDefault();

        if (result != null)

        {

            Console.WriteLine("Числа, сумма которых равна {0}:", targetSum);

            Console.WriteLine("Число 1: {0}", result.Num1);

            Console.WriteLine("Число 2: {0}", result.Num2);

            Console.WriteLine("Число 3: {0}", result.Num3);

        }

        else

        {

            Console.WriteLine("В массиве нет трех чисел, сумма которых равна {0}.", targetSum);

        }




    }
}