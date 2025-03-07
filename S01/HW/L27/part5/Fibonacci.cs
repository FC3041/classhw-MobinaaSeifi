namespace part5;

class Fibonacci
{
    static int fibonacci(int n)
    {
        if(n==1 || n==2)
            return 1;
        int a = 1;
        int b = 1;
        int c = 0;
        for(int i=1; i<=n; i++)
        {
            a = b;
            b = c;
            c = a+b;
        }
        return c;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(fibonacci(9));
    }
}

//  1   1   2   3   5   8   13  21  34