namespace part2
{
class MoreAsciiiArt
{
    static void Print_left_triangle(int trianglebase)
    {
        for(int i=0; i<=trianglebase; i++)
        {
            if(i%2==0)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            else
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }
    }
    }
    static void Main(string[] args)
    {
        Print_left_triangle(4);
    }
}
}