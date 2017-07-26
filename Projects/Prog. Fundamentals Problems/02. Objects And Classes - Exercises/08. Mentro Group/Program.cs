using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentro_Group
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<DateTime> AttendanceDates { get; set; }
            public List<string> Comments { get; set; }
        }

        static void Main(string[] args)
        {
            List<string> dates = new List<string>();//
            List<string> comments = new List<string>();
            Dictionary<string, Student> studentsDict = new Dictionary<string, Student>();
            List<Student> students = new List<Student>();

            List<DateTime> datesFromFirstCommand = new List<DateTime>();
            
            do
            {
                dates = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (dates[0] != "end")
                {
                    for (int i = 1; i < dates.Count; i++)
                    {
                        string[] date = dates[i].Split('/');
                        DateTime newDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                        datesFromFirstCommand.Add(newDate);
                    }
                    if (students.Count == 0)
                    {
                        students.Add(new Student() { Name = dates[0] }); 
                    }
                    else if(students.Count > 0)
                    {
                        for (int i = 0; i < students.Count; i++)
                        {

                            if (students[i].Name == dates[0] && students[i].AttendanceDates == null)
                            {
                                students[i].AttendanceDates = datesFromFirstCommand;
                            }
                            else if (students[i].Name == dates[0] && students[i].AttendanceDates != null)
                            {
                                for (int j = 0; j < datesFromFirstCommand.Count; j++)
                                {
                                    students[i].AttendanceDates.Add(datesFromFirstCommand[j]);
                                }
                            }
                        } 
                    }
                    //students.Add(dates[0], new Student() { AttendanceDates = datesFromFirstCommand });
                    //students.Add(new Student { Name = dates[0], AttendanceDates = datesFromFirstCommand });
                    //studentsDict.Add(dates[0], new Student() {Name = dates[0],AttendanceDates = datesFromFirstCommand });

                    datesFromFirstCommand = new List<DateTime>();//Emptying the dates list without emptying the dates in the class!!!
                }

            } while (dates[0] !="end");

            List<string> commentsFromSecondCommand = new List<string>();
            do
            {
                comments = Console.ReadLine().Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comments[0] != "end of comments")
                {
                    for (int i = 1; i < comments.Count; i++)
                    {
                        commentsFromSecondCommand.Add(comments[i]);
                    }

                    for (int i = 0; i < students.Count; i++)
                    {

                        if (students[i].Name == comments[0] && students[i].Comments==null)
                        {
                            students[i].Comments = commentsFromSecondCommand;
                        }

                        else if (students[i].Name == comments[0] && students[i].Comments != null)
                        {
                            for (int j = 0; j < commentsFromSecondCommand.Count; j++)
                            {
                                students[i].Comments.Add(commentsFromSecondCommand[j]);
                            }
                        }
                    }

                    commentsFromSecondCommand = new List<string>();

                }

            } while (comments[0] != "end of comments");

            var newStudents = students.OrderBy(x => x.Name).ThenBy(x => x.AttendanceDates);//ThenBy() - NOT working!!!

            foreach (var student in newStudents)
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    } 
                }
                Console.WriteLine("Dates attended:");
                if (student.AttendanceDates != null)
                {
                    foreach (var date in student.AttendanceDates.OrderBy(x => x))//ThenBy() -> FIXED!!!
                    {
                        Console.WriteLine($"-- {date.Day:d2}" + "/" + $"{date.Month:d2}" + "/" + $"{date.Year:d2}");//Made the date format customly!!
                    } 
                }
            }
        }
    }
}
