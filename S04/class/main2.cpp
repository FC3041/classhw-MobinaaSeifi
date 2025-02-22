#include<iostream>
using namespace std;

class Date
{
    int m_month;
    int m_year;
};

class Person
{
    int m_NID;
    char m_fname[20];
    char m_lname[20];
    Date m_BD;

    public:

    Person(const char* fname, const char* lname, int id, Date bd)
    : m_BD(bd), m_NID(id)
    {
        int i;
        for(i=0; i<sizeof(fname) && fname[i] = '\0'; i++)
        {
            m_fname[i] = fname[i];
        }
        m_fname[i] = '\0';
    }
    // void print_person()
    // {
    //     cout << "Name: "
    // }
};

