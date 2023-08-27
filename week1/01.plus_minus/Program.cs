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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int cnt_minus = 0;
        int cnt_plus = 0;
        int cnt_zero = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                cnt_plus++;
            }
            else if (arr[i] < 0)
            {
                cnt_minus++;
            }
            else
            {
                cnt_zero++;
            }
        }

        double pos_prop = Math.Round((float)cnt_plus / arr.Count, 5);
        double neg_prop = Math.Round((float)cnt_minus / arr.Count, 5);
        double zero_prop = Math.Round((float)cnt_zero / arr.Count, 5);
        Console.WriteLine("{0:0.00000}", pos_prop);
        Console.WriteLine("{0:0.00000}", neg_prop);
        Console.WriteLine("{0:0.00000}", zero_prop);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
