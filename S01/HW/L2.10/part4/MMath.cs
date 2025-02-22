namespace part4;


class MMath
{
    static double abs(double a)
    {
        if(a>=0)
            return a;
        else
            return -a;
    }
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
    static double d_to_r(double d)
        {
            double r = d * (Math.PI)/180;
            return r;
        }
    static double Sin(double x, double precision)
    {
        double radian = d_to_r(x);
        int i=1;
        double sin = 0;
        while(abs(Pow(radian,i)/factorial(i)) > precision)
        {
            if(i%2==0)
                i++;
            else if(i%4==1)
        {
                sin += Pow(radian,i)/factorial(i);
                i++;
        }
            else if(i%4==3)
        {
                sin -= Pow(radian,i)/factorial(i);
                i++;
        }
        }
        return sin;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Sin(0,0.0001));
        Console.WriteLine(Sin(45,0.0001));
        Console.WriteLine(Sin(90,0.0001));
        

    }
}
