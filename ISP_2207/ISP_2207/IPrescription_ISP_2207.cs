using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal interface IPrescription_ISP_2207
    {
        List<string> Medications { get; set; }
        void PrintPrescription();
    }
}
