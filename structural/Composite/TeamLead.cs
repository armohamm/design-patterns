using System.Collections.Generic;
using System.Text;

public class TeamLead : Employee
{

    List<Employee> lstEmployee = new List<Employee>();

        public TeamLead(string name, double salary) : base(name, salary) { }
    public override void Add(Employee employee)
    {
        lstEmployee.Add(employee);
    }

    public override string GetData()
    {
        StringBuilder sbEmployee = new StringBuilder();

             foreach (Employee emp in lstEmployee)

            {

                sbEmployee.Append(emp.GetData()+ "\n");

            } 

            return sbEmployee.ToString();
    }

    public override void Remove(Employee employee)
    {
        lstEmployee.Remove(employee);
    }
}