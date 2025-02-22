namespace part3;

class MyAsciiArg
{
    static void Print_cone(int basesize)
    {
        for(int s=0; s<(basesize/2); s++)
        {
            Console.Write(" ");
        }
        Console.Write("^");
        Console.Write("\n");
        for(int i=1; i<=basesize/2; i++)
        {
            for(int s=0; s<=(basesize/2)-i-1; s++)
            {
            Console.Write(" ");
            }
            for(int j=1; j<=i; j++)
            {
                Console.Write("/");
            }
            Console.Write("|");
            for(int j=1; j<=i; j++)
            {
                Console.Write("\\");
            }
            Console.Write("\n");

        }
        Console.Write("\n");
    }

    static void Main(string[] args)
    {
        Print_cone(7);
    }
}
