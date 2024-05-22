using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPatient_DIP_2207 patient = new Patient_DIP_2207 { Name = "Ali", Surname = "Kaya" };
            IDoctor_DIP_2207 doctor = new Doctor_DIP_2207 { Name = "Dr. Ayşe" , Surname = "Yılmaz"};
            IClinic_DIP_2207 clinic = new Clinic_DIP_2207 { Name = "Merkez Klinik" };
            Console.WriteLine();

            patient.ViewMedicalRecords();
            doctor.ExaminePatient(patient);
            patient.ScheduleAppointment(DateTime.Now.AddDays(3));

            Console.WriteLine();
            IPrescription_DIP_2207 prescription = doctor.WritePrescription();
            clinic.AddDoctor(doctor);
            clinic.RemoveDoctor(doctor);
        }
    }
}
