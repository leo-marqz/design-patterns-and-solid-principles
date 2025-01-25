using System;


namespace DesignPatternsAndSolid.SOLID.SRP
{
    internal class AppointmentValidator
    {
        public static ValidationResult Execute( Appointment appointment)
        {
            var result = new ValidationResult();

            if (appointment == null)
                result.Errors.Add("The medical appointment cannot be empty");

            if (appointment.Patient == null)
                result.Errors.Add("The patient cannot be empty");

            if (appointment.Patient != null && string.IsNullOrEmpty(appointment.Patient.Name))
                result.Errors.Add("The patient name cannot be empty");

            if (appointment.Patient != null && string.IsNullOrEmpty(appointment.Patient.Email))
                result.Errors.Add("The patient email cannot be empty");

            if (appointment.Patient.Email != null && !appointment.Patient.Email.Contains("@"))
                result.Errors.Add("The patient email is invalid");

            if (appointment.Date <= DateTime.Now)
                result.Errors.Add("The appointment date must be in the future");

            return result;
        }
    }
}
