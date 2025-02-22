namespace part3;

class Factorial
{
    static long Fact(int n)
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
        Console.WriteLine(Fact(20));
    }
}
