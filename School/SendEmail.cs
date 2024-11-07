using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School;

internal class SendEmail
{
 
    public string Send(IDepartment person)
    {
        string? message = null;

        if(person.GetType() == typeof(Teacher))
        {
            // send email til teacher.
            message = "Email er sendt til læren.";
        }
        else if(person.GetType() == typeof(Student))
        {
            // Send besked til itslearning
            message = "Besked er sendt til itslearning.";
        }

        return message;
    }
}
