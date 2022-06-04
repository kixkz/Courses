using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{

    internal class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] teamArg = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = teamArg[0];
                string teamName = teamArg[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string memberName = joinArgs[0];
                string teamName = joinArgs[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.AddMember(memberName);
            }

            List<Team> teamsWithMembers = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            List<Team> teamsToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            PrintValidTeams(teamsWithMembers);
            PrintInvalidTeams(teamsToDisband);
        }

        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.TeamName}");
                Console.WriteLine($"- {validTeam.Creator}");

                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }
        }

        static void PrintInvalidTeams(List<Team> invalidTeams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in invalidTeams)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }
        }
    }
}
