namespace part5;

class Months
{
    static string[] month = new string[]
    {
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December"
    };
    static void Calender(int month_number)
    {
        for(int i=1; i<=12; i++)
        {
            if(i==month_number)
            {
                Console.WriteLine(month[i-1]);
            }
        }
    }
    
    static void Main(string[] args)
    {
        Calender(2);
    }
}
