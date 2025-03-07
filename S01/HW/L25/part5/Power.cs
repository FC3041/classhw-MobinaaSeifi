namespace part5;

class Power
{
    static int Pow(int x, int y)
    {
        int r = 1;
        for(int i=0; i<y; i++)
            r*= x;
        return r;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Pow(3,5));
    }
}
