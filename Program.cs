﻿using System.CodeDom.Compiler;
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
     
     Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.
     Note: This challenge introduces precision problems. The test cases are scaled to six decimal places.

Example

arr=[1,1,0,-1,-1]
There are n=5 elements, two positive, two negative and one zero. Their ratios are 2/5 = 0.400000, 2/5 = 0.400000 and 1/5 = 0.200000. Results are printed as:
0.400000
0.400000
0.200000

     */

    public static void plusMinus(List<int> arr)
    {
        double n = arr.Count;
        double plus = 0, minus = 0, zeros = 0;
        foreach (var i in arr)
        {
            if (i > 0)
                plus++;
            if (i < 0)
                minus++;
            if (i == 0)
                zeros++;
        }
        string nplus = (plus / n).ToString("0.000000");
        string nminus = (minus / n).ToString("0.000000");
        string nzeros = (zeros / n).ToString("0.000000"); ;
        System.Console.WriteLine("{0} ", nplus);
        System.Console.WriteLine("{0} ", nminus);
        System.Console.WriteLine("{0} ", nzeros);
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
