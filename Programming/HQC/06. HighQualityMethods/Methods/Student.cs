using System;

namespace Methods
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string country;
        private DateTime birthDate;
        private const int MIN_YEAR_BORN = 1910;

        public Student(string firstName, string lastName, DateTime birthDate, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Country = country;
        }

        public bool IsOlderThan(Student other)
        {
            if (other != null)
            {
                if (this.BirthDate > other.BirthDate)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("FirstName should be atleast 3 chars.");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("SecondName should be atleast 3 chars.");
                }
            }
        }

        public string Country
        {
            get { return this.country; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    this.country = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Country Name.");
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value.Year > MIN_YEAR_BORN && value.Year <= DateTime.Now.Year)
                {
                    birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Your birthdate is invalid");
                }
            }
        }
    }
}
