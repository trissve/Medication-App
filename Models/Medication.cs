using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kokos.Models
{
    public class Medication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string userId { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public MedType medType { get; set; }
        public DosageType dosageType { get; set; }
        public int Dosage { get; set; }

        public TimeOfDay Time { get; set; } = TimeOfDay.Morning;
        public bool Taken { get; set; } = true;

        public int prescrId { get; set; } = 0;
    }
}
