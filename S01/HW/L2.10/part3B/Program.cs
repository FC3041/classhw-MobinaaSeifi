using System.Threading.Tasks;

namespace part3B;

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

    static double exp2(int x, double precision)
    {
        double n = 1;
        double y = 1;
        double sum = 1;
        while(x/n>precision)
        {
            y*=x/n;
            sum+=y;
            n++;
        }
        return sum;


    }
    static double abs(double a)
    {
        if(a>=0)
            return a;
        else
            return -a;
    }

    static bool near(double a, double b, double closeness)
    {
        if(a>b)
        {
            if(abs(a-b)<closeness*abs(a))
                return true;
            else
                return false;
        }
        else
        {
            if(abs(a-b)<closeness*abs(b))
                return true;
            else
                return false;
        }
    }
    static void Main(string[] args)
    {
        double a = exp(2, 0.000001);
        double b = exp2(2, 0.000001);

        Console.WriteLine(near(a, b , 0.01));
    }
}
