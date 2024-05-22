using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2207
{
    public class Appointment_SRP_2207
    {
        public Patient_SRP_2207 Patient_2207 { get; set; }
        public Doctor_SRP_2207 Doctor_2207 { get; set; }
        public Clinic_SRP_2207 Clinic_2207{ get; set; }   
        public DateTime DateTime { get; set; }
        public string Time { get; set; }
        public string AppointmentNumber { get; set; }
        public Appointment_SRP_2207(Patient_SRP_2207 patient, Doctor_SRP_2207 doctor, Clinic_SRP_2207 clinic, DateTime dateTime, string time, string appointmentNumber)
        {
            Patient_2207 = patient;
            Doctor_2207 = doctor;
            Clinic_2207 = clinic;
            DateTime = dateTime;
            Time = time;    
            AppointmentNumber = appointmentNumber;
        }
        public static void CreateAppointment(List<Appointment_SRP_2207> appointments, Patient_SRP_2207 patient, Doctor_SRP_2207 doctor, Clinic_SRP_2207 clinic, DateTime dateTime, string time, string appointmentNumber)
        {
            Appointment_SRP_2207 newAppointment = new Appointment_SRP_2207(patient, doctor,clinic, dateTime, time,appointmentNumber);
            appointments.Add(newAppointment);
            Console.WriteLine("Randevu başarıyla oluşturuldu.");
        }
        public static void CancelAppointment(List<Appointment_SRP_2207> appointments, string appointmentNumber)
        {
            Appointment_SRP_2207 appointmentToCancel = appointments.Find(a => a.AppointmentNumber == appointmentNumber);
            if (appointmentToCancel != null)
            {
                appointments.Remove(appointmentToCancel);
                Console.WriteLine("Randevu başarıyla iptal edildi.");
            }
            else
            {
                Console.WriteLine("Belirtilen randevu numarası ile randevu bulunamadı.");
            }
        }
        public void DisplayAppointmentInfo()
        {
            Console.WriteLine($"Hasta: {Patient_2207.Name} {Patient_2207.Surname}, Doktor: {Doctor_2207.Name} {Doctor_2207.Surname}, Klinik: {Clinic_2207.ClinicName}");
            Console.WriteLine($"Tarih: {DateTime.ToShortDateString()}, Saat: {Time}, Randevu Numarası: {AppointmentNumber}");
            Console.WriteLine();
        }
    }
}
