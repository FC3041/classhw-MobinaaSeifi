namespace part2;

class CToF
{
    static double Ctof(double C)
    {
        double F = (C+32)*9/5;
        double RoundedC = Math.Round(F,2);
        return RoundedC;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Ctof(9));
    }
}
