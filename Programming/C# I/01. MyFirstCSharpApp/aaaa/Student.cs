using System;

class Student
{
    private Specialty specialty;
    private string firstName;
    private string secondName;
    private string lastName;
    private string curs;
    private string university;
    private string email;
    private decimal? phoneNumber;
    private int allStudents;

    //methods
    public string AllStudents()
    {
        return string.Format("AllStudents - {0}", this.allStudents);
    }

    public override string ToString()
    {
        return string.Format("FullName - {0} {1} {2}, Curs - {3}, University - {4}, Email - {5}, PhoneNumber - {6}, Specialty - {7}.",
            this.firstName, this.secondName, this.lastName, this.curs, this.university, this.email, this.phoneNumber, this.specialty);
    }

    //constructors
    public Student()
        : this(null, null, null, null, null, null, null, 0)
    {
    }
    public Student(string firstName, string university, string email, Specialty specialty)
        : this(firstName, null, null, null, university, email, null, specialty)
    {
    }

    public Student(string firstName, Specialty speciality)
        : this(firstName, null, null, null, null, null, null, speciality)
    {
    }

    public Student(string firstName, string secondName,
        string lastNamer, string curs, string university, string email, decimal? phoneNumber, Specialty specialty)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.LastName = lastName;
        this.Curs = curs;
        this.University = university;
        this.Email = email;
        this.PhoneNumber = phoneNumber;
        this.Specialty = specialty;
        allStudents++;
    }

    ////properties
    //public int AllStudents
    //{
    //    get { return this.allStudents; }
    //}

    public Specialty Specialty
    {
        get { return this.specialty; }
        set { this.specialty = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string SecondName
    {
        get { return this.secondName; }
        set { this.secondName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public string Curs
    {
        get { return this.curs; }
        set { this.curs = value; }
    }

    public string University
    {
        get { return this.university; }
        set { this.university = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public decimal? PhoneNumber
    {
        get { return this.phoneNumber; }
        set { this.phoneNumber = value; }
    }
}