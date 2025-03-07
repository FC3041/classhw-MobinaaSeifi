namespace L23;

class Rocketshiplong
{
    static void Head()
    {
        string head = "    ^    \n   /|\\   \n  //|\\\\  \n ///|\\\\\\ ";
        Console.WriteLine(head);
    }

    static void Line()
    {
        string line = "+-------+";
        Console.WriteLine(line);
    }

    static void Body()
    {
        string body = "+*******+";
        for(int i=0; i<6; i++)
            Console.WriteLine(body);
    }

    static void Main(string[] args)
    {
        Head();
        Line();
        for(int i=0; i<4; i++)
        {
            Body();
            Line();
        }
        Head();
    }
}
