using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPatient_ISP_2207 patient = new Patient_ISP_2207 { Name = "Ali", Age = 35, Gender = "Erkek", DateOfBirth = new DateTime(1989, 5, 10), ContactInfo = "1234567890" };
            IDoctor_ISP_2207 doctor = new Doctor_ISP_2207 { Name = "Dr. Ayşe", Surname = "Kart", Specialization = "Genel Cerrahi" };

            Hospital_ISP_2207 hospital = new Hospital_ISP_2207();

            hospital.AddDoctor(doctor);
            Console.WriteLine();

            IAppointment_ISP_2207 appointment = new Appointment_ISP_2207(patient, doctor, DateTime.Now.AddDays(3));
            Console.WriteLine();

            hospital.MakeAppointment(appointment);

            patient.ViewMedicalRecords();

            doctor.ExaminePatient(patient);
            Console.WriteLine();

            IPrescription_ISP_2207 prescription = doctor.WritePrescription();
            prescription.PrintPrescription();
            Console.WriteLine();

            IDoctor_ISP_2207 referredDoctor = new Doctor_ISP_2207 { Name = "Dr. Mehmet", Specialization = "Kardiyoloji" };
            doctor.ReferPatient(patient, referredDoctor);

            appointment.RescheduleAppointment(DateTime.Now.AddDays(5));

        }
    }
}
