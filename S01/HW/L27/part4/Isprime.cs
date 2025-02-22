namespace part4;

class Isprime
{
    static bool is_prime(int N)
    {
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
