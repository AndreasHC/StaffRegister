using StaffRegister;

EmployeeList list = new EmployeeList();
list.AddEmployee( new Employee("me", 2000));
Console.WriteLine(list.TextRepresentation());
