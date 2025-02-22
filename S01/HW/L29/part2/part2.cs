namespace part2;

class part2
{
    static bool is_prime(int N)
    {
        if (N < 2)
            throw new ArgumentException("n must be greater than or equal to 2.");

        if(N==1)
            return false;
        if(N==2)
            return true;
        for(int i=2; i<N; i++)
        {
            if(N%i==0)
                return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(is_prime(13));
    }
}
