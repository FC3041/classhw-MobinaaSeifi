namespace part5;

class Program
{
    static double Pow(double x, double y)
    {
        double r = 1;
        for(int i=0; i<y; i++)
            r*= x;
        return r;
    }
    static double square_root(double x,double precision)
    {
        if(x<0)
            throw new ArgumentException("n must be non-negative.");
        double low = 0;
        double up = x;
        while(up - low > precision)
    {
        double mid = (low + up)/2;
        if(Pow(mid,2)<x)
            low = mid;
        else
            up = mid;
    }
    return (low+up)/2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(square_root(2,0.000001));
    }
}
