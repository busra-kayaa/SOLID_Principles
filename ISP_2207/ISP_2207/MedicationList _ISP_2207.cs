using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class MedicationList__ISP_2207 : IMedicationList_ISP_2207
    {
        public List<string> Medications { get; }

        public MedicationList__ISP_2207(List<string> medications)
        {
            Medications = medications;
        }
    }
}
