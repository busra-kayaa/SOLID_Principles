using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class EmergencyPatient_LSP_2207 : Patient_LSP_2207
    {
        public string EmergencyContact { get; set; }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Acil hasta eklendi.");
        }
        public override void Remove()
        {
            base.Remove();
            Console.WriteLine("Acil hasta çıkarma işlemi gerçekleştirildi.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Hasta tipi: Acil");
        }
    }
}
