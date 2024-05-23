﻿using Microsoft.EntityFrameworkCore;
using kokos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace kokos.Models
{
    public class DbHelperMethods(MyData db) : Controller
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

        public List<PatientInfo> GetPatients()
        {
            return db.PatientInfos.ToList();
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

        public void EditMed(Medication med)
        {
            db.Meds.Update(med);
            db.SaveChanges();
        }

        public int GetMedId(string medName)
        {
            return db.Meds.FirstOrDefault(m => m.Name == medName).Id;
        }

        public bool DoesMedExist(string medName)
        {
            return db.Meds.Any(m => m.Name == medName);
        }

        public List<Medication> GetPatientMeds(string userId)
        {
            return db.Meds.Where(m => m.userId == userId).ToList();
        }
        public List<Prescription> GetPrescriptions(string userId)
        {
            return db.Prescriptions.ToList();
        }
        public void EditPrescription(Prescription pre)
        {
            db.Prescriptions.Update(pre);
            db.SaveChanges();
        }
        public Prescription GetPrescription(int preId)
        {
            return db.Prescriptions.FirstOrDefault(m => m.Id == preId);
        }
        public void AddPrescription(Prescription pre)
        {
            db.Prescriptions.Add(pre);
            db.SaveChanges();
        }

        public void AddPatientsMed(Medication pMed)
        {
            db.Meds.Add(pMed);
            db.SaveChanges(true);
        }

        public Medication GetPatientMed(int id)
        {
            return db.Meds.FirstOrDefault(m => m.Id == id);

        }

        public void DeletePatientMed(int id)
        {
            var pMed = db.Meds.FirstOrDefault(m => m.Id == id);

            if (pMed != null)
            {
                db.Meds.Remove(pMed);
                db.SaveChanges();
            }
        }
        public void DeleteMed(int id)
        {
            var pMed = db.Meds.FirstOrDefault(m => m.Id == id);

            if (pMed != null)
            {
                db.Meds.Remove(pMed);
                db.SaveChanges();
            }
        }
        public List<Medication> GenerateExampleList()
        {
            List<Medication> exampleList = new List<Medication>
            {
                new Medication { Id = 1, Name = "Medicine A", medType = MedType.Pill, dosageType = DosageType.Mg },
                new Medication { Id = 2, Name = "Medicine B", medType = MedType.Pill, dosageType = DosageType.Mg },
                new Medication { Id = 3, Name = "Medicine C", medType = MedType.Liquid, dosageType = DosageType.Mg }
            };

            return exampleList;
        }

    }

}
