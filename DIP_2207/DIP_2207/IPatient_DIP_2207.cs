using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    public interface IPatient_DIP_2207
    {
        string Name { get; set; }
        string Surname { get; set; }

        void ViewMedicalRecords();
        void ScheduleAppointment(DateTime date);

    }
}
