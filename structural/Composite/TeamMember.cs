using System;

public class TeamMember : Employee
{

    public TeamMember(string name, double salary) : base(name, salary) { }

    public override void Add(Employee employee)
    {
        Console.WriteLine("Operation not permitted since this is a leaf node.");
        throw new System.NotImplementedException();
    }

    public override string GetData()
    {
        return "Name: "+ name + "\tSalary: "+salary.ToString("N2");
    }

    public override void Remove(Employee employee)
    {
        Console.WriteLine("Operation not permitted since this is a leaf node.");
        throw new System.NotImplementedException();
    }
}