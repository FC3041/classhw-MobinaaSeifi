namespace part_3;

class Program
{
    static void print_left_triangle(int trianglebase, char x)
    {
        for(int n=0; n<=trianglebase; n++)
        {
            for(int j=trianglebase; j>=n; j--)
            {
                Console.Write(' ');
            }
            for(int i=0; i<n; i++)
            {
                Console.Write(x);
            }

        Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        print_left_triangle(20,'*');
    }
}
