using DesignPatternsAndSolid.SOLID.OCP.Contracts;

namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    internal class AccountService : IAccountService
    {
        public Staff CreateAccount(IApplicant applicant)
        {
            Staff staff = new Staff()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Role = StaffRole.Undefined
            };

            staff.createEmail();

            return staff;
        }
    }
}
