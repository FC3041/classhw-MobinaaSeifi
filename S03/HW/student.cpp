#include<iostream>
#include<string.h>
#include<stdlib.h>

class Student
{
public:
    int m_stdNum;
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
    ~Student()
    {
        std:: cout << "the student was deleted" << std:: endl;
    }
    double GetGPA()
    {
        double sumGrade = 0;
        int sumCredit = 0;
        for(int i=0; i<m_CoursesPassed; i++) {
            sumGrade += m_Credits[i] * m_Grades[i];
            sumCredit += m_Credits[i];
        }
        return sumGrade / sumCredit;
    }

    void list_courses()
    {
        for(int i=0; i<m_CoursesPassed; i++) {
            std::cout << m_CourseNames[i] << ": "
                      << m_Credits[i] << " : "
                      << m_Grades[i] << std::endl;        
        }
    }

    void register_course(int credits, const char* name, double grade)
    {
        m_Credits[m_CoursesPassed] = credits;
        m_Grades[m_CoursesPassed] = grade;
        char* namecopy = new char[strlen(name) + 1];
            //(char*) malloc(strlen(name) + 1);
        strcpy(namecopy, name);
        m_CourseNames[m_CoursesPassed] = namecopy;
        m_CoursesPassed++;
    }
    Student(){}
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

    // Student* s2 = new Student(3423, "asdf", "lasdkfj");
    // Student* s3 = &s;
    // int * pn = new int[10];
    s.m_CoursesPassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(s.m_CoursesPassed < passedcourses)
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
    std::cout << "Grade Point Average: " <<s.GetGPA() << std::endl;
    return 0;
}