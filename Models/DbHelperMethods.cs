using Microsoft.EntityFrameworkCore;

namespace kokos.Models
{
    public class DbHelperMethods(MyData db)
    {
        
        public void AddPatientInfo(PatientInfo pInfo)
        {
            db.PatientInfos.Add(pInfo);
            db.SaveChanges();
        }

        public bool DoesPatientHasInfo(string userId)
        {
            return db.PatientInfos.Any(p => p.UserId == userId);
        }

        public void EditPatientInfo(PatientInfo pInfo)
        {
            db.PatientInfos.Update(pInfo);
            db.SaveChanges();
        }

        public PatientInfo GetPatientInfo(string userId)
        {
            return db.PatientInfos.FirstOrDefault(p => p.UserId == userId);
        }

        public void AddMed(Medication med)
        {
            db.Meds.Add(med);
            db.SaveChanges();
        }

        public bool DoesMedExist(string medName)
        {
            return db.Meds.Any(m => m.Name == medName);
        }


        public List<PatientsMeds> GetPatientMeds(string userId)
        {
            return db.PatientsMeds.Where(m => m.UserId == userId).ToList();
        }

        public void AddPatientsMed(PatientsMeds pMed)
        {
            db.PatientsMeds.Add(pMed);
            db.SaveChanges(true);
        }


        public Medication GetMed(int medId)
        {
            return db.Meds.FirstOrDefault(m => m.Id == medId);
        }

        public PatientsMeds GetPatientMed(string userId, int medId)
        {
            return db.PatientsMeds.FirstOrDefault(m => m.MedId == medId && m.UserId == userId);

        }
        
    }
    
}
