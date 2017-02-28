using System;
using System.Linq;
using System.Text;

public class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }
    public string Address { get; set; }
    public decimal MobilePhone { get; set; }
    public string Email { get; set; }
    public string Course { get; set; }
    public Specialty Specialty { get; set; }
    public University Universe { get; set; }
    public Faculty Faculty { get; set; }

    public Student()
    {
    }

    public Student(string firstName, string middleName, string lastName, int ssn)
        : this(firstName, middleName, lastName, ssn, null, 0,
            null, null, default(Specialty), default(University), default(Faculty))
    {
    }

    public Student(string firstName, string middleName, string lastName, int ssn, string address,
        decimal mobilePhone, string email, string course, Specialty specialty, University uni, Faculty faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.Universe = uni;
        this.Faculty = faculty;
    }
   
    public static bool operator != (Student student1, Student student2)
    {
        return !Student.Equals(student1, student2);
    }

    public static bool operator == (Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public Student Clone()
    {
        Student newStudent = new Student();
        Student student = this; // get the current instance

        newStudent.FirstName = student.FirstName;
        newStudent.MiddleName = student.MiddleName;
        newStudent.LastName = student.LastName;
        newStudent.SSN = student.SSN;
        newStudent.Address = student.Address;
        newStudent.Email = student.Email;
        newStudent.Course = student.Course;
        newStudent.Specialty = student.Specialty;
        newStudent.Universe = student.Universe;
        newStudent.Faculty = student.Faculty;

        return newStudent;
    }

    object ICloneable.Clone()
    {
        return Clone();
    }

    public override bool Equals(object obj)
    {
        var otherStudent = obj as Student;

        if (otherStudent != null)
        {
            if (this.FirstName == otherStudent.FirstName &&
                this.MiddleName == otherStudent.MiddleName &&
                this.LastName == otherStudent.LastName &&
                this.SSN == otherStudent.SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        int result = 13;

        result = result * 23 + ((FirstName != null) ? this.FirstName.GetHashCode() : 0);
        result = result * 23 + ((MiddleName != null) ? this.MiddleName.GetHashCode() : 0);
        result = result * 23 + ((LastName != null) ? this.LastName.GetHashCode() : 0);
        result = result * 23 + this.SSN.GetHashCode();
        result = result * 23 + ((Address != null) ? this.Address.GetHashCode() : 0);
        result = result * 23 + this.MobilePhone.GetHashCode();
        result = result * 23 + ((Email != null) ? this.Email.GetHashCode() : 0);
        result = result * 23 + ((Course != null) ? this.Course.GetHashCode() : 0);
        result = result * 23 + this.Specialty.GetHashCode();
        result = result * 23 + this.Universe.GetHashCode();
        result = result * 23 + this.Faculty.GetHashCode();

        return result;
    }

    public int CompareTo(Student other)
    {
        Student currentStudent = this;

        if (currentStudent.FirstName != other.FirstName)
        {
            return (currentStudent.FirstName.CompareTo(other.FirstName));
        }
        if (currentStudent.MiddleName != other.MiddleName)
        {
            return (currentStudent.MiddleName.CompareTo(other.MiddleName));
        }
        if (currentStudent.LastName != other.LastName)
        {
            return (currentStudent.LastName.CompareTo(other.LastName));
        }
        if (currentStudent.SSN != other.SSN)
        {
            return (currentStudent.SSN - other.SSN);
        }
        return 0;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        var allProps = (this.GetType().GetProperties()).ToList();
        int currentProp = 0;

        foreach (var prop in allProps)
        {
            result.AppendFormat("{0} - {1}", 
                allProps[currentProp].Name, this.GetType().GetProperty(prop.Name).GetValue(this, null));

            currentProp++;
            result.AppendLine();
        }

        return result.ToString();
    }
}