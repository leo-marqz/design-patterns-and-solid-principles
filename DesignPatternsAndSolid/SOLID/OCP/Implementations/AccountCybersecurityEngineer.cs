using DesignPatternsAndSolid.SOLID.OCP.Contracts;
using System;

namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    public class AccountCybersecurityEngineer : IAccountService
    {
        public Staff CreateAccount(IApplicant applicant)
        {
            Staff staff = new Staff()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Role = StaffRole.CybersecurityEngineer
            };

            staff.createEmail();

            return staff;
        }
    }
}
