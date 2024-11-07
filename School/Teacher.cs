using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School;

internal class Teacher : Person
{
    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    { 
    }

    public override void SetDepartment(string value)
    {
        DepartmentName = "CIT";
    }
}
