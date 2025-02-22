namespace part3;

class Prime
{
    static bool Is_divisable(int a, int b)
    {
        if((a%b==0)&&(b!=0))
            return true;
        else
            return false;

    }
    static void Main(string[] args)
    {
        Console.WriteLine(Is_divisable(12,3));
    }
}
