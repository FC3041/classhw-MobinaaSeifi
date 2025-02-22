namespace part7;

class AverageOfSquares0
{
    static double Pow(double a, double b)
    {
        double r = 1;
        for(double i=0; i<b; i++)
            r*= a;
        return r;
    }
    static double Average_of_squares0(double n)
    {
        double sum = 0;
        for(int i=0; i<n; i++)
        {
            sum += Pow(i,2);
        }double av = sum/n;
        return av;
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Average_of_squares0(5));
    }
}
