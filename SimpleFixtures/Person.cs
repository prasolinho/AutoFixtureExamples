using System;

namespace SimpleFixtures
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Age: {2}", Id, Name, Age);
        }
    }
}
