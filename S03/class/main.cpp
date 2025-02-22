#include<iostream>
using namespace std;
#include<stdlib.h> // baraye malloc (new)
#include<string.h> // baraye strlen and strcpy
class Student
{
    public:
        int m_stdnum;
        char m_firstname[20];
        char m_lastname[20];
        int m_coursespassed;
        int m_credits[40];
        double m_grades[40];
        char* m_coursenames[40];


    double getgpa()
    {
        double sumgrade = 0;
        int sumcredits = 0;
        for(int i=0; i<m_coursespassed; i++)
        {
            sumgrade += m_credits[i] * m_grades[i];
            sumcredits += m_credits[i];
        }
        return sumgrade / sumcredits;
    }

    void list_courses()
    {
        for(int i=0; i<m_coursespassed; i++)
            cout << m_coursenames[i] << ": "
                 << m_credits[i] << ": "
                 << m_grades[i] << endl;

    }

    void register_course(int credits, const char* name, double grade)
    {
        m_credits[m_coursespassed] = credits;
        m_grades[m_coursespassed] = grade;
        char* namecopy =  new char[strlen(name) + 1];
                        //(char*) malloc(strlen(name) + 1);
        strcpy(namecopy, name);
        m_coursenames[m_coursespassed] = name;    //  ???????? inja chikar kardim error raft?  
        m_coursespassed++;          
    }
};
int main()
{
    Student s;
    s.m_coursespassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        cout << "course name?";
        cin >> bufc;

        cout << "course credits?";
        cin >> credits;

        cout << "course grade?";
        cin >> grade;

        // s.register_course()

    }
    s.list_courses();
    cout << s.getgpa() << endl;
    return 0;
}

// null , 0 fargi nadare fagat 0 karbord dige i dare vali null na;