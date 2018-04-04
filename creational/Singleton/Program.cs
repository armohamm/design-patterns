using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.Instance;

            s.AddMessage("Hello Singleton!");

            string result = s.HasMessage("Match") == true ? "There is a match." : "This is not a match.";

            Console.WriteLine(result);
        }
    }
}
