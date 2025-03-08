using System.Runtime.Intrinsics.Arm;

namespace s8con;

public class Program
{
    public static int add(int a, int b)
    {
        return a+b;
    }

    static void reverse(string s, out string srev)
    {
        srev = "";
        foreach(char c in s)
        {
            srev = c+ srev;
        }
    }

    // static void reverse_sentence(string s, out string senrev)
    // {

    // }
    public static void preper_user(string s, out string sout)
    {
        sout = "user: " + s;
    }
    static void Main(string[] args)
    {
        string name = "ali";
        out string srev ;
        reverse(name, out srev);
        System.Console.WriteLine(srev);    
    }
    static void Main2(string[] args)
    {
        int sum = 0;
        while(true)
        {
            System.Console.WriteLine("Nums?");
            string s = Console.ReadLine();
            if(string.IsNullOrEmpty(s))
                break;

            sum += int.Parse(s);
            // Console.WriteLine("Hello, Wo rld!");
            int n;
            if(! int.TryParse(s, out n))
            {
                System.Console.WriteLine( "wrong, try again");
                continue;
            }

        }
    }
}
