namespace part6;

class Program
{
    static double Pow(double x, double y)
    {
        double r = 1;
        for(int i=0; i<y; i++)
            r*= x;
        return r;
    }
    static double square_root(double x,int n, double precision)
    {
        if(x<0 && n%2==0)
            throw new ArgumentException("Cannot compute even root of a negative number.");
        double low = 0;
        double up = x;
        while(up - low > precision)
    {
        double mid = (low + up)/2;
        if(Pow(mid,n)<x)
            low = mid;
        else
            up = mid;
    }
    return (low+up)/2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(square_root(2,4,0.000001));
    }
}
