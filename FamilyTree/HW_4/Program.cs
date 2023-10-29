using System.Globalization;

namespace HW_4;

internal class Program
{
    static void Main(string[] args)
    {
        
        //List<int> nums = new List<int>();
        //nums.Add(2);
        //nums.Add(2);
            
        //nums.Add(2);
        //nums.Add(8);
        //nums.Add(5);
        //nums.Add(6);
        //nums.Add(7);
        //nums.Add(8);
        //nums.Add(9);
        List<int> nums = MyArrays.GenerateRandomIntArray(10, 1, 10);     

        Console.WriteLine("initial Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        //nums.Sort();

        Console.WriteLine("sorted Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        int targetSum = 10;

        List<int> wantedNums = MyArrays.FindNumsOfTargetSum(targetSum, nums);


        if (wantedNums != null)

        {
            Console.WriteLine($"Числа, сумма которых равна {targetSum}:");
            Console.WriteLine($"Число 1: {wantedNums[0]}");
            Console.WriteLine($"Число 2: {wantedNums[1]}");
            Console.WriteLine($"Число 3: {wantedNums[2]}");
        }

        else
        {
            Console.WriteLine($"В массиве нет трех чисел, сумма которых равна {targetSum}.");
        }




    }
}