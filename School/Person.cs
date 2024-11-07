using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School;

internal class Person : IDepartment
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DepartmentName { get; set; }

    public Person(string firstName, string lastName) 
    { 
        FirstName = firstName;
        LastName = lastName;
    }

    public virtual void SetDepartment(string value)
    {
        DepartmentName = value;
    }

    public string GetInterfaceInfo()
    {
        IDepartment myInterface = this;
        return myInterface.GetInfo();
    }
}
