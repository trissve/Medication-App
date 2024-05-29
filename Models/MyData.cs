using Microsoft.EntityFrameworkCore;

namespace kokos.Models
{
    public class MyData(DbContextOptions<MyData> options) : DbContext(options)
    {
        public DbSet<PatientInfo> PatientInfos { get; set; }
        public DbSet<Medication> Meds { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
    }
}
