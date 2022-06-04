using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.TeamName = teamName;
            this.Creator = creatorName;
            this.Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
