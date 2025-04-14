using System.Globalization;
using System.Numerics;

namespace S15;


class Program
{

    static T max<T>(T a, T b)
        where T: IComparable<T>
    {
        if(a.CompareTo(b)<0)
            return b;
        return a;
    }

    static void swap<T>( ref T a , ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }


    static T  sum<T>( ref T a, ref T b)
        where T: INumber<T>
    {
        return (a+b);
    }

     static T sum<T>(IEnumerable<T> items)
        where T: INumber<T>
     {
        T sum = T.Zero;
        foreach ( T i in items)
            sum = sum + i;
        return sum;
     }

    static T sum<T>(T[] nums)
        where T: INumber<T>
    {
        T sum = T.Zero;
        for(int i=0; i< nums.Length ; i++ )
            sum = sum + nums[i];
        return sum;
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
