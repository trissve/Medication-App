using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kokos.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string patientId { get; set; }
        public string doctorId { get; set; }
        public List<Medication> medList { get; set; }
        public DateTime date { get; set; }

    }
}
