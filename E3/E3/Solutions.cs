using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace E3;

//Q0--------------------------------------------------------------------------------------------------------------
public class Animal
{
    public Animal() { }
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}
public class Dog : Animal
{
    public Dog() { }
    public override string MakeSound()
    {
        return "Woof";
    }
}

//Q1----------------------------------------------------

public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }
}

public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

//Q2-----------------------------------------

public struct Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product other)
    {
        return this.Price.CompareTo(other.Price);
    }
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

public class Comparer<T> where T : IComparable<T>
{
    T a { get; set; }
    T b { get; set; }
    public Comparer(T aa, T bb)
    {
        a = aa;
        b = bb;
    }

    public T GetLarger()
    {
        if (Compare(a, b) > 0)
            return a;
        return b;


    }



    public int Compare(T a, T b)
    {
        return a.CompareTo(b);
    }

    // public int CompareTo(T a, T b)
    // {
        
    // }


}

//Q3--------------------------------------------------------
public class ResourceManager : IDisposable
{
    public bool IsDisposed { get; set; } = false;
    public ResourceManager() { }
    public static readonly ResourceManager Instance = new ResourceManager();

    void IDisposable.Dispose() { IsDisposed = true; }
}

//Q4,Q5-----------------------------------------------------------------------------------

public struct Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }
    // public Sale(string category, int amount)
    // {
    //     Category = category;
    //     Amount = amount;
    // }
}
public class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> l)
    {
        return l
                .Where(x => x % 2 == 0 && x > 5)
                .Select(x => x * 2)
                .ToList();
    }

    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> l)
    {
        return l
                .GroupBy(x => x.Category)

                .ToDictionary(g => g.Key,
                                g => g.Select(x => x.Amount)
                                .Sum());
                
    }
}



//Q6------------------------------------------------------------------------------
public class Money
{
    public int Amount { get; set; }
    public string Country { get; set; }

    public Money(int amount, string country)
    {
        Amount = amount;
        Country = country;
    }
    public static Money operator +(Money left, Money right)
    {
        return new Money(left.Amount + right.Amount, left.Country);
    }
    public static bool operator ==(Money left, Money right)
    {
        return left.Amount == right.Amount;
    }
    public static bool operator !=(Money left, Money right)
    {
        return !(left == right);
    }
    public override bool Equals(object obj)
    {
        if (obj is Money other)
            return this == other;
        return false;
    }
    // public override int GetHashCode()
    // {
    //     return HashCode.Combine()
    // }
}


//Q7----------------------------------------
// public class DelegateProblems
// {
//     // public static ProcessString
//     public delegate int StringOperation(string input);

    

//     public string ProcessString(string input, StringOperation operation)
//     {

//     }

// }


//Q13--------------------------
public class DataService
{
    public async Task<string> FetchDataAsync(string input)
    {
        return $"Data for {input}";
    }
}

//Q12-----------------------------------
public class SafeCounter
{
    public int Count { get; set; }
    private readonly object _lock = new object();
    public SafeCounter() { }
    public void Increment()
    {
        lock (_lock)
        {
            Count++;
        }
    }
    
}


//Q9-----------------------------------------------------
// public class Publisher
// {
//     // public event Action 
// }
// public class Subscriber
// {

// }


//