using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal interface IAppointment_ISP_2207
    {
        IPatient_ISP_2207 Patient { get; }
        IDoctor_ISP_2207 Doctor { get; }
        DateTime Date { get; }
        void RescheduleAppointment(DateTime newDate);
    }
}
