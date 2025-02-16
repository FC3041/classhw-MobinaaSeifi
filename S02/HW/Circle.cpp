#include<iostream>
#include<math.h>
using namespace std;

// class Point
// {
//     public:
//         double x;
//         double y;

//     Point(double x1, double y1)
//     {
//         x = x1;
//         y = y1;
//     }

//     ~ Point ()
//     {

//     }
// };

class Circle
{
    public:
        double cx;
        double cy;
        double r;


    double P()
    {
        return 2 * M_PI * r;
    }

    double S()
    {
        return M_PI * r * r;
    }

    double c_distance(Circle w)
        {
            double cx_diff = cx - w.cx;
            double cy_diff = cy - w.cy;

            return sqrt(cx_diff*cx_diff + cy_diff*cy_diff);
        }
    
    double points_distance(double x, double y)
        {
            double x_diff = cx - x;
            double y_diff = cy - y;

            double d = sqrt(x_diff*x_diff + y_diff*y_diff);

            return sqrt(x_diff*x_diff + y_diff*y_diff);
        }
        
    void in_circle(double x, double y)
    {
        if(points_distance(x,y) < r)
            cout<<"The point is in the circle"<<endl;
        else
            cout<<"The point is not in the circle"<<endl;
    }

    void on_circle(double x, double y)
    {
        if(points_distance(x,y) == r)
            cout<<"The point is on the circle"<<endl;
        else
            cout<<"The point is not on the circle"<<endl;
    }

    void out_of_circle(double x, double y)
    {
        if(points_distance(x,y) > r)
            cout<<"The point is out of the the circle"<<endl;
        else
            cout<<"The point is not out of the the circle"<<endl;
    }



    Circle(double x0, double y0, double r0)
        {
            cx = x0;
            cy = y0;
            r = r0;
        }

    ~ Circle ()
        {

        }
    

};

int main()
{
    // Circle c1(0,0,0);
    //     c1.cx = 1;
    //     c1.cy = 1;
    //     c1.r = 2;

    // Circle c2(0,0,0);
    //     c2.cx = -1;
    //     c2.cy = 1;
    //     c2.r = 2;

    // double p1 = c1.P();
    // cout << p1<< endl;

    // double p2 = c2.P();
    // cout << p2<< endl;






    // double c_dist = c1.c_distance(c2);
    // cout << c_dist<< endl;

    double a;
    double b;
    double c;
    cin>>a;
    cin>>b;
    cin>>c;
    Circle c1(a,b,c);
    double d;
    double e;
    double f;
    cin>>d;
    cin>>e;
    cin>>f;
    Circle c2(d,e,f);



    cout <<"perimeter c1: "<<c1.P()<<endl;
    cout <<"perimeter c2: " <<c2.P()<<endl;

    cout<<"serface c1: "<< c1.S()<<endl;
    cout<< "serface c2: "<< c2.S()<<endl;

    cout<< "distance of c1 and c2: "<< c1.c_distance(c2)<< endl;


    double x;
    double y;
    cout<< "Write x of a point to check is the point in the circle or not: ",cin>>x;
    cout<< "Write y of a point to check is the point in the circle or not: ",cin>>y;
    cout<<"(circle c1)",c1.in_circle(x,y);
    cout<<"(circle c2)",c2.in_circle(x,y);
    c2.in_circle(x,y);
    
    cout<<"distance of the point whit c1: "<<c1.points_distance(x,y)<<endl;
    cout<<"distance of the point whit c2: "<<c2.points_distance(x,y)<<endl;

    double g;
    double h;
    cout<< "Write x of a point to check is the point on the circle or not: ",cin>>g;
    cout<< "Write y of a point to check is the point on the circle or not: ",cin>>h;
    cout<<"(circle c1)",c1.on_circle(g,h);
    cout<<"(circle c2)",c2.on_circle(g,h);

    cout<<"distance of the point whit c1: "<<c1.points_distance(g,h)<<endl;
    cout<<"distance of the point whit c2: "<<c2.points_distance(g,h)<<endl;

    double s;
    double t;
    cout<< "Write x of a point to check is the point out of the circle or not: ",cin>>s;
    cout<< "Write y of a point to check is the point out of the circle or not: ",cin>>t;
    cout<<"(circle c1)",c1.out_of_circle(s,t);
    cout<<"(circle c2)",c2.out_of_circle(s,t);

    cout<<"distance of the point whit c1: "<<c1.points_distance(s,t)<<endl;
    cout<<"distance of the point whit c2: "<<c2.points_distance(s,t)<<endl;


    
    


}
