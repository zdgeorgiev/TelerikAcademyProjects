using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LocalCourse : Course, ILocalCourse
{
    public string Lab { get; set; }

    public LocalCourse(string name, ITeacher teacher, string lab)
        : base(name, teacher)
    {
        this.Lab = lab;
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Lab))
        {
            return base.ToString() + string.Format("; Lab={0}", this.Lab);
        }
        else
        {
            return base.ToString();
        }
    }
}
