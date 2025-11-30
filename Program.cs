using System;
using System.Diagnostics;

// class Program
// {
//     static int FindMissingNumber(int[] nums, int n)
//     {
//         for (int i = 0; i <= n; i++)
//         {
//             bool found = false;
//             for (int j = 0; j < nums.Length; j++)
//             {
//                 if (nums[j] == i)
//                 {
//                     found = true;
//                     break;
//                 }
//             }
//             if (!found) return i;
//         }
//         return -1;
//     }
//
//     static void Main()
//     {
//         int n = 5;
//         int[] nums = { 0, 1, 2, 3, 5 };
//         Stopwatch sw = Stopwatch.StartNew();
//         int missing = FindMissingNumber(nums, n);
//         sw.Stop();
//         Console.WriteLine("Отсутствующее число: " + missing);
//         Console.WriteLine("Время: " + sw.ElapsedTicks + " тиков");
//     }
// }

//Новый вариант

class Program2
{
    static int FindMissingNumber(int[] numbers, int n)
    {
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            actualSum += numbers[i];
        }

        return expectedSum - actualSum;
    }

    static void Main()
    {
        int n = 5;
        int[] numbers = { 0, 1, 2, 3, 5 };

        var sw = Stopwatch.StartNew();
        int missing = FindMissingNumber(numbers, n);
        sw.Stop();

        Console.WriteLine("Отсутствующее число: " + missing);
        Console.WriteLine("Время: " + sw.ElapsedTicks + " тиков");
    }
}