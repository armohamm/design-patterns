using System;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Username = "pedrohma";
            user.Age = 22;
            user.Sex = "male";

            UserMemory memory = new UserMemory();
            memory.Memento = user.SaveMemento();

            user.Username = "felp";
            user.Age = 19;
            user.Sex = "male";

            user.RestoreMemento(memory.Memento);
        }
    }
}
