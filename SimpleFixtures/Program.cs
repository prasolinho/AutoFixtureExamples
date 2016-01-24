using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;

namespace SimpleFixtures
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Pierwszy fixture
            Fixture fixture = new Fixture();
            var person = fixture.Create<Person>();

            Console.WriteLine(person);

            // 02. Wygenerowanie listy obiektów

            List<Person> list = new List<Person>(50);
            for (int i = 0; i < 50; i++)
            {
                list.Add(fixture.Create<Person>());
            }

            // 03. Automatyczne wygenerowanie listy obiektów przez AutoFixture
            int count = 50;
            fixture.RepeatCount = 50;
            List<Person> list2 = new List<Person>(count);
            fixture.AddManyTo(list2);

            Console.ReadKey(true);
        }
    }
}
