using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    public interface IDoctor_DIP_2207
    {
        string Name { get; set; }
        string Surname { get; set; }

        void ExaminePatient(IPatient_DIP_2207 patient);
        IPrescription_DIP_2207 WritePrescription();
        void ReferPatient(IPatient_DIP_2207 patient, IDoctor_DIP_2207 referredDoctor);

    }
}
