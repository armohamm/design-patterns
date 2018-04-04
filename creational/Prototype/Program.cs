using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Pedro";
            dev.Role = "Software Developer";
            dev.PreferredLanguage = "C#";
            
            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; 
            
            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());
            
            Writer writer = new Writer();
            writer.Name = "Patrick";
            writer.Role = "Typist";
            writer.WordsPerMinute = 120;
            
            Writer writerCopy = (Writer)writer.Clone();
            writerCopy.Name = "Ken";
            writerCopy.WordsPerMinute = 115;
            
            Console.WriteLine(writer.GetDetails());
            Console.WriteLine(writerCopy.GetDetails());
            
            Console.ReadKey();
        }
    }
}
