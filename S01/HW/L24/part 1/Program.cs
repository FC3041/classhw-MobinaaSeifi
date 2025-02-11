namespace part_1;
class Program
{
    
    static void print_left_triangle(int trianglebase)
    {
        for(int n=0; n<=trianglebase; n++)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write("*");
            }
        Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        print_left_triangle(3);
    }
}
