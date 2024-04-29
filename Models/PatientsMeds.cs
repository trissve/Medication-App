using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace kokos.Models
{
    public class PatientsMeds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserId { get; set; }

        public int MedId { get; set; }

        public int Dosage { get; set; }

        public TimeOfDay Time { get; set; }
    }
}
