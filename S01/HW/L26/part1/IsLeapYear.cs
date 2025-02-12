namespace part1;

class IsLeapYear
{
    static bool Is_leap_year(int n)
    {
        if((n%400 == 0) || ((n%4 == 0) & (n%100 != 0)))
            return true;
        else
            return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Is_leap_year(1792));
        Console.WriteLine(Is_leap_year(1796));
        Console.WriteLine(Is_leap_year(1800));
        Console.WriteLine(Is_leap_year(1804));
        Console.WriteLine(Is_leap_year(1900));
        Console.WriteLine(Is_leap_year(1904));
        Console.WriteLine(Is_leap_year(2000));
        Console.WriteLine(Is_leap_year(2004));
    }
}
