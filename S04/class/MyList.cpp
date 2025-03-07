#include<iostream>

using namespace std;

class MyList
{
    public:
        int m_size;
        int* m_pnums;

    // MyList l = new (m_size)

    MyList(int size, int* pnums)
    :m_size(size)
    {
        m_pnums = (int*) (malloc(sizeof(int)*size));
        int i;
        for(i=0; i<m_size; i++)
        {
            m_pnums[i] = pnums[i];
        }
    }

    int* append(int num)
    {
        int i;
        int* result = (int*) (malloc(sizeof(int)*(m_size+1)));
        for(i=0; i<=m_size; i++)
        {
            if(i<m_size)
                m_pnums[i] = result[i];
            else if(i == m_size)
                result[i] = num;
        }
        return result;
    }

};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m(5, nums);
    cout<< m.append(14) <<endl;
}