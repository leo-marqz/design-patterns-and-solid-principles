using DesignPatternsAndSolid.SOLID.OCP;
using DesignPatternsAndSolid.SOLID.OCP.Contracts;
using DesignPatternsAndSolid.SOLID.OCP.Implementations;
using DesignPatternsAndSolid.SOLID.SRP;
using System;
using System.Collections.Generic;

namespace DesignPatternsAndSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> applicants = new List<IApplicant>()
            {
                new CloudEngineer { FirstName = "Elmer", LastName = "Marquez" },
                new SoftwareEngineer { FirstName = "Leo", LastName = "Marqz" },
                new CybersecurityEngineer { FirstName = "Crack", LastName = "Night" },
                new User { FirstName = "Any", LastName = "User" }
            };

            List<Staff> staffs = new List<Staff>();

            foreach (var applicant in applicants)
            {
                staffs.Add( applicant.Processor.CreateAccount( applicant ) );
            }

            foreach (var staff in staffs)
            {
                Console.WriteLine( staff );
            }

        }
    }
}
