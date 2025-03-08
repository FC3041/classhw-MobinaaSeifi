#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    int m_capacity;
    char* m_PChars;

    MyStr():m_size(0),m_capacity(1),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;
        m_capacity = m_size + 1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    bool checkSubstr(const char* ch)
    {
        int i=0;
        int j=0;
        int l = len(ch);
        cout << "(0 means false and 1 means true): ";
        
        for(i=0; i<m_size; i++)
        {
            int result = 0;
            if(ch[0]==m_PChars[i])
            {
                for(j=0; j<l ; j++)
                {
                    if(ch[j]==m_PChars[i+j])
                    {
                        result ++;
                    }
                }
                if(result == l)
                {
            
                    return true;
                    
                    
                }
            
            }
            
                
        }
        return false;
        
    }


    int len(const char* ch)
    {
        int count = 0;
        int i=0;
        while(ch[i]!=0)
        {
            count++;
            i++;
        }
        return count;
    }
    int len()
    {
       

        int i=0;
        while(m_PChars[i]!=0)
        {
           
            i++;
        }
        
        return i;
    }
    
    void copy(char* second, const char* first) {
        while (*first) {
            *second = *first;
            second++;
            first++;
        }
        *second = '\0';
    }

    
        
    void append(const char* str) {
        int strLen = len(str);
        while (m_size + strLen >= m_capacity) {
            resize(m_capacity * 2);
        }
        copy(m_PChars + m_size, str);
        m_size += strLen;
    }

    void add(MyStr& s) {
        int strLen = s.len();
        while (m_size + strLen >= m_capacity) {
            resize(m_capacity * 2);
        }
        copy(m_PChars + m_size, s.m_PChars);
        m_size += strLen;
    }



        private:
        void resize(int newsize)
        {
            char* newchars = (char*)malloc(sizeof(char)*(newsize));
            for(int i=0; i<m_size;i++)
            {
                newchars[i] = m_PChars[i];
            }
            free(m_PChars);
            m_PChars = newchars;
            m_capacity = newsize;

        }
    

    
};



int main()
{
    MyStr s1("Monday");
    MyStr s3("thursday");
    MyStr s2("Sunday", 3,5);
    s2.printStr();

    

    cout << s1.len() << endl;
    cout << s1.checkSubstr(" sei") << endl;
   
    s1.append("ha");
    s1.printStr();


    s2.add(s1);
    s2.printStr();
    
    return 0;
}