using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSolid.SOLID.SRP
{
    internal class Appointment
    {
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}
