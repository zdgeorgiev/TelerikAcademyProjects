using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Country { get; private set; }
        public byte Age { get; private set; }

        public Student(string firstName, string lastName, byte age, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Country = country;
        }

        public bool IsOlderThan(Student other)
        {
            if (this.Age > other.Age)
            {
                return true;
            }
            return false;
        }
    }
}
