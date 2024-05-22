using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Appointment_ISP_2207 : IAppointment_ISP_2207
    {
        public IPatient_ISP_2207 Patient { get; }
        public IDoctor_ISP_2207 Doctor { get; }
        public DateTime Date { get; }

        public Appointment_ISP_2207(IPatient_ISP_2207 patient, IDoctor_ISP_2207 doctor, DateTime date)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
        }
        public void RescheduleAppointment(DateTime newDate)
        {
            Console.WriteLine($"Randevu tarihi güncellendi: Yeni Tarih {newDate}");
        }
    }
}
