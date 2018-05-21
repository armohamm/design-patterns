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

    public string UserInfo(){
      return "Name: " + this.username + "\nAge: " + this.age + "\nSex: " + this.sex;
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
    }
}