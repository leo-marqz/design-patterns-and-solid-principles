using DesignPatternsAndSolid.SOLID.LSP.Contracts;
using System;

namespace DesignPatternsAndSolid.SOLID.LSP.Implementations
{
    public class SoccerPlayer : IPlayer, IPlayerTeam
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Team Team { get; set; }
        public PlayerCategory Category { get; set; }

        public void AssignTeam(Team team)
        {
            Team = team;
        }

        public string GetTeam() => Team.Name;

        public void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}
