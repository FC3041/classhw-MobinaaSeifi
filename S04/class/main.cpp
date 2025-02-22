#include<iostream>

#include<math.h>

using namespace std;

class Point
{
    double m_x;
    double m_y;

    double DistanceTo(Point p)
    {
        double x_diff = m_x - p.m_x;
        double y_diff = m_y - p.m_y;

        return sqrt(x_diff * x_diff + y_diff * y_diff);

    }

    void print_point()
    {
        cout << "x: " << m_x << "y: " << m_y <<endl;
    }
};


class Circle
{
    Point m_o;
    double m_r;

    //baraye constractor har do ta ravesh paain doroste

    // Circle(const Point& o, double r)
    // {
    //     m_o = o;
    //     m_r = r;
    // }

    Circle (const Point& o, double r): m_o(o),m_r(r){};

    Circle () {}   //ye constractor khali baraye inke object khaly beshe tarif kard

    double DistanceTo(Circle c)
    {
        return c.DistanceTo(c.m_o);
    }
    double DistanceTo(Point p)
    {
        // return p.DistanceTo(m_o);    ////chera error mide??????????
    }
    
    // int main()
    // {
    //     Point p1;
    //     Point p2(4,7);
    //     Point p3(1,5);
    //     Point p
    // }
    // .......
}
