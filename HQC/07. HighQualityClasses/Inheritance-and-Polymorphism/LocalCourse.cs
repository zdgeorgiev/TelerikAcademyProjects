using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }
        
        public LocalCourse(string name, string teacherName, IList<string> Students, string lab = null)
            : base(name, teacherName, Students)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.Lab))
            {
                return base.ToString() + string.Format("; Lab = {0}", this.Lab);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
