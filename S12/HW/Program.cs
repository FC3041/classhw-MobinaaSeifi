namespace S12;

class Program
{
    static void Main(string[] args)
    {
        ICar[] machines = new ICar[]
        {
            new Cars(2,4,0),
            new Cars(4,3,0)
        };
 
        
        for(int i=0; i<machines.Length; i++)
        {
            System.Console.WriteLine(machines[i].v());
            System.Console.WriteLine(machines[i].x());
        }
        
    }
}
