using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal class Prescription_ISP_2207 : IPrescription_ISP_2207
    {
        public List<string> Medications { get; set; }

        public void PrintPrescription()
        {
            Console.WriteLine("Reçete yazdırılıyor...");
        }
    }
 
}
