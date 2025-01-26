using DesignPatternsAndSolid.SOLID.OCP.Contracts;
using System;

namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    public class AccountCloudEngineer : IAccountService
    {
        public Staff CreateAccount(IApplicant applicant)
        {
            Staff staff = new Staff()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Role = StaffRole.CloudEngineer
            };

            staff.createEmail();

            return staff;
        }
    }
}
