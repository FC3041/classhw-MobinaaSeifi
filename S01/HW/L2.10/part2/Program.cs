namespace part2;

class Program
{
    static double Pow(double x, double y)
    {
        double r = 1;
        for(int i=0; i<y; i++)
            r*= x;
        return r;
    }
    static double factorial(double n)
        {
            if(n==0)
                return 1;
            if(n==1)
                return 1;
            else
                return n*factorial(n-1);
        }
    
    static double exp(int x, double precision)
    {
        double y = 0;
        double z = 0;
        while(Pow(x,z)/factorial(z)>precision)
        {
            y += Pow(x,z)/factorial(z);
            z+=1;
        }
        return y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(exp(2, 0.000001));
        Console.WriteLine(exp(1, 0.000001));

    }
}
