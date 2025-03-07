

#include <iostream>
#include<windows.h>
using namespace std;
class keeptime
{
public:
    unsigned long long l1, l2, diff;

    void amaliat()
    {
        int i = 0;
        int d = 5;
        while (i < 1000000000)
        {
            i++;
            d++;
            int p = i * d;
        }
        
    }

    keeptime()
    {
        l1 = GetTickCount64();
        cout <<  l1 << endl;

        amaliat();

        l2 = GetTickCount64();
        cout << l2 << endl;

        diff = l2 - l1;
    }

    ~keeptime()
    {
        cout << diff << endl;
    }




};

int main()
{
    keeptime kt;
    return 0;
}




