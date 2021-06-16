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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int size= arr.Count;
        int diagDiff=0,diag1=0,diag2=0;
        int i=0,j;
        while(i<size)
        {
            j=0;
            while(j<size)
            {
                if(i==j)
                {
                    diag1 += arr[i][j]; 
                }
                j++;
            }
            i++;

        }
        i=0;
        j = size-1;
        while(i<size)
        {
            
            while(j>=0)
            {
                diag2 += arr[i][j];
                break;
            }
            j-=1;
            i +=1;

        }
        diagDiff = diag1 - diag2;
        int fresult=Math.Abs(diagDiff); 
        return fresult;

    }

    private static int NewMethod(List<List<int>> arr, int diag1, int i, int j)
    {
        diag1 += arr[i][j];
        return diag1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine("{0}",result);

        //textWriter.WriteLine(result);

       // textWriter.Flush();
       // textWriter.Close();
    }
}
