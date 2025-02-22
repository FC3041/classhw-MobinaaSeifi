#include<iostream>
#include<math.h>
//scanf ورودی گزفتن در c

using namespace std;

class Point
{   //farg tabe va method
    //tabe dakhele class mishi method oon class
    public:
        double x;
        double y;

    double point_distance(Point q, Point w)
    {
        double x_diff = q.x -w.x;
        double y_diff = q.y -w.y;
        return sqrt(x_diff*x_diff +y_diff*y_diff);
    }
};

// void print_point(Point p1)
// {
//     cout<< "a: " <<p1.x;
// }


// Point (Point* q)
// {
//     x = q->x;
//     y = q->y;
// }
// Point (Point& q)
// {
//     x = q.x;
//     y = q.y;
// }


int main()
{
    Point p1;
    p1.x = 4;
    p1.y = 6;
    cout<<p1.x<<endl;
    cout<<p1.y<<endl;

    //p1.point_distance(p);


    int a;
    // std::cin>>a;
    // std::cout<<"a:"<<a<<std::endl;
    cin>>a;
    cout<<"a:"<<a<<endl;
    return 0;

}

~Point()
{
    cout 
}