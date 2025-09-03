namespace S20;

public class MyTuple<T1, T2>
{
    public T1 Item1;
    public T2 Item2;
}
class Program
{
    static void Main(string[] args)
    {
        string name = "computer";
        string name2 = name.TitleCase();
        System.Console.WriteLine(name2);
        string text = "2hkk3khkjh4jkh5";
        System.Console.WriteLine(text.CountDigit());


        Tuple<string, int> t1 = new Tuple<string, int> ("Ali", 12);
        System.Console.WriteLine($"{t1.Item1}, {t1.Item2}");
    }

    static void Main1(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(2,6);
        ComplexNumber c2 = new ComplexNumber(1,9);
        ComplexNumber c3 = c1+c2;

        System.Console.WriteLine(c3[0]);
        System.Console.WriteLine(c3[true]);
        

        c3.printCN();

        double y = 6.8;
        // y = (double)c1;
        y = c1;
        
        // System.Console.WriteLine(name2);
    }
}
