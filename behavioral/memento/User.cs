using System;

public class User{
    private string username {get;set;}
    private int age;
    private string sex;

    public string Username
    {
      get { return username; }
      set
      {
        username = value;
        Console.WriteLine("Username: " + username);
      }
    }

    public int Age
    {
      get { return age; }
      set
      {
        age = value;
        Console.WriteLine("Age: " + age);
      }
    }

    public string Sex
    {
      get { return sex; }
      set
      {
        sex = value;
        Console.WriteLine("Sex: " + sex);
      }
    }

    public Memento SaveMemento(){
      Console.WriteLine("\nSaving state --\n");
      return new Memento(username, age, sex);
    }

    public void RestoreMemento(Memento memento){
      Console.WriteLine("\nRestoring  state --\n");
      this.username = memento.Username;
      this.age = memento.Age;
      this.sex = memento.Sex;
      Console.Write("Username: " + this.username + "\nAge:" + this.age + "\nSex:" + this.sex);
    }
}