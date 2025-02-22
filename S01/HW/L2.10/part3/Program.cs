namespace part3;

class Program
{
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
    static void Main(string[] args)
    {
        Console.WriteLine(exp2(1, .000001));
        Console.WriteLine(exp2(2, .000001));
    }
}
