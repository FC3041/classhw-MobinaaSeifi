namespace part7
{
    class Program
    {
        static double Pow(double x, double y)
        {
            double r = 1;
            for(int i=0; i<y; i++)
                r*= x;
            return r;
        }
        static double factorial(double n)
        {
                if(n==0)
                    return 1;
                if(n==1)
                    return 1;
                else
                    return n*factorial(n-1);
        }
        static double exp(double x, double precision)
        {
            double y = 0;
            double z = 0;
            while(Pow(x,z)/factorial(z)>precision)
            {
                y += Pow(x,z)/factorial(z);
                z+=1;
            }
            return y;
        }
        static double ln(double x, double precision)
        {
            double low = 0;
            double high = x;
            double mid;

            while (high - low > precision)
            {
                mid = (low + high) / 2;
                if (exp(mid,0.000001) < x)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }

            return (low + high) / 2;
        }

            
            static void Main(string[] args)
        {
            Console.WriteLine(ln(3,0.000001));
        }

        }
    }

