using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal interface IDoctor_ISP_2207 : IEntity_ISP_2207
    {
        string Specialization { get; set; }
        void ExaminePatient(IPatient_ISP_2207 patient);
        IPrescription_ISP_2207 WritePrescription();
        void ReferPatient(IPatient_ISP_2207 patient, IDoctor_ISP_2207 referredDoctor);
    }
}
