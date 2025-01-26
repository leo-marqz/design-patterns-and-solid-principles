using System;

namespace DesignPatternsAndSolid.SOLID.LSP
{
    public class Team
    {
        private static int _id = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        
        public Team()
        {
            Id = ++_id;
        }

        public override string ToString()
        {
            return $"Team {{ Id={Id}, Name={Name} }}";
        }
    }
}
