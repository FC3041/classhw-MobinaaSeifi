public interface ICar
{
    // public double a();
    public double v();
    public double x();
    // public double t();

}
class Cars : ICar
{
    public double a;
    // public double v;
    // public double x;
    public double t;
    public double v0;

    public Cars(double aa, double  tt, double vv0)
    {
        a = aa;
        t = tt;
        v0 = vv0;
    }
    public double v()
    {
        return a*t + v0;
    }

    public double x()
    {
        return 0.5*a*t*t + v0*t;
    }
    
}