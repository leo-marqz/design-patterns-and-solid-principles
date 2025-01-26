using DesignPatternsAndSolid.SOLID.OCP.Contracts;
using System;

namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    

    internal class SoftwareEngineer : IApplicant
    {
        private static int _id = 0;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountSoftwareEngineer();

        public SoftwareEngineer()
        {
            Id = ++_id;
        }

        public override string ToString()
        {
            return $"User {{ Id={Id}, FirstName={FirstName}, LastName={LastName} }}";
        }
    }
}
