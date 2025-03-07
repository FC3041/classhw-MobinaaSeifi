namespace part1;

class Program
{
    static double factorial(double n)
        {
            if(n==0)
                return 1;
            if(n==1)
                return 1;
            else
                return n*factorial(n-1);
        }
    
    static double eulers_constant(double precision)
    {
        double y = 0;
        double z = 0;
        while(1/factorial(z)>precision)
        {
            y += 1/factorial(z);
            z+=1;
        }
        return y;
    
    }
    static void Main(string[] args)
    {
        Console.WriteLine(eulers_constant(0.000001));
    }
}
