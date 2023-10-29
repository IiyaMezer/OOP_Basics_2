using System.Globalization;

namespace HW_4;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = MyArrays.GenerateRandomIntArray(10, 1, 15);     

        Console.WriteLine("initial Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        Array.Sort(nums);

        Console.WriteLine("sorted Array: \n" + string.Join(", ", nums.Select(x => x.ToString())));

        int targetSum = 10;

        var result = 


    }
}