namespace part3A;

class Program
{
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
            if(abs(a-b)<closeness*a)
                return true;
            else
                return false;
        }
        else
        {
            if(abs(a-b)<closeness*b)
                return true;
            else
                return false;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(near(2,2.01,0.01));
    }
}
