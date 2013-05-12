using System;
using System.Linq;

class Student : ICloneable, IComparable<Student>
{
    public Faculty Faculty { get; set; }
    public Specialty Specialty { get; set; }
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public int SSN { get; private set; }
    public string PermanentAddress { get; private set; }
    public int MobilePhone { get; private set; }
    public string Email { get; private set; }
    public string Course { get; private set; }

    public Student(string firstName, string middleName, string lastName)
        : this(firstName, middleName, lastName, 0, null, 0, null, null, 0, 0)
    {
    }

    public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress,
        int mobilePhone, string email, string course, Faculty faculty, Specialty specialty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Faculty = faculty;
        this.Specialty = specialty;
    }

    public override bool Equals(object obj)
    {
        Student student = obj as Student;

        if (student == null)
        {
            return false;
        }

        if (this.FirstName == student.FirstName
            && this.MiddleName == student.MiddleName
            && this.LastName == student.LastName
            && this.SSN == student.SSN)
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
    }

    public static bool operator == (Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !Student.Equals(student1, student2);
    }

    public Student Clone() //Implement own Clone method for our class
    {
        Student student = new Student(null, null, null);

        Student original = this; // original.Clone() -- get data about obj we want to clone
        student.FirstName = original.FirstName;
        student.MiddleName = original.MiddleName;
        student.LastName = original.LastName;
        return student;
    }


    object ICloneable.Clone() //Implement clone method from interface to return our method
    {
        return this.Clone();
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
    }

    public int CompareTo(Student student)
    {
        if (this.FirstName != student.FirstName)
        {
            return (this.FirstName.CompareTo(student.FirstName));
        }
        if (this.MiddleName != student.MiddleName)
        {
            return (this.MiddleName.CompareTo(student.MiddleName));
        }
        if (this.LastName != student.LastName)
        {
            return (this.LastName.CompareTo(student.LastName));
        }
        if (this.SSN != student.SSN)
        {
            return (this.SSN - student.SSN);
        }
        return 0;
    }
}




