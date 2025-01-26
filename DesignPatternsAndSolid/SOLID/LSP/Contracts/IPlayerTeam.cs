using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSolid.SOLID.LSP.Contracts
{
    public interface IPlayerTeam
    {
        public void AssignTeam(Team team);
        public string GetTeam();
    }
}
