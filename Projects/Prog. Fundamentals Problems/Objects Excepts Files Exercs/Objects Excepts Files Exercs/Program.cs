using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Excepts_Files_Exercs
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public long Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            List<Person> people = new List<Person>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();

                if (command[0] != "End")
                {
                    people.Add(new Person()
                    {
                        Name = command[0],
                        Id = command[1],
                        Age = long.Parse(command[2]),
                    });
                }

            } while (command[0] != "End");

            var newPersonList = people.OrderBy(x => x.Age);

            foreach (var person in newPersonList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
