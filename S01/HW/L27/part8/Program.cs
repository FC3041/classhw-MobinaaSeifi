﻿namespace part8;

class Program
{
    static bool Is_leap_year(int n)
    {
        if((n%400 == 0) || ((n%4 == 0) & (n%100 != 0)))
            return true;
        else
            return false;
    }
    static int days_in_month(int monthnumber, int year)
    {
        if(monthnumber==1)
            return 31;
        else if(monthnumber==3)
            return 31;
        else if(monthnumber==5)
            return 31;
        else if(monthnumber==6)
            return 30;
        else if(monthnumber==7)
            return 31;
        else if(monthnumber==8)
            return 31;
        else if(monthnumber==10)
            return 31;
        else if(monthnumber==12)
            return 31;
        else if(monthnumber==4)
            return 30;
        else if(monthnumber==9)
            return 30;
        else if(monthnumber==11)
            return 30;
        else
        {
            if(Is_leap_year(year))
                return 29;
            else
                return 28;
            
        }
    }
    static int days_before_date(int year, int monthnumber, int daynumber)
    {
        int x = 0;
        for(int i=1; i<monthnumber; i++)
            x+= days_in_month(i,year);
        x += daynumber-1;
        return x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(days_before_date(2014,1,1));
        Console.WriteLine(days_before_date(2014,12,31));
    }
}
