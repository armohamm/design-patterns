using System.Collections.Generic;

public class TeamArray
{
    private List<Team> soccerTeams = new List<Team>();
    public int Add(string name, string description)
    {
        soccerTeams.Add(new Team(name, description));
        return soccerTeams.Count;
    }
    public int Add(Team team)
    {
        soccerTeams.Add(team);
        return soccerTeams.Count;
    }
    public Team GetItem(int index)
    {
        if (index < soccerTeams.Count)
        {
            return soccerTeams[index];
        }
        else
        {
            return null;
        }
    }
    public List<Team> GetAllTeams()
    {
        return soccerTeams;
    }
    public bool RemoveItem(int index)
    {
        if (index < soccerTeams.Count)
        {
            soccerTeams.RemoveAt(index);
            return true;
        }
        else
        {
            return false;
        }
    }
}