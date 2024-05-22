using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2207 
{ 
    public class Prescriptions_SRP_2207
    {
        public Patient_SRP_2207 Patient_2207 { get; set; }
        public List<string> MedicationList { get; set; }
        public List<string> Dosages { get; set; }
        public List<string> Instructions { get; set; }
        public string PrescriptionNumber { get; set; }

        public Prescriptions_SRP_2207(Patient_SRP_2207 patient, List<string> medications, List<string> dosages, List<string> instructions, string prescriptionNumber)
        {
            Patient_2207 = patient;
            MedicationList = medications;
            Dosages = dosages;
            Instructions = instructions;
            PrescriptionNumber = prescriptionNumber;
        }
        public static void CreatePrescription(List<Prescriptions_SRP_2207> prescriptions,Patient_SRP_2207 patient, List<string> medications, List<string> dosages, List<string> instructions, string prescriptionNumber)
        {
            Prescriptions_SRP_2207 newPrescription = new Prescriptions_SRP_2207(patient, medications, dosages, instructions, prescriptionNumber);
            prescriptions.Add(newPrescription);
            Console.WriteLine("Reçete başarıyla oluşturuldu.");
        }
        public void DisplayPrescriptionInfo()
        {
            Console.WriteLine($"Hasta: {Patient_2207.Name} {Patient_2207.Surname}");
     
            for (int i = 0; i < MedicationList.Count; i++)
            {
                Console.WriteLine($"İlaç: {MedicationList[i]}");
                Console.WriteLine($"Dozaj: {Dosages[i]}");
                Console.WriteLine($"Talimatlar: {Instructions[i]}");

            }
            Console.WriteLine($"Reçete Numarası: {PrescriptionNumber}");
            Console.WriteLine();

        }
    }

}
