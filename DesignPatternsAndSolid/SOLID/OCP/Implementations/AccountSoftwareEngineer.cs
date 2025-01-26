using DesignPatternsAndSolid.SOLID.OCP.Contracts;


namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    public class AccountSoftwareEngineer : IAccountService
    {
        public Staff CreateAccount(IApplicant applicant)
        {
            Staff staff = new Staff()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Role = StaffRole.SoftwareEngineer
            };

            staff.createEmail();

            return staff;
        }
    }
}
