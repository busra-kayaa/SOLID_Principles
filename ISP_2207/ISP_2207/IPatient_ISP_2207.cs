using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal interface IPatient_ISP_2207 : IEntity_ISP_2207
    {
        int Age { get; set; }
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
        string ContactInfo { get; set; }
        void ViewMedicalRecords();
    }
}
