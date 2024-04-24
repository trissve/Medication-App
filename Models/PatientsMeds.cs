using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace kokos.Models
{
    public class PatientsMeds
    {
        [Key]
        public string UserId { get; set; }

        public int MedId { get; set; }

        public int Dosage { get; set; }

        public TimeOfDay Time { get; set; }
    }
}
