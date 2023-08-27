using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var queue = new Queue<List<long>>();
        long max = long.MinValue;
        long min = long.MaxValue;

        for (int i = 0; i < arr.Count; i++)
        {
            var copy = arr.ConvertAll(i => (long)i);
            copy.RemoveAt(i);
            queue.Enqueue(copy);
        }

        while(queue.Count > 0)
        {
            var lst = queue.Dequeue();
            long s = lst.Sum();

            if (s > max)
                max = s;

            if (s < min)
                min = s;
        }

        Console.WriteLine($"{min} {max}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
