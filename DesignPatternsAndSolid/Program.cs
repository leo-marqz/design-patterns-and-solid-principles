using DesignPatternsAndSolid.SOLID.SRP;
using System;

namespace DesignPatternsAndSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient
            {
                Id = 1,
                Name = "Elmer Marquez",
                Email = "elmarqz@hotmail.com",
                Address = "Colonia Santa Fe, .....etc"
            };

            var appointment = new Appointment
            {
                Patient = patient,
                Date = DateTime.Now.AddDays(15),
                IsApproved = false
            };

            var response = AppointmentService.Schedule( appointment );

            Console.WriteLine( response );
        }
    }
}
