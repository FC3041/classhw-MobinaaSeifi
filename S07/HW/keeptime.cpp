

#include <iostream>
#include<windows.h>
using namespace std;
class keeptime
{
public:
    unsigned long long double l1, l2, diff;

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

        Sleep(3000);
        
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
        cout << diff << " Ticks"<< endl;
        cout << diff/1000 << " seconds" << endl;
    }




};

void delayOneSecond()
{
unsigned long long startTime = GetTickCount64();
Sleep(1000); //1000 miliseconds
unsigned long long endTime = GetTickCount64();
cout << "one second =" << endTime - startTime <<  "Ticks" <<  endl;

}

int main()
{
    delayOneSecond();
    keeptime kt;
    return 0;
}




