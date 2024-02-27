using StaffRegister;

EmployeeList list = new EmployeeList();

bool done = false;

while (!done)
{
    Console.Clear();
    Console.WriteLine("Välj 1 för att mata in en ny anställd.");
    Console.WriteLine("Välj 2 för att se en lista.");
    Console.WriteLine("Välj 3 för att avsluta.");
    string input = Console.ReadLine();
    if (input == "1")
    {
        AddEmployee(list);
    }
    else if (input == "2")
    {
        Console.Clear();
        Console.WriteLine(list.TextRepresentation());
        Console.WriteLine("Tryck Enter för att komma tillbaka till menyn.");
        Console.ReadLine();
    }
    else if(input == "3")
    {
        done = true;
    }
    else
    {
        Console.WriteLine("{0} är inte ett känt kommando", input);
        Console.WriteLine("Tryck Enter för att komma tillbaka till menyn.");
        Console.ReadLine();
    }
}

static void AddEmployee(EmployeeList list)
{
    Console.Clear();
    Console.WriteLine("Ny anställd");
    Console.Write("Ange namn: ");
    string name = Console.ReadLine();
    bool done = false;
    int salary = 0;
    while (!done)
    {
        Console.Write("Ange lön: ");
        string salaryString = Console.ReadLine();
        done = int.TryParse(salaryString, out salary);
        if (!done)
        {
            Console.WriteLine("{0} är inte en giltig lön.", salaryString);
        }
    }
    list.AddEmployee(new Employee(name, salary));

}