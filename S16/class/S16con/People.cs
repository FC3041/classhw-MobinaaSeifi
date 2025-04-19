class Citizen
{
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public int NationalID { get; set;}
    public bool IsMale { get; set;}

    public Citizen(string fname, string lname, int id, bool isMale)
{
    this.FirstName = fname;
    this.LastName = lname;
    this.NationalID = id;
    this.IsMale = isMale;
}
// public Citizen(){}
}

class Student: Citizen
{
    public int StdId {get; set;}
    public string Major { get; set;}
    public bool IsPaying { get; set;}

    public Student(string fname, string lname, int id, string major, int stdid, bool isPaing)
        : base(fname, lname, id, false)
    {
        this.IsPaying = isPaing;
        this.StdId = stdid;
        this.Major = major;
    }
    
}
