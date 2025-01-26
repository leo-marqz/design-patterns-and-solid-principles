
namespace DesignPatternsAndSolid.SOLID.OCP.Contracts
{
    public interface IApplicant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        IAccountService Processor { get; set; }
    }
}
