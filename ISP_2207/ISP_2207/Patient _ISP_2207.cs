using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Patient_ISP_2207 : IPatient_ISP_2207
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactInfo { get; set; }

        public void ViewMedicalRecords()
        {
            Console.WriteLine("Hasta muayene geçmişini görüntülüyor...");
        }
    }
}

