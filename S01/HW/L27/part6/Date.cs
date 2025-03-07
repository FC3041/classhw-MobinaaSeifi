namespace part6;

class Date
{
        static int days_in_month(int monthnumber)
    {
        if(monthnumber==1)
            return 31;
        if(monthnumber==3)
            return 31;
        if(monthnumber==5)
            return 31;
        if(monthnumber==6)
            return 30;
        if(monthnumber==7)
            return 31;
        if(monthnumber==8)
            return 31;
        if(monthnumber==10)
            return 31;
        if(monthnumber==12)
            return 31;
        if(monthnumber==4)
            return 30;
        if(monthnumber==9)
            return 30;
        if(monthnumber==11)
            return 30;
        return 28;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month(2));
    }
}
