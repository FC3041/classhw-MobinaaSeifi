namespace part2;

class Fact
{
    static long Factorial(int n)
    {
        long f = 1;
        for(int i=1; i<=n; i++)
        {

            f = f*i;
        }
        return f;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(6));
    }
}
