using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2207
{
    internal class Patient_Examination_OCP_2207 : IPrint_OCP_2207
    {
        public Patient_OCP_2207 Patient_2207 { get; set; }
        public Doctor_OCP_2207 Doctor_2207 { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string Findings { get; set; }
        public string Diagnoses { get; set; }

        public Patient_Examination_OCP_2207(Patient_OCP_2207 patient, Doctor_OCP_2207 doctor, DateTime examinationDate, string findings, string diagnoses)
        {
            Patient_2207 = patient;
            Doctor_2207 = doctor;
            ExaminationDate = examinationDate;
            Findings = findings;
            Diagnoses = diagnoses;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Hasta: {Patient_2207.Name} {Patient_2207.Surname}");
            Console.WriteLine($"Doktor: {Doctor_2207.Name} {Doctor_2207.Surname}");
            Console.WriteLine($"Muayene Tarihi: {ExaminationDate}");
            Console.WriteLine();
            Console.WriteLine("Bulgu:");
            Console.WriteLine(Findings);

            Console.WriteLine("Teşhis:");
            Console.WriteLine(Diagnoses);

        }
        public static void CancelExamination(List<Patient_Examination_OCP_2207> examinations, Patient_OCP_2207 patient)
        {
            Patient_Examination_OCP_2207 examinationToCancel = examinations.Find(e => e.Patient_2207 == patient);
            if (examinationToCancel != null)
            {
                examinations.Remove(examinationToCancel);
                Console.WriteLine("Muayene başarıyla iptal edildi.");
            }
            else
            {
                Console.WriteLine("Belirtilen hastaya ait muayene bulunamadı.");
            }
        }
        public static void ReferPatient(List<Patient_Examination_OCP_2207> examinations, Patient_OCP_2207 patient, Doctor_OCP_2207 newDoctor)
        {
            Patient_Examination_OCP_2207 examinationToRefer = examinations.Find(e => e.Patient_2207 == patient);
            if (examinationToRefer != null)
            {
                examinationToRefer.Doctor_2207 = newDoctor;
                Console.WriteLine($"{patient.Name} {patient.Surname} hastası başka bir doktora sevk edildi. Yeni doktor: {newDoctor.Name} {newDoctor.Surname}");
            }
            else
            {
                Console.WriteLine("Belirtilen hastaya ait muayene bulunamadı.");
            }
        }
    }
}
