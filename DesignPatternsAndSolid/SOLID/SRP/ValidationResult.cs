using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSolid.SOLID.SRP
{
    internal class ValidationResult
    {
        public List<string> Errors { get; set; } = new List<string>();
        public bool IsValid { get => !Errors.Any(); }
    }
}
