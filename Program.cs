using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    /*
    a = [1, 2, 3]
    b = [3, 2, 1]
    For elements *0*, Bob is awarded a point because a[0] .
    For the equal elements a[1] and b[1], no points are earned.
    Finally, for elements 2, a[2] > b[2] so Alice receives a point.
    The return array is [1, 1] with Alice's score first and Bob's second.
    */
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0;
        int bobScore = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                aliceScore++;
            }
            else if (a[i] < b[i])
            {
                bobScore++;
            }
        }

        return new List<int> { aliceScore, bobScore };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        using (TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true))
        {
            List<int> a = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> b = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(string.Join(" ", result));
        }
    }
}
