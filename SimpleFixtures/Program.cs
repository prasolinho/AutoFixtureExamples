using Ploeh.AutoFixture;
using System;

namespace SimpleFixtures
{
    class Program
    {
        static void Main(string[] args)
        {
            Fixture fixture = new Fixture();
            var person = fixture.Create<Person>();

            Console.WriteLine(person);
            Console.ReadKey(true);
        }
    }
}
