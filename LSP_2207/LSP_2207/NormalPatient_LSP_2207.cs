using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class NormalPatient_LSP_2207 : Patient_LSP_2207
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Normal hasta eklendi.");
        }
        public override void Remove()
        {
            base.Remove();
            Console.WriteLine("Normal hasta çıkarma işlemi gerçekleştirildi.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
