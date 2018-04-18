using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new TeamMember("Pedro", 20000);

            Employee employeeB = new TeamMember("Henry", 45000);

            Employee teamLead = new TeamLead("Franz", 75000);

            teamLead.Add(employeeA);

            teamLead.Add(employeeB);

            Console.WriteLine(teamLead.GetData());

            Console.Read();
        }
    }
}
