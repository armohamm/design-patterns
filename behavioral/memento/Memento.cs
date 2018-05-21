public class Memento{
    private string username {get;set;}
    private int age;
    private string sex;

    public Memento(string username, int age, string sex){
        this.username = username;
        this.age = age;
        this.sex = sex;
    }

    public string Username
    {
      get { return username; }
      set
      {
        username = value;
      }
    }

    public int Age
    {
      get { return age; }
      set
      {
        age = value;
      }
    }

    public string Sex
    {
      get { return sex; }
      set
      {
        sex = value;
      }
    }
}