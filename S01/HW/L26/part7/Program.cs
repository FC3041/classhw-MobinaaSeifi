namespace part7;

class Program
{
    static int Pow(int x, int y)
    {
        int r = 1;
        for(int i=0; i<y; i++)
            r*= x;
        return r;
    }
    static void Pythagorean_Triples(int n)
    {
        for(int a=1; a<n; a++)
        {
            for(int b = a; b<n; b++)
            {
                double c = Math.Sqrt(Pow(a,2) + Pow(b,2));
                int cInt = (int)Math.Round(c);
                    if (c == cInt && c < n)
                    Console.WriteLine($"{a},{b},{c}");
            }
        }
    }
    static void Main(string[] args)
    {
        Pythagorean_Triples(100);
    }
}
