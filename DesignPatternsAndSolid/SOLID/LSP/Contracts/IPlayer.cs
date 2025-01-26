using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSolid.SOLID.LSP.Contracts
{
    public interface IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        public void SetCategory(PlayerCategory category);
    }
}
