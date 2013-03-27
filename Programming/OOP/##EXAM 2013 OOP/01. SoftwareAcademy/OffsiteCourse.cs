using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OffsiteCourse : Course, IOffsiteCourse
{
    public string Town { get; set; }
    
    public OffsiteCourse(string name, ITeacher teacher, string town)
        : base(name, teacher)
    {
        this.Town = town;
    }
    
    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Town))
        {
            return base.ToString() + string.Format("; Town={0}", this.Town);
        }
        else
        {
            return base.ToString();
        }
    }
}
