
using System.Text;

namespace DesignPatternsAndSolid.SOLID.SRP
{
    internal class AppointmentService
    {
        public static string Schedule( Appointment appointment)
        {
            var result = AppointmentValidator.Execute(appointment);

            if (result.IsValid)
            {
                return $" -- Appointment for [{appointment.Patient.Id}]: {appointment.Patient.Name} on {appointment.Date}";
            }
            else
            {
                StringBuilder sb = new StringBuilder("Errors when scheduling an appointment: \n");
                foreach(string error in result.Errors)
                {
                    sb.Append($"-- {error}\n");
                }
                return sb.ToString();
            }
        }
    }
}
