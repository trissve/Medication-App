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

        public Medication GetMed(int medId)
        {
            return db.Meds.FirstOrDefault(m => m.Id == medId);
        }

        public void DeleteMed(string medName)
        {
            var med = db.Meds.FirstOrDefault(m => m.Name == medName);
            if (med != null)
            {
                db.Meds.Remove(med);
                db.SaveChanges();
            }
        }

        public int GetMedId(string medName)
        {
            return db.Meds.FirstOrDefault(m => m.Name == medName).Id;
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


        public PatientsMeds GetPatientMed(int id)
        {
            return db.PatientsMeds.FirstOrDefault(m => m.Id == id);

        }

        public void DeletePatientMed(int id)
        {
            var pMed = db.PatientsMeds.FirstOrDefault(m => m.Id == id);

            if (pMed != null)
            {
                db.PatientsMeds.Remove(pMed);
                db.SaveChanges();
            }
        }
        
    }
    
}
