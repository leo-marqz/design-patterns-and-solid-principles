using System;
using System.Data;

namespace DesignPatternsAndSolid.SOLID.OCP.Implementations
{
    public class Staff
    {
        private static int _id = 0;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public StaffRole Role { get; set; } = StaffRole.Undefined;

        public Staff()
        {
            Id = ++_id;
        }

        public string createEmail()
        {
            Email =  $"{FirstName.ToLower()}.{LastName.ToLower()}@{Role.ToString().ToLower()}.com";
            return Email;
        }

        public override string ToString()
        {
            return $"Staff {{ Id={Id}, FirstName={FirstName}, LastName={LastName}, Email={Email} }}";
        }
    }
}
