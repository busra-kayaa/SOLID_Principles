using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    internal class Doctor_DIP_2207 : IDoctor_DIP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void ExaminePatient(IPatient_DIP_2207 patient)
        {
            Console.WriteLine($"Doktor {Name} {Surname} hastayı muayene ediyor...");
        }

        public IPrescription_DIP_2207 WritePrescription()
        {
            return new Prescription_DIP_2207();
        }
        public void ReferPatient(IPatient_DIP_2207 patient, IDoctor_DIP_2207 referredDoctor)
        {
            Console.WriteLine($"Doktor {Name} {Surname}, {patient.Name} {patient.Surname} adlı hastayı {referredDoctor.Name} {referredDoctor.Surname} adlı doktora yönlendiriyor.");
        }
    }
}
