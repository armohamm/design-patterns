using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamArray teamArray = new TeamArray();
            teamArray.Add(new Team("Real Madrid", "6 March 1902 as Madrid Football Club."));
            teamArray.Add(new Team("Barcelona", "On 29 November 1899, Joan Gamper founded FC Barcelona."));
            teamArray.Add(new Team("Corinthians", "Founded in 1910 by five railway workers, Corinthians was inspired by the London-based club Corinthian Football Club."));
            // Using no iterator.
            List<Team> teams = teamArray.GetAllTeams();
            foreach (Team team in teams)
            {
                Console.WriteLine(team);
            }
            Console.ReadKey();
        }
    }
}
