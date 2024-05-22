using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    internal class Patient_DIP_2207 : IPatient_DIP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void ViewMedicalRecords()
        {
            Console.WriteLine("Hasta muayene geçmişini görüntülüyor...");
        }
        public void ScheduleAppointment(DateTime date)
        {
            Console.WriteLine($"{Name} {Surname} için {date} tarihinde randevu planlandı.");
        }
    }
}
