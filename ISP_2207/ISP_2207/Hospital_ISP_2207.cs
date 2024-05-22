using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Hospital_ISP_2207 : IClinic_ISP_2207
    {
        public string Name { get; set; }
        public List<IDoctor_ISP_2207> Doctors { get; set; }

        private List<IAppointment_ISP_2207> appointments;

        public Hospital_ISP_2207()
        {
            Doctors = new List<IDoctor_ISP_2207>();
            appointments = new List<IAppointment_ISP_2207>();
        }

        public void AddDoctor(IDoctor_ISP_2207 doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Doktor {doctor.Name} hastaneye eklendi.");
        }

        public void RemoveDoctor(IDoctor_ISP_2207 doctor)
        {
            Doctors.Remove(doctor);
            Console.WriteLine($"Doktor {doctor.Name} hastaneden çıkarıldı.");
        }

        public void MakeAppointment(IAppointment_ISP_2207 appointment)
        {
            appointments.Add(appointment);
            Console.WriteLine($"Randevu oluşturuldu: Hasta {appointment.Patient.Name}, Doktor {appointment.Doctor.Name}, Tarih {appointment.Date}");
        }

        public void CancelAppointment(IAppointment_ISP_2207 appointment)
        {
            appointments.Remove(appointment);
            Console.WriteLine($"Randevu iptal edildi: Hasta {appointment.Patient.Name}, Doktor {appointment.Doctor.Name}, Tarih {appointment.Date}");
        }
    }
}
