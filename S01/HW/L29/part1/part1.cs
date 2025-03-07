using System;
using System.Diagnostics;

class part1
{
    static int factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative.");

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            Debug.Assert(result == factorial(i - 1), "Loop invariant failed: result != factorial(i - 1)");
            result *= i;
        }
        if (result <= 0)
            throw new InvalidOperationException("Result must be positive.");
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(factorial(5));
    }
}