using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor_LSP_2207 doctor = new Doctor_LSP_2207 { Name = "Dr. Ayşe", Surname = "Kaya", Specialization = "Nefroloji", DoctorID = "DK12345", PhoneNumber = "5559876543" };
            doctor.Add();
            doctor.DisplayInfo();
            Console.WriteLine();

            ProfessorDoctor_LSP_2207 professorDoctor = new ProfessorDoctor_LSP_2207 { Name = "Profesör Dr. Mehmet", Surname = "Yılmaz", Specialization = "Dahiliye", DoctorID = "DK12345", PhoneNumber = "5559876543", Field = "Gastroenteroloji " };
            professorDoctor.Add();
            professorDoctor.DisplayInfo();
            professorDoctor.ConductResearch(); 
            Console.WriteLine();

            NormalPatient_LSP_2207 normalPatient = new NormalPatient_LSP_2207 { Name = "Ali", Surname = "Yılmaz", Age = 35 };
            normalPatient.Add();
            normalPatient.DisplayInfo();
            Console.WriteLine();

            normalPatient.Remove();
            Console.WriteLine();

            EmergencyPatient_LSP_2207 emergencyPatient = new EmergencyPatient_LSP_2207 { Name = "Ayşe", Surname = "Kaya", Age = 45 };
            emergencyPatient.Add();
            emergencyPatient.DisplayInfo();
            Console.WriteLine();

            Medication_LSP_2207 medication1 = new Medication_LSP_2207 { Name = "Parol", Dosage = "1", Instructions = "Sabah ve akşam", Price = 10.50m };
            Medication_LSP_2207 medication2 = new Medication_LSP_2207 { Name = "Aspirin", Dosage = "1", Instructions = "Yemeklerden sonra", Price = 8.75m };

            Prescription_LSP_2207 prescription = new Prescription_LSP_2207 { PrescriptionNumber = "RX123456" };
            prescription.AddProduct(medication1);
            prescription.AddProduct(medication2);

            prescription.DisplayInfo();
        }
    }
}
