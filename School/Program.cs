using School;

Teacher t = new("N.", "Olesen");
Student s = new("O.", "Nielsen");
s.SetDepartment("CIT");

SendEmail se = new();
string message = se.Send(s);
Console.WriteLine($"{message}");


//Console.WriteLine($"The department is: {t.DepartmentName}");
//Console.WriteLine($"The department is: {t.GetInterfaceInfo()}");
