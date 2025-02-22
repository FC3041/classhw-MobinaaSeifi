namespace part6;

class Program
{
    static void Computechange(int x)
    {
        Console.WriteLine($"quarter: {(100-x)/25}");
        Console.WriteLine($"dime: {((100-x)%25)/10}");
        Console.WriteLine($"nickel: {((((100-x)%25)%10)/5)}");
        Console.WriteLine($"nickel: {((((100-x)%25)%10)%5)}");
    }    
static void Main(string[] args)
    {
        Computechange(8);
    }
}
