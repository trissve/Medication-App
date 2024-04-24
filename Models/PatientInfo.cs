using System.ComponentModel.DataAnnotations;

namespace kokos.Models
{
    public class PatientInfo
    {
        [Key]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

    }
}
