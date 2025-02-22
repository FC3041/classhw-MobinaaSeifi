namespace part4;

class Program
{
    static void Print_cone(int basesize)
    {
        if(basesize%2==1)
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
        }
        
        }
    static void print_cones(int n)
    {
        for(int i=0; i<=n; i++)
        {
            Print_cone(i);
        }
    }
    static void Main(string[] args)
    {
        print_cones(9);
    }
}
