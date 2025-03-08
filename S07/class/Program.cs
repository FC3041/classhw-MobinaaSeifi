namespace class;

class Program
{
    static void Main(string[] args)
    {
        for(int i=0; i<1000000;i++)
        {
            int nums = new int [1000*1000];
            Thread.Sleep(1);
        }

        Console.WriteLine("Hello, World!");
    }
}
