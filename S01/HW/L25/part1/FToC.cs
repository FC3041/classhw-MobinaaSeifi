namespace part1;

class FToC
{
    static double Ftoc(double F)
    {
        double C = (F-32)*5/9;
        double RoundedC =Math.Round(C,2);
        return RoundedC;
        //یا
        //double C = (F-32)*5/9;
        // string formattedC = C.ToString("F2");
        // return formattedC;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Ftoc(67));
    }
}





