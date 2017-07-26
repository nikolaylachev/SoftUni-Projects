using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double Average
            {
                get
                {
                    return (Grades.Sum() / Grades.Count);
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(int.Parse(Console.ReadLine()) * 2);
            int n = int.Parse(Console.ReadLine());

            List<string> command = new List<string>();
            List<double> grades = new List<double>();
            Student[] students = new Student[n];
            Dictionary<string, List<double>> studs = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(' ').ToList();
                string name = command[0];
                command.RemoveAt(0);

                for (int j = 0, k = 0; j < command.Count; j++, k++)
                {
                    grades.Insert(j,double.Parse(command[k]));
                }

                students[i] = new Student() { Name = name, Grades = grades };
                grades = new List<double>();//Emptying the grades list without emptying hte grades in the students list.
            }
            var newListOfStudents = students.Where(x => x.Average >= 5.00D).OrderBy(x => x.Name).ThenBy(x => -x.Average);
            foreach (var item in newListOfStudents)
            {
                Console.WriteLine($"{item.Name} -> {item.Average:f2}");
            }
        }
    }
}
