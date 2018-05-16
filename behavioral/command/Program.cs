using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.ChangeLight("ON");
            user.ChangeLight("OFF");
            user.ChangeLight("");
            Console.ReadKey();
        }
    }
}
