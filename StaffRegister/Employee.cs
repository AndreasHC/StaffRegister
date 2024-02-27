using System;

public class Employee
{
	private string name;
	private int salary;

	public Employee(string name, int salary)
	{
		this.name = name;
		this.salary = salary;
	}

	public string TextRepresentation()
	{
		return "Namn: " + name + ", Lön: " + salary;
	}
}
