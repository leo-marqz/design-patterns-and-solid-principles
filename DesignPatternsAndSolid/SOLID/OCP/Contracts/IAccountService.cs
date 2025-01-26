

using DesignPatternsAndSolid.SOLID.OCP.Implementations;

namespace DesignPatternsAndSolid.SOLID.OCP.Contracts
{
    public interface IAccountService
    {
        Staff CreateAccount( IApplicant applicant );
    }
}
