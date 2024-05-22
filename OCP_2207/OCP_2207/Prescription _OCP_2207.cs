using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2207
{
    internal class Prescription_OCP_2207 : IPrint_OCP_2207
    {
        public Patient_OCP_2207 Patient_2207 { get; set; }
        public List<string> MedicationList { get; set; }
        public List<string> Dosages { get; set; }
        public List<string> Instructions { get; set; }
        public string PrescriptionNumber { get; set; }

        public Prescription_OCP_2207(Patient_OCP_2207 patient, List<string> medications, List<string> dosages, List<string> instructions, string prescriptionNumber)
        {
            Patient_2207 = patient;
            MedicationList = medications;
            Dosages = dosages;
            Instructions = instructions;
            PrescriptionNumber = prescriptionNumber;
        }

        public void DisplayInfo()
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
        public static void CreatePrescription(List<Prescription_OCP_2207> prescriptions, Patient_OCP_2207 patient, List<string> medications, List<string> dosages, List<string> instructions, string prescriptionNumber)
        {
            Prescription_OCP_2207 newPrescription = new Prescription_OCP_2207(patient, medications, dosages, instructions, prescriptionNumber);
            prescriptions.Add(newPrescription);
            Console.WriteLine("Reçete başarıyla oluşturuldu.");
        }
    }
}
