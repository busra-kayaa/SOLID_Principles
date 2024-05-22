using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Doctor_ISP_2207 : IDoctor_ISP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }

        public void ExaminePatient(IPatient_ISP_2207 patient)
        {
            Console.WriteLine($"Doktor {Name} {Surname} hastayı muayene ediyor: {patient.Name}");
        }

        public IPrescription_ISP_2207 WritePrescription()
        {
            return new Prescription_ISP_2207();
        }

        public void ReferPatient(IPatient_ISP_2207 patient, IDoctor_ISP_2207 referredDoctor)
        {
            Console.WriteLine($"Doktor {Name} {Surname}, hastayı {referredDoctor.Name} doktoruna yönlendiriyor.");
        }
    }
}
