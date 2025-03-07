#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int* m_Pnums;

    MyList(int size, int *nums)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }

    void append(int x)
    {
        resize(m_size+1);
        m_Pnums[m_size-1] = x;
        printlist();
    }
    void remove(int indexn)
    {
        resize(m_size-1);
        int i=indexn;
        // int * pnums = (int*)malloc(sizeof(int)*(m_size-1));
        
        while(i < m_size)
        {
            m_Pnums[i] = m_Pnums[i+1];
            i++;
            
        }
        printlist();
        
    }
    void count(int indexn)
    {
        int i;
        int count=0;
        for(i=0; i< m_size; i++)
        {
            if(m_Pnums[i] == m_Pnums[indexn])
                count++;
        }
        cout << count << endl;
    }
    
    void printlist()
    {
        int i;
        for(i=0; i<m_size; i++)
        {
            cout << m_Pnums[i] << ",";
        }
        cout << "\n";
    }




    private:
    void resize(int newsize)
    {
        int* newMem = (int*)malloc(sizeof(int)*newsize);
        int i=0;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
        //newMem = NULL;
    }
};

int main()
{
    int nums[5] = {1,2,2,2,5};
    MyList m(5, nums);
    m.append(14);
    m.remove(2);
    m.count(2);
    return 0;
}