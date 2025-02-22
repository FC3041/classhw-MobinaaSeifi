namespace part6;

class Quadratic
{
    static double Pow(double a, double b)
    {
        double r = 1;
        for(double i=0; i<b; i++)
            r*= a;
        return r;
    }
    static void Quadrat(double A,double B,double C)
    {
        double x = 0;
        double y;
        y = 0;
        y = (A*Pow(x,2) + B*x + C);

        
        double delta = Pow(B,2) - 4*A*C;
        if(delta>0)
        {
            double sqrtdelta = Math.Sqrt(delta);
            double x1 = (-B + sqrtdelta) / (2 * A);
            double x2 = (-B - sqrtdelta) / (2 * A);
            //Pow در محاسبه جذر دقیق نیست
            // double x1 = (double)(-B + Pow(delta,0.5))/(2*A);
            // double x2 = (double)(-B - Pow(delta,0.5))/(2*A);
            Console.WriteLine($"x1:{x1},x2:{x2}");
        }
        else if(delta<0)
        {
            Console.WriteLine("No answer in R");
        }

        else
        {
            x = (-B/(2*A));
            Console.WriteLine($"x: {x}");
        }

    }
    static void Main(string[] args)
    {
        Quadrat(1,1,-6);
    }
}
