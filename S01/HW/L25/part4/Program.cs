namespace part4;

class Program
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
        for(int n=1; n<=20; n++)
            Console.WriteLine(Fact(n));   
    }
}

