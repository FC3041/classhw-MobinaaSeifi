namespace part1;

class FToC
{
    static void ftoc(double F)
    {
        double C = (F-32)*5/9;
        double RoundedC =Math.Round(C,2);
        Console.WriteLine(RoundedC);
        //یا
        //double C = (F-32)*5/9;
        // string formattedC = C.ToString("F2");
        // Console.WriteLine(formattedC);

    }
    static void Main(string[] args)
    {
        ftoc(67);
    }
}





