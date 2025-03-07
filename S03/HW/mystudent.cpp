#include<iostream>
using namespace std;
#include<stdlib.h>    //برای allocate کردن
#include<string.h>    //برای strlen , strcpy

class Student
{
    public:
     int m_stdnum;
     char m_FirstName[20];
     char m_LastName[20];
     int m_CoursesPassed;
     int m_Credits[40];
     double m_Grades[40];
     char* m_CourseNames[40];


    Student(int stdnum, const char* fname, const char* lname, int coursespassed)
    {
        int m_stdnum = stdnum;
        const char* m_FirstName = fname;
        const char* m_LastName = lname;
        int m_CoursesPassed = coursespassed; 
    }

    ~ Student()
    {
        cout << "The student is deleted" <<endl;
    }

    double GetGPA()
    {
        double sumgrade  = 0;
        int sumcredit = 0;

        for(int i=0; i<m_CoursesPassed; i++)
        {
            sumgrade += m_Grades[i] * m_Credits[i];
            sumcredit += m_Credits[i]; 
        }
        return sumgrade / sumcredit;
    }

    void list_courses()
    {
        std::cout <<"CourseName: "<< "Credits: " << "Grade: " << std::endl;
        for(int i=0; i<m_CoursesPassed; i++) {
            std::cout << m_CourseNames[i] << ": "
                      << m_Credits[i] << ": "
                      << m_Grades[i] << std::endl;        
        }
    }

    void register_course(int credit, const char* name, double grade)
    {
        m_Credits[m_CoursesPassed] = credit;
        m_Grades[m_CoursesPassed] = grade;

        char* namecopy = new char(strlen(name) + 1);
        strcpy(namecopy, name);
        m_CourseNames[m_CoursesPassed] = namecopy;
        m_CoursesPassed++;
    }
};
int main()
    {
        int stdnum;
        std::cout << "StudentNumber?" ;
        std:: cin >> stdnum;

        char fname[20];
        std::cout << "FirstName?" ;
        std:: cin >> fname;

        char lname[20];
        std::cout << "LastName?" ;
        std:: cin >> lname;

        int passedcourses;
        std::cout << "CountOfCourses?" ;
        std:: cin >> passedcourses;

        Student s(stdnum, fname, lname, passedcourses);


        s.m_CoursesPassed = 0;
        char bufc[20];
        double grade;
        int credits;

        while( s.m_CoursesPassed < passedcourses)
        {
            std::cout << "course name?" ;
            std::cin >> bufc ;
            std::cout << "course credits?" ;
            std::cin >> credits ;
            std::cout << "course grade?" ;
            std::cin >> grade ;
        s.register_course(credits, bufc, grade);
        }
        s.list_courses();
        cout << s.GetGPA() << endl;
        return 0;

    }