using System;

namespace Prototype
{
    public class Writer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public IEmployee Clone() {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails() {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
