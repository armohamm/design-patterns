public class Team
{
    public string Name;
    public string Description;
    public Team(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public override string ToString()
    {
        return Name + " - " + Description;
    }
}