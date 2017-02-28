using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town = null)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.Town))
            {
                return base.ToString() + string.Format("; Town = {0}", this.Town);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
