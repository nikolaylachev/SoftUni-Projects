using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Program
    {
        class Team
        {
            public string NameOfTeam { get; set; }
            public List<Member> Memebers { get; set; }
            public string NameOfCreator { get; set; }
          
        }
        class Member
        {
            public string NameOfMember { get; set; }
            public String NameOfTeam { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> registrationTeamsCommand = new List<string>();
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                registrationTeamsCommand = Console.ReadLine().Split('-').ToList();
               
                if (!teams.Any(x => x.NameOfTeam == registrationTeamsCommand[1]) && !teams.Any(x => x.NameOfCreator == registrationTeamsCommand[0]))
                {
                    teams.Add(new Team()
                    {
                        NameOfCreator = registrationTeamsCommand[0],
                        NameOfTeam = registrationTeamsCommand[1],
                        Memebers = new List<Member>(),      
                    });

                    Console.WriteLine($"Team {registrationTeamsCommand[1]} has been created by {registrationTeamsCommand[0]}!");

                }

                else if (teams.Any(x => x.NameOfTeam == registrationTeamsCommand[1]) && !teams.Any(x => x.NameOfCreator == registrationTeamsCommand[0]))
                {
                    Console.WriteLine($"Team { registrationTeamsCommand[1]} was already created!");
                }

                else if (!teams.Any(x => x.NameOfTeam == registrationTeamsCommand[1]) && teams.Any(x => x.NameOfCreator == registrationTeamsCommand[0]))
                {
                    Console.WriteLine($"{registrationTeamsCommand[0]} cannot create another team!");
                }
                //else if (teams.Any(x => x.NameOfTeam == registrationTeamsCommand[0]) && teams.Any(x => x.NameOfCreator == registrationTeamsCommand[0]))
                //{
                //    Console.WriteLine($"Member {registrationTeamsCommand[0]} cannot join team {registrationTeamsCommand[1]}!");
                //}
            }

            List<string> memebersCommand = new List<string>();

            do
            {
                memebersCommand = Console.ReadLine().Split(new char [] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (memebersCommand[0] != "end of assignment")
                {

                    if (!teams.Any(x => x.NameOfTeam == memebersCommand[1]))
                    {
                        Console.WriteLine($"Team {memebersCommand[1]} does not exist!");
                    }

                    else if (teams.Any(x => x.NameOfTeam == memebersCommand[1]))
                    {
                        int index = 0;
                        for (int i = 0; i < teams.Count; i++)
                        {
                            if (teams[i].NameOfTeam == memebersCommand[1])
                            {
                                index = i;
                            }
                        }

                        if (teams[index].NameOfCreator != memebersCommand[0])
                        {
                            teams[index].Memebers.Add(new Member()
                            {
                                NameOfMember = memebersCommand[0],
                                NameOfTeam = memebersCommand[1],
                            }); 
                        }
                    }
                    if (teams.Any(x => x.NameOfCreator == memebersCommand[0]) && teams.Any(x => x.NameOfTeam == memebersCommand[1]) )
                    {
                        Console.WriteLine($"Member {memebersCommand[0]} cannot join team {memebersCommand[1]}!");
                    }
                }

            } while (memebersCommand[0] != "end of assignment");

           
            var newList = teams.OrderByDescending(x => x.Memebers.Count).ThenBy(x => x.NameOfTeam);
            foreach (var team in newList)
            {
                if (team.Memebers.Count != 0)
                {
                    Console.WriteLine($"{team.NameOfTeam}");
                    Console.WriteLine($"- {team.NameOfCreator}");
                    foreach (var member in team.Memebers.OrderBy(x => x.NameOfMember))
                    {
                        Console.WriteLine($"-- {member.NameOfMember}");
                    } 
                }
            }

            
            var disbandList = new List<string>();

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Memebers.Count == 0)
                {
                    disbandList.Add(teams[i].NameOfTeam);//Console.WriteLine($"{teams[i].NameOfTeam}");
                }
            }

            
                Console.WriteLine("Teams to disband:");
                var newDisbandList = disbandList.OrderBy(x => x);

                foreach (var item in newDisbandList)
                {
                    Console.WriteLine(item);
                }
            for (int i = 1; i <= 1000000; i++)
            {
                Console.Write($"\r{i}");
            }
            
        }
    }
}
